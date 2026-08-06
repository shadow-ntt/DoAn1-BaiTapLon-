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

        public RevenueReportControl() : this(0)
        {
        }

        public RevenueReportControl(int defaultTabIndex = 0)
        {
            _accountantService = new AccountantService();
            _viewMode = defaultTabIndex;
            _currentGeneralList = new List<RevenueReportDTO>();
            _currentCustList = new List<CustomerRevenueDTO>();
            _currentProdList = new List<ProductRevenueDTO>();

            InitializeComponent();

            RegisterEvents();

            if (defaultTabIndex >= 0 && defaultTabIndex < tabControlMain.TabCount)
            {
                tabControlMain.SelectedIndex = defaultTabIndex;
            }

            LoadInitialData();
        }

        private void RegisterEvents()
        {
            btnFilterGen.Click += BtnFilterGen_Click;
            btnExportGenExcel.Click += BtnExportGenExcel_Click;

            btnFilterCust.Click += BtnFilterCust_Click;
            btnExportCustExcel.Click += BtnExportCustExcel_Click;

            btnFilterProd.Click += BtnFilterProd_Click;
            btnExportProdExcel.Click += BtnExportProdExcel_Click;

            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0: LoadGeneralRevenue(); break;
                case 1: LoadCustomerRevenue(); break;
                case 2: LoadProductRevenue(); break;
            }
        }

        private void LoadInitialData()
        {
            switch (tabControlMain.SelectedIndex)
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

            _currentGeneralList = _accountantService.GetRevenueReport(fromDate, toDate, keyword) ?? new List<RevenueReportDTO>();

            if (dgvGeneralRevenue != null)
            {
                dgvGeneralRevenue.DataSource = _currentGeneralList;
                if (dgvGeneralRevenue.Columns["InvoiceId"] != null) dgvGeneralRevenue.Columns["InvoiceId"].HeaderText = "Mã HĐ";
                if (dgvGeneralRevenue.Columns["OrderId"] != null) dgvGeneralRevenue.Columns["OrderId"].HeaderText = "Mã Đơn";
                if (dgvGeneralRevenue.Columns["CustomerName"] != null) dgvGeneralRevenue.Columns["CustomerName"].HeaderText = "Khách Hàng";
                if (dgvGeneralRevenue.Columns["PaidDate"] != null) dgvGeneralRevenue.Columns["PaidDate"].HeaderText = "Ngày Giao/Thanh Toán";
                if (dgvGeneralRevenue.Columns["TotalAmount"] != null)
                {
                    dgvGeneralRevenue.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
                    dgvGeneralRevenue.Columns["TotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (dgvGeneralRevenue.Columns["Status"] != null) dgvGeneralRevenue.Columns["Status"].HeaderText = "Trạng Thái";
            }

            decimal totalRev = _currentGeneralList.Sum(x => x.TotalAmount);
            int totalCount = _currentGeneralList.Count;
            decimal avgRev = totalCount > 0 ? totalRev / totalCount : 0;

            if (lblCardTotalVal != null) lblCardTotalVal.Text = totalRev.ToString("N0") + " VNĐ";
            if (lblCardCountVal != null) lblCardCountVal.Text = totalCount + " Hóa đơn";
            if (lblCardAvgVal != null) lblCardAvgVal.Text = avgRev.ToString("N0") + " VNĐ";
        }

        private void LoadCustomerRevenue()
        {
            string keyword = txtSearchCust?.Text.Trim() ?? "";
            _currentCustList = _accountantService.GetRevenueByCustomer(null, null, keyword) ?? new List<CustomerRevenueDTO>();

            if (dgvCustomerRevenue != null)
            {
                dgvCustomerRevenue.DataSource = _currentCustList;
                if (dgvCustomerRevenue.Columns["CustomerId"] != null) dgvCustomerRevenue.Columns["CustomerId"].HeaderText = "Mã KH";
                if (dgvCustomerRevenue.Columns["CustomerName"] != null) dgvCustomerRevenue.Columns["CustomerName"].HeaderText = "Tên Khách Hàng";
                if (dgvCustomerRevenue.Columns["TaxCode"] != null) dgvCustomerRevenue.Columns["TaxCode"].HeaderText = "Mã Số Thuế";
                if (dgvCustomerRevenue.Columns["City"] != null) dgvCustomerRevenue.Columns["City"].HeaderText = "Thành Phố";
                if (dgvCustomerRevenue.Columns["OrderCount"] != null) dgvCustomerRevenue.Columns["OrderCount"].HeaderText = "Số Đơn Hàng";
                if (dgvCustomerRevenue.Columns["TotalRevenue"] != null)
                {
                    dgvCustomerRevenue.Columns["TotalRevenue"].HeaderText = "Tổng Chi Tiêu";
                    dgvCustomerRevenue.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
                }
            }
        }

        private void LoadProductRevenue()
        {
            string keyword = txtSearchProd?.Text.Trim() ?? "";
            _currentProdList = _accountantService.GetRevenueByProduct(null, null, keyword) ?? new List<ProductRevenueDTO>();

            if (dgvProductRevenue != null)
            {
                dgvProductRevenue.DataSource = _currentProdList;
                if (dgvProductRevenue.Columns["ProductId"] != null) dgvProductRevenue.Columns["ProductId"].HeaderText = "Mã SP";
                if (dgvProductRevenue.Columns["ProductName"] != null) dgvProductRevenue.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                if (dgvProductRevenue.Columns["Type"] != null) dgvProductRevenue.Columns["Type"].HeaderText = "Loại";
                if (dgvProductRevenue.Columns["TotalQuantitySold"] != null) dgvProductRevenue.Columns["TotalQuantitySold"].HeaderText = "Số Lượng Bán";
                if (dgvProductRevenue.Columns["TotalRevenue"] != null)
                {
                    dgvProductRevenue.Columns["TotalRevenue"].HeaderText = "Tổng Doanh Thu";
                    dgvProductRevenue.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
                }
            }
        }

        private void BtnExportGenExcel_Click(object sender, EventArgs e)
        {
            if (_currentGeneralList == null || _currentGeneralList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = $"BaoCao_DoanhThu_TongQuan_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Doanh Thu Tổng Quan");

                        ws.Cell(1, 1).Value = "Mã Đơn";
                        ws.Cell(1, 2).Value = "Khách Hàng";
                        ws.Cell(1, 3).Value = "Ngày Giao";
                        ws.Cell(1, 4).Value = "Tổng Tiền (VNĐ)";
                        ws.Cell(1, 5).Value = "Trạng Thái";

                        var headerRange = ws.Range(1, 1, 1, 5);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.FromHtml("#4F46E5");
                        headerRange.Style.Font.FontColor = XLColor.White;

                        int row = 2;
                        foreach (var item in _currentGeneralList)
                        {
                            ws.Cell(row, 1).Value = item.OrderId;
                            ws.Cell(row, 2).Value = item.CustomerName;
                            ws.Cell(row, 3).Value = item.PaidDate.ToString("dd/MM/yyyy HH:mm");
                            ws.Cell(row, 4).Value = item.TotalAmount;
                            ws.Cell(row, 4).Style.NumberFormat.Format = "#,##0";
                            ws.Cell(row, 5).Value = item.Status;
                            row++;
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportCustExcel_Click(object sender, EventArgs e)
        {
            if (_currentCustList == null || _currentCustList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = $"BaoCao_DoanhThu_TheoKhachHang_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Doanh Thu Khách Hàng");

                        ws.Cell(1, 1).Value = "Mã KH";
                        ws.Cell(1, 2).Value = "Tên Khách Hàng";
                        ws.Cell(1, 3).Value = "Mã Số Thuế";
                        ws.Cell(1, 4).Value = "Số Đơn Hàng";
                        ws.Cell(1, 5).Value = "Tổng Chi Tiêu (VNĐ)";

                        var headerRange = ws.Range(1, 1, 1, 5);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.FromHtml("#4F46E5");
                        headerRange.Style.Font.FontColor = XLColor.White;

                        int row = 2;
                        foreach (var item in _currentCustList)
                        {
                            ws.Cell(row, 1).Value = item.CustomerId;
                            ws.Cell(row, 2).Value = item.CustomerName;
                            ws.Cell(row, 3).Value = item.TaxCode;
                            ws.Cell(row, 4).Value = item.OrderCount;
                            ws.Cell(row, 5).Value = item.TotalRevenue;
                            ws.Cell(row, 5).Style.NumberFormat.Format = "#,##0";
                            row++;
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất báo cáo Excel theo khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExportProdExcel_Click(object sender, EventArgs e)
        {
            if (_currentProdList == null || _currentProdList.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = $"BaoCao_DoanhThu_TheoSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Doanh Thu Sản Phẩm");

                        ws.Cell(1, 1).Value = "Mã SP";
                        ws.Cell(1, 2).Value = "Tên Sản Phẩm";
                        ws.Cell(1, 3).Value = "Loại Sản Phẩm";
                        ws.Cell(1, 4).Value = "Số Lượng Bán";
                        ws.Cell(1, 5).Value = "Tổng Doanh Thu (VNĐ)";

                        var headerRange = ws.Range(1, 1, 1, 5);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.FromHtml("#4F46E5");
                        headerRange.Style.Font.FontColor = XLColor.White;

                        int row = 2;
                        foreach (var item in _currentProdList)
                        {
                            ws.Cell(row, 1).Value = item.ProductId;
                            ws.Cell(row, 2).Value = item.ProductName;
                            ws.Cell(row, 3).Value = item.Type;
                            ws.Cell(row, 4).Value = item.TotalQuantitySold;
                            ws.Cell(row, 5).Value = item.TotalRevenue;
                            ws.Cell(row, 5).Style.NumberFormat.Format = "#,##0";
                            row++;
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất báo cáo Excel theo sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
