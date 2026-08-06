using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using DoAn1.Models.Helpers;
using DoAn1.Services;

namespace DoAn1.Views
{
    public partial class RevenueReportControl : UserControl
    {
        private readonly AccountantService _accountantService;
        private readonly int _viewMode; // 0=general, 1=customer, 2=product

        private List<RevenueReportDTO> _currentGeneralList;
        private List<CustomerRevenueDTO> _currentCustList;
        private List<ProductRevenueDTO> _currentProdList;

        public RevenueReportControl(int defaultTabIndex = 0)
        {
            _accountantService = new AccountantService();
            _viewMode = defaultTabIndex;
            _currentGeneralList = new List<RevenueReportDTO>();
            _currentCustList = new List<CustomerRevenueDTO>();
            _currentProdList = new List<ProductRevenueDTO>();

            InitializeComponent();

            switch (_viewMode)
            {
                case 0: BuildGeneralView(); break;
                case 1: BuildCustomerView(); break;
                case 2: BuildProductView(); break;
            }

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            switch (_viewMode)
            {
                case 0: LoadGeneralRevenue(); break;
                case 1: LoadCustomerRevenue(); break;
                case 2: LoadProductRevenue(); break;
            }
        }

        private void BtnFilterGen_Click(object sender, EventArgs e) => LoadGeneralRevenue();
        private void BtnFilterCust_Click(object sender, EventArgs e) => LoadCustomerRevenue();
        private void BtnFilterProd_Click(object sender, EventArgs e) => LoadProductRevenue();

