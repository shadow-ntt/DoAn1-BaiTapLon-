using System.Text;
using ClosedXML.Excel;
using DoAn1.Models.Tables;
using DoAn1.Models.Helpers;
using DoAn1.Services;
using Xceed.Words.NET;

namespace DoAn1.Forms
{
    public partial class AccountantForm : Form
    {
        private readonly AccountantService _accountantService;
        private List<Order> _approvedOrders;
        private List<RevenueReportDTO> _currentRevenueList;

        public AccountantForm()
        {
            InitializeComponent();
            _accountantService = new AccountantService();
            _approvedOrders = new List<Order>();
            _currentRevenueList = new List<RevenueReportDTO>();
        }

        #region --- 1. SỰ KIỆN CHUNG & TỰ ĐỘNG REFRESH ---

        private void AccountantForm_Load(object sender, EventArgs e)
        {
            // Cấu hình lọc doanh thu từ đầu tháng hiện tại
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;

            // Tải dữ liệu ban đầu cho Tab 1
            LoadApprovedOrders();
        }

        private void TabControlAccountant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAccountant.SelectedIndex == 0)
            {
                LoadApprovedOrders();
            }
            else if (tabControlAccountant.SelectedIndex == 1)
            {
                LoadRevenueData();
            }
        }

        #endregion

        #region --- 2. LOGIC TAB 1: LẬP HÓA ĐƠN & TỜ KHAI (XUẤT WORD .DOCX) ---

        private async void BtnRefreshInvoice_Click(object sender, EventArgs e)
        {
            btnRefreshInvoice.Enabled = false;
            btnRefreshInvoice.Text = "Đang tải...";

            await Task.Delay(200);

            LoadApprovedOrders(showNotification: true);

            btnRefreshInvoice.Text = "Làm mới";
            btnRefreshInvoice.Enabled = true;
        }

        private void LoadApprovedOrders(bool showNotification = false)
        {
            lstApprovedOrders.Items.Clear();

            // Lấy danh sách đơn hàng đã kiểm duyệt (Reviewed) từ Service
            _approvedOrders = _accountantService.GetApprovedOrders();

            foreach (var order in _approvedOrders)
            {
                string custName = order.Customer?.FullName ?? "Khách hàng vãng lai";
                lstApprovedOrders.Items.Add($"#{order.OrderId} - {custName}");
            }

            if (_approvedOrders.Count > 0)
            {
                lstApprovedOrders.SelectedIndex = 0;
            }
            else
            {
                ClearInvoicePreviewFields();
            }

            if (showNotification)
            {
                MessageBox.Show($"Đã cập nhật danh sách! Có {_approvedOrders.Count} đơn hàng chờ lập hóa đơn.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LstApprovedOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstApprovedOrders.SelectedIndex;
            if (index < 0 || index >= _approvedOrders.Count)
            {
                ClearInvoicePreviewFields();
                return;
            }

            Order selectedOrder = _approvedOrders[index];

            string custName = selectedOrder.Customer?.FullName ?? "Khách hàng vãng lai";
            string taxCode = selectedOrder.Customer?.TaxCode ?? "N/A";

            lblOrderTitle.Text = $"Chi tiết đơn hàng hợp lệ: #{selectedOrder.OrderId}";
            txtCustomerName.Text = custName;
            txtTaxCode.Text = taxCode;
            txtOrderDate.Text = selectedOrder.OrderDate.ToString("dd/MM/yyyy HH:mm");

            GeneratePreviews(selectedOrder);
        }

        private void GeneratePreviews(Order order)
        {
            if (order == null) return;

            string custName = order.Customer?.FullName ?? "Khách hàng vãng lai";
            string taxCode = order.Customer?.TaxCode ?? "N/A";

            // Xem trước Hóa đơn
            StringBuilder invSb = new StringBuilder();
            invSb.AppendLine("===========================================");
            invSb.AppendLine("             HÓA ĐƠN BÁN HÀNG             ");
            invSb.AppendLine("===========================================");
            invSb.AppendLine($"Mã đơn hàng: #{order.OrderId}");
            invSb.AppendLine($"Khách hàng : {custName}");
            invSb.AppendLine($"Mã số thuế : {taxCode}");
            invSb.AppendLine($"Ngày đặt   : {order.OrderDate:dd/MM/yyyy HH:mm}");
            invSb.AppendLine($"Ngày lập hóa đơn: {DateTime.Now:dd/MM/yyyy}");
            invSb.AppendLine("-------------------------------------------");
            invSb.AppendLine(string.Format("{0,-20} {1,5} {2,15}", "Sản phẩm", "SL", "Thành tiền"));

            decimal subtotal = 0;
            int itemIndex = 1;

            if (order.OrderDetails != null)
            {
                foreach (var detail in order.OrderDetails)
                {
                    string prodName = detail.Product?.ProductName ?? "Sản phẩm";
                    if (prodName.Length > 18) prodName = prodName.Substring(0, 15) + "...";

                    decimal lineTotal = detail.Quantity * detail.UnitPrice;
                    subtotal += lineTotal;

                    invSb.AppendLine($"{itemIndex++}. {prodName,-16} {detail.Quantity,5} {lineTotal,15:N0}");
                }
            }

            decimal vat = subtotal * 0.1m;
            decimal grandTotal = subtotal + vat;

            invSb.AppendLine("-------------------------------------------");
            invSb.AppendLine($"Tổng tiền chưa thuế: {subtotal,20:N0} VNĐ");
            invSb.AppendLine($"Thuế VAT (10%):     {vat,20:N0} VNĐ");
            invSb.AppendLine($"TỔNG CỘNG THANH TOÁN:{grandTotal,20:N0} VNĐ");
            invSb.AppendLine("===========================================");

            txtInvoicePreview.Text = invSb.ToString();

            // Xem trước Tờ khai kiện hàng
            StringBuilder packSb = new StringBuilder();
            packSb.AppendLine("===========================================");
            packSb.AppendLine("       TỜ KHAI KIỆN HÀNG ĐÓNG GÓI          ");
            packSb.AppendLine("===========================================");
            packSb.AppendLine($"Mã đơn hàng : #{order.OrderId}");
            packSb.AppendLine($"Đơn vị nhận : {custName}");
            packSb.AppendLine($"Ngày xuất kho: {DateTime.Now:dd/MM/yyyy}");
            packSb.AppendLine("-------------------------------------------");
            packSb.AppendLine("Chi tiết danh mục đóng gói:");

            if (order.OrderDetails != null)
            {
                foreach (var detail in order.OrderDetails)
                {
                    string prodName = detail.Product?.ProductName ?? "Sản phẩm";
                    packSb.AppendLine($"- {prodName}: {detail.Quantity} cái/bộ");
                }
            }

            packSb.AppendLine("-------------------------------------------");
            packSb.AppendLine("Người lập tờ khai: Kế toán phòng xuất hàng");
            packSb.AppendLine("Trạng thái: Đã niêm phong tem niêm phong");
            packSb.AppendLine("===========================================");

            txtPackingSlipPreview.Text = packSb.ToString();
        }

        private void BtnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoicePreview.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xuất file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportToDocxOrTxt("HoaDon_", txtInvoicePreview.Text);
        }

        private void BtnPrintPackingSlip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPackingSlipPreview.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xuất file!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportToDocxOrTxt("ToKhaiKienHang_", txtPackingSlipPreview.Text);
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            int index = lstApprovedOrders.SelectedIndex;
            if (index < 0 || index >= _approvedOrders.Count)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để hoàn tất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Order selectedOrder = _approvedOrders[index];

            DialogResult result = MessageBox.Show($"Xác nhận hoàn thành lập Hóa đơn & Tờ khai cho đơn hàng [#{selectedOrder.OrderId}]?",
                                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _accountantService.ProcessInvoiceAndPackingSlip(selectedOrder.OrderId);

                if (success)
                {
                    MessageBox.Show("Đã hoàn tất lập hóa đơn! Đơn hàng đã chuyển sang trạng thái ReadyDelivery.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadApprovedOrders(showNotification: false);
                }
                else
                {
                    MessageBox.Show("Xử lý thất bại! Không tìm thấy đơn hàng hoặc trạng thái không hợp lệ.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearInvoicePreviewFields()
        {
            lblOrderTitle.Text = "Chi tiết đơn hàng hợp lệ: ---";
            txtCustomerName.Clear();
            txtTaxCode.Clear();
            txtOrderDate.Clear();
            txtInvoicePreview.Clear();
            txtPackingSlipPreview.Clear();
        }

        #endregion

        #region --- 3. LOGIC TAB 2: QUẢN LÝ DOANH THU (XUẤT EXCEL .XLSX) ---

        private async void BtnRefreshRevenue_Click(object sender, EventArgs e)
        {
            btnRefreshRevenue.Enabled = false;
            btnRefreshRevenue.Text = "Đang tải...";

            await Task.Delay(200);

            LoadRevenueData(showNotification: true);

            btnRefreshRevenue.Text = "Làm mới";
            btnRefreshRevenue.Enabled = true;
        }

        private void BtnFilterRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenueData(showNotification: false);
        }

        private void TxtSearchRevenue_TextChanged(object sender, EventArgs e)
        {
            LoadRevenueData(showNotification: false);
        }

        private void LoadRevenueData(bool showNotification = false)
        {
            DateTime? fromDate = dtpFromDate.Value;
            DateTime? toDate = dtpToDate.Value;
            string keyword = txtSearchRevenue.Text.Trim();

            _currentRevenueList = _accountantService.GetRevenueReport(fromDate, toDate, keyword);

            dgvRevenue.DataSource = null;
            dgvRevenue.DataSource = _currentRevenueList;

            UpdateSummaryCards(_currentRevenueList);

            if (showNotification)
            {
                MessageBox.Show($"Đã cập nhật dữ liệu doanh thu! Tìm thấy {_currentRevenueList.Count} hóa đơn hoàn tất.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateSummaryCards(List<RevenueReportDTO> list)
        {
            if (list == null || list.Count == 0)
            {
                lblCardTotalValue.Text = "0 VNĐ";
                lblCardCountValue.Text = "0 Hóa đơn";
                lblCardAvgValue.Text = "0 VNĐ";
                return;
            }

            decimal totalRevenue = list.Sum(item => item.TotalAmount);
            int count = list.Count;
            decimal avg = count > 0 ? totalRevenue / count : 0;

            lblCardTotalValue.Text = $"{totalRevenue:N0} VNĐ";
            lblCardCountValue.Text = $"{count} Hóa đơn";
            lblCardAvgValue.Text = $"{avg:N0} VNĐ";
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            if (_currentRevenueList == null || _currentRevenueList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuất file Excel chuẩn bằng ClosedXML
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Báo Cáo Doanh Thu");

                        // 1. Tiêu đề Báo cáo
                        worksheet.Cell(1, 1).Value = "BÁO CÁO DOANH THU BÁN HÀNG";
                        worksheet.Range(1, 1, 1, 7).Merge();
                        worksheet.Cell(1, 1).Style.Font.Bold = true;
                        worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                        worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Ngày xuất báo cáo
                        worksheet.Cell(2, 1).Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}";
                        worksheet.Range(2, 1, 2, 7).Merge();
                        worksheet.Cell(2, 1).Style.Font.Italic = true;
                        worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // 2. Tạo Header Bảng
                        string[] headers = { "Mã Hóa Đơn", "Mã Đơn Hàng", "Tên Khách Hàng", "Mã Số Thuế", "Ngày Thanh Toán", "Tổng Tiền (VNĐ)", "Trạng Thái" };
                        for (int i = 0; i < headers.Length; i++)
                        {
                            var cell = worksheet.Cell(4, i + 1);
                            cell.Value = headers[i];
                            cell.Style.Font.Bold = true;
                            cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#4F46E5"); // Màu tím pastel
                            cell.Style.Font.FontColor = XLColor.White;
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }

                        // 3. Đổ Dữ Liệu vào Bảng
                        int rowIndex = 5;
                        foreach (var item in _currentRevenueList)
                        {
                            worksheet.Cell(rowIndex, 1).Value = item.InvoiceId;
                            worksheet.Cell(rowIndex, 2).Value = item.OrderId;
                            worksheet.Cell(rowIndex, 3).Value = item.CustomerName;
                            worksheet.Cell(rowIndex, 4).Value = item.TaxCode;
                            worksheet.Cell(rowIndex, 5).Value = item.PaidDate.ToString("dd/MM/yyyy HH:mm");

                            var totalCell = worksheet.Cell(rowIndex, 6);
                            totalCell.Value = item.TotalAmount;
                            totalCell.Style.NumberFormat.Format = "#,##0"; // Định dạng tiền tệ

                            worksheet.Cell(rowIndex, 7).Value = item.Status;

                            // Căn giữa cho các cột ngắn
                            worksheet.Cell(rowIndex, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Cell(rowIndex, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Cell(rowIndex, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Cell(rowIndex, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Cell(rowIndex, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                            rowIndex++;
                        }

                        // 4. Dòng Tổng Cộng
                        worksheet.Cell(rowIndex, 5).Value = "TỔNG CỘNG:";
                        worksheet.Cell(rowIndex, 5).Style.Font.Bold = true;
                        worksheet.Cell(rowIndex, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        var grandTotalCell = worksheet.Cell(rowIndex, 6);
                        grandTotalCell.Value = _currentRevenueList.Sum(x => x.TotalAmount);
                        grandTotalCell.Style.Font.Bold = true;
                        grandTotalCell.Style.NumberFormat.Format = "#,##0";

                        // 5. Tự động chỉnh kích thước cột
                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất báo cáo Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region --- 4. HÀM TRỢ GIÚP (HELPER FUNCTIONS) ---

        private void ExportToDocxOrTxt(string prefix, string content)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx|Text File (*.txt)|*.txt",
                DefaultExt = "docx",
                FileName = $"{prefix}{DateTime.Now:yyyyMMdd_HHmmss}"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(sfd.FileName).ToLower();

                    if (ext == ".docx")
                    {
                        // Xuất Word bằng NuGet DocX
                        using (DocX doc = DocX.Create(sfd.FileName))
                        {
                            var p = doc.InsertParagraph();
                            p.Append(content)
                             .Font("Consolas")
                             .FontSize(10.5);

                            doc.Save();
                        }
                    }
                    else
                    {
                        // Xuất TXT
                        File.WriteAllText(sfd.FileName, content, Encoding.UTF8);
                    }

                    MessageBox.Show("Xuất file văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}