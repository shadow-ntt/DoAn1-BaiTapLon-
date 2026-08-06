using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DoAn1.Models.Tables;
using DoAn1.Services;
using Xceed.Words.NET;

namespace DoAn1.Views
{
    public partial class InvoiceBillingControl : UserControl
    {
        private readonly AccountantService _accountantService;
        private List<Order> _approvedOrders;

        public InvoiceBillingControl()
        {
            _accountantService = new AccountantService();
            _approvedOrders = new List<Order>();
            InitializeComponent();
            LoadApprovedOrders();
        }

        private void TxtSearchInvoice_TextChanged(object sender, EventArgs e) => LoadApprovedOrders();

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchInvoice.Clear();
            LoadApprovedOrders();
        }

        private void LoadApprovedOrders()
        {
            string keyword = txtSearchInvoice?.Text.Trim() ?? "";
            lstApprovedOrders.Items.Clear();

            _approvedOrders = _accountantService.GetApprovedOrders();
            var filtered = _approvedOrders.Where(o =>
                string.IsNullOrEmpty(keyword) ||
                o.OrderId.ToString().Contains(keyword) ||
                (o.Customer != null && o.Customer.FullName.ToLower().Contains(keyword.ToLower()))
            ).ToList();

            foreach (var order in filtered)
            {
                string custName = order.Customer?.FullName ?? "Khách lẻ";
                lstApprovedOrders.Items.Add($"#{order.OrderId} — {custName}");
            }

            if (filtered.Count > 0)
            {
                lstApprovedOrders.SelectedIndex = 0;
            }
            else
            {
                ClearFields();
            }
        }

        private void LstApprovedOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstApprovedOrders.SelectedIndex;
            if (idx < 0 || idx >= _approvedOrders.Count)
            {
                ClearFields();
                return;
            }

            Order selectedOrder = _approvedOrders[idx];
            txtCustName.Text = selectedOrder.Customer?.FullName ?? "Khách lẻ";
            txtTaxCode.Text = selectedOrder.Customer?.TaxCode ?? "N/A";
            txtOrderDate.Text = selectedOrder.OrderDate.ToString("dd/MM/yyyy HH:mm");
            lblOrderTitle.Text = $"Chi tiết đơn hàng hợp lệ: #{selectedOrder.OrderId}";

            GeneratePreviews(selectedOrder);
        }

        private void GeneratePreviews(Order order)
        {
            if (order == null) return;
            string custName = order.Customer?.FullName ?? "Khách lẻ";
            string taxCode = order.Customer?.TaxCode ?? "N/A";

            // Invoice
            StringBuilder invSb = new StringBuilder();
            invSb.AppendLine("===========================================");
            invSb.AppendLine("             HÓA ĐƠN BÁN HÀNG             ");
            invSb.AppendLine("===========================================");
            invSb.AppendLine($"Mã đơn hàng: #{order.OrderId}");
            invSb.AppendLine($"Khách hàng : {custName}");
            invSb.AppendLine($"Mã số thuế : {taxCode}");
            invSb.AppendLine($"Ngày đặt   : {order.OrderDate:dd/MM/yyyy HH:mm}");
            invSb.AppendLine($"Ngày lập HĐ: {DateTime.Now:dd/MM/yyyy}");
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

            // Packing Slip
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

        private void ClearFields()
        {
            lblOrderTitle.Text = "Chi tiết đơn hàng hợp lệ: ---";
            txtCustName.Clear();
            txtTaxCode.Clear();
            txtOrderDate.Clear();
            txtInvoicePreview.Clear();
            txtPackingSlipPreview.Clear();
        }

        private void BtnExportInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoicePreview.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xuất hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExportToFile("HoaDon_", txtInvoicePreview.Text);
        }

        private void BtnExportPackingSlip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPackingSlipPreview.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xuất tờ khai!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExportToFile("ToKhaiKienHang_", txtPackingSlipPreview.Text);
        }

        private void ExportToFile(string prefix, string content)
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
                        using (DocX doc = DocX.Create(sfd.FileName))
                        {
                            var p = doc.InsertParagraph();
                            p.Append(content).Font("Consolas").FontSize(10.5);
                            doc.Save();
                        }
                    }
                    else
                    {
                        File.WriteAllText(sfd.FileName, content, Encoding.UTF8);
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCompleteInvoice_Click(object sender, EventArgs e)
        {
            int idx = lstApprovedOrders.SelectedIndex;
            if (idx < 0 || idx >= _approvedOrders.Count)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để hoàn tất lập hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Order selectedOrder = _approvedOrders[idx];
            var confirm = MessageBox.Show($"Xác nhận hoàn tất lập Hóa đơn (2 bản) và Tờ khai kiện hàng cho đơn hàng [#{selectedOrder.OrderId}]?", "Xác nhận hoàn tất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool ok = _accountantService.ProcessInvoiceAndPackingSlip(selectedOrder.OrderId);
                if (ok)
                {
                    MessageBox.Show("Đã hoàn tất lập hóa đơn & tờ khai! Đơn hàng đã được lưu và chuyển sang hồ sơ sẵn sàng giao hàng (ReadyDelivery).", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadApprovedOrders();
                }
                else
                {
                    MessageBox.Show("Xử lý thất bại! Vui lòng kiểm tra lại trạng thái đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