        private void LoadGeneralRevenue()
        {
            DateTime fromDate = dtpFromDate != null ? dtpFromDate.Value.Date : DateTime.Now.Date;
            DateTime toDate = dtpToDate != null ? dtpToDate.Value.Date.AddDays(1).AddSeconds(-1) : DateTime.Now;
            string keyword = txtSearchGen?.Text.Trim() ?? "";

            _currentGeneralList = _accountantService.GetRevenueReport(fromDate, toDate, keyword);
            if (dgvGeneralRevenue != null)
            {
                dgvGeneralRevenue.DataSource = _currentGeneralList;

                if (dgvGeneralRevenue.Columns["InvoiceId"] != null) dgvGeneralRevenue.Columns["InvoiceId"].HeaderText = "Mã HĐ";
                if (dgvGeneralRevenue.Columns["OrderId"] != null) dgvGeneralRevenue.Columns["OrderId"].HeaderText = "Mã Đơn";
                if (dgvGeneralRevenue.Columns["CustomerName"] != null) dgvGeneralRevenue.Columns["CustomerName"].HeaderText = "Khách Hàng";
                if (dgvGeneralRevenue.Columns["TaxCode"] != null) dgvGeneralRevenue.Columns["TaxCode"].HeaderText = "Mã Số Thuế";
                if (dgvGeneralRevenue.Columns["PaidDate"] != null) dgvGeneralRevenue.Columns["PaidDate"].HeaderText = "Ngày Thanh Toán";
                if (dgvGeneralRevenue.Columns["TotalAmount"] != null)
                {
                    dgvGeneralRevenue.Columns["TotalAmount"].HeaderText = "Thành Tiền (VNĐ)";
                    dgvGeneralRevenue.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (dgvGeneralRevenue.Columns["Status"] != null) dgvGeneralRevenue.Columns["Status"].HeaderText = "Trạng Thái";
            }

            decimal totalRev = _currentGeneralList.Sum(x => x.TotalAmount);
            int orderCount = _currentGeneralList.Count;
            decimal avgRev = orderCount > 0 ? totalRev / orderCount : 0;

            if (lblCardTotalVal != null) lblCardTotalVal.Text = $"{totalRev:N0} VNĐ";
            if (lblCardCountVal != null) lblCardCountVal.Text = $"{orderCount} Hóa đơn";
            if (lblCardAvgVal != null) lblCardAvgVal.Text = $"{avgRev:N0} VNĐ";
        }

        private void LoadCustomerRevenue()
        {
            string keyword = txtSearchCust?.Text.Trim() ?? "";
            _currentCustList = _accountantService.GetRevenueByCustomer(null, null, keyword);
            if (dgvCustomerRevenue != null)
            {
                dgvCustomerRevenue.DataSource = _currentCustList;

                if (dgvCustomerRevenue.Columns["CustomerId"] != null) dgvCustomerRevenue.Columns["CustomerId"].HeaderText = "Mã KH";
                if (dgvCustomerRevenue.Columns["CustomerName"] != null) dgvCustomerRevenue.Columns["CustomerName"].HeaderText = "Họ và Tên Khách Hàng";
                if (dgvCustomerRevenue.Columns["TaxCode"] != null) dgvCustomerRevenue.Columns["TaxCode"].HeaderText = "Mã Số Thuế";
                if (dgvCustomerRevenue.Columns["City"] != null) dgvCustomerRevenue.Columns["City"].HeaderText = "Thành Phố";
                if (dgvCustomerRevenue.Columns["OrderCount"] != null) dgvCustomerRevenue.Columns["OrderCount"].HeaderText = "Số Đơn Đã Mua";
                if (dgvCustomerRevenue.Columns["TotalRevenue"] != null)
                {
                    dgvCustomerRevenue.Columns["TotalRevenue"].HeaderText = "Tổng Chi Tiêu (VNĐ)";
                    dgvCustomerRevenue.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
                }
            }
        }

        private void LoadProductRevenue()
        {
            string keyword = txtSearchProd?.Text.Trim() ?? "";
            _currentProdList = _accountantService.GetRevenueByProduct(null, null, keyword);
            if (dgvProductRevenue != null)
            {
                dgvProductRevenue.DataSource = _currentProdList;

                if (dgvProductRevenue.Columns["ProductId"] != null) dgvProductRevenue.Columns["ProductId"].HeaderText = "Mã SP";
                if (dgvProductRevenue.Columns["ProductName"] != null) dgvProductRevenue.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                if (dgvProductRevenue.Columns["Type"] != null) dgvProductRevenue.Columns["Type"].HeaderText = "Loại SP";
                if (dgvProductRevenue.Columns["TotalQuantitySold"] != null) dgvProductRevenue.Columns["TotalQuantitySold"].HeaderText = "Tổng SL Đã Bán";
                if (dgvProductRevenue.Columns["TotalRevenue"] != null)
                {
                    dgvProductRevenue.Columns["TotalRevenue"].HeaderText = "Doanh Thu SP (VNĐ)";
                    dgvProductRevenue.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
                }
            }
        }

        private void BtnExportGenExcel_Click(object sender, EventArgs e)
        {
            if (_currentGeneralList == null || _currentGeneralList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu báo cáo để xuất Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoDoanhThu_TongQuan_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Doanh Thu Tổng Quan");
                        worksheet.Cell(1, 1).Value = "Mã HĐ";
                        worksheet.Cell(1, 2).Value = "Mã Đơn";
                        worksheet.Cell(1, 3).Value = "Khách Hàng";
                        worksheet.Cell(1, 4).Value = "Mã Số Thuế";
                        worksheet.Cell(1, 5).Value = "Ngày Thanh Toán";
                        worksheet.Cell(1, 6).Value = "Thành Tiền (VNĐ)";
                        worksheet.Cell(1, 7).Value = "Trạng Thái";

                        int row = 2;
                        foreach (var item in _currentGeneralList)
                        {
                            worksheet.Cell(row, 1).Value = item.InvoiceId;
                            worksheet.Cell(row, 2).Value = item.OrderId;
                            worksheet.Cell(row, 3).Value = item.CustomerName;
                            worksheet.Cell(row, 4).Value = item.TaxCode;
                            worksheet.Cell(row, 5).Value = item.PaidDate.ToString("dd/MM/yyyy HH:mm");
                            worksheet.Cell(row, 6).Value = item.TotalAmount;
                            worksheet.Cell(row, 7).Value = item.Status;
                            row++;
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportCustExcel_Click(object sender, EventArgs e)
        {
            if (_currentCustList == null || _currentCustList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"DoanhThu_TheoKhachHang_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Doanh Thu Khách Hàng");
                        worksheet.Cell(1, 1).Value = "Mã KH";
                        worksheet.Cell(1, 2).Value = "Tên Khách Hàng";
                        worksheet.Cell(1, 3).Value = "Mã Số Thuế";
                        worksheet.Cell(1, 4).Value = "Thành Phố";
                        worksheet.Cell(1, 5).Value = "Số Đơn Đã Mua";
                        worksheet.Cell(1, 6).Value = "Tổng Doanh Thu (VNĐ)";

                        int row = 2;
                        foreach (var item in _currentCustList)
                        {
                            worksheet.Cell(row, 1).Value = item.CustomerId;
                            worksheet.Cell(row, 2).Value = item.CustomerName;
                            worksheet.Cell(row, 3).Value = item.TaxCode;
                            worksheet.Cell(row, 4).Value = item.City;
                            worksheet.Cell(row, 5).Value = item.OrderCount;
                            worksheet.Cell(row, 6).Value = item.TotalRevenue;
                            row++;
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất Excel doanh thu khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportProdExcel_Click(object sender, EventArgs e)
        {
            if (_currentProdList == null || _currentProdList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"DoanhThu_TheoSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Doanh Thu Sản Phẩm");
                        worksheet.Cell(1, 1).Value = "Mã SP";
                        worksheet.Cell(1, 2).Value = "Tên Sản Phẩm";
                        worksheet.Cell(1, 3).Value = "Loại SP";
                        worksheet.Cell(1, 4).Value = "Tổng SL Đã Bán";
                        worksheet.Cell(1, 5).Value = "Tổng Doanh Thu (VNĐ)";

                        int row = 2;
                        foreach (var item in _currentProdList)
                        {
                            worksheet.Cell(row, 1).Value = item.ProductId;
                            worksheet.Cell(row, 2).Value = item.ProductName;
                            worksheet.Cell(row, 3).Value = item.Type;
                            worksheet.Cell(row, 4).Value = item.TotalQuantitySold;
                            worksheet.Cell(row, 5).Value = item.TotalRevenue;
                            row++;
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất Excel doanh thu sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
