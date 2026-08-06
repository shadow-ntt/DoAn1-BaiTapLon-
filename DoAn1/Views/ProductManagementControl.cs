using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn1.Models.Helpers;
using DoAn1.Models.Tables;
using DoAn1.Services;

namespace DoAn1.Views
{
    public partial class ProductManagementControl : UserControl
    {
        private readonly ProductService _productService;
        private readonly string _userPosition;
        private readonly int _defaultTabIndex;
        private int _selectedProductId = 0;

        public ProductManagementControl(string position = "KiemKho", int defaultTabIndex = 0)
        {
            _productService = new ProductService();
            _userPosition = position;
            _defaultTabIndex = defaultTabIndex;

            InitializeComponent();
            ConfigureViewMode();
            ApplyRolePermissions();

            if (_defaultTabIndex == 0)
            {
                LoadProducts();
            }
            else
            {
                LoadReturnOrders();
            }
        }

        private void ConfigureViewMode()
        {
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;

            if (_defaultTabIndex == 1)
            {
                tabControlMain.SelectedTab = tabReturnOrders;
                lblHeader.Text = "DUYỆT ĐƠN TRẢ HÀNG & NHẬP KHO LẠI";
            }
            else
            {
                tabControlMain.SelectedTab = tabProducts;
                lblHeader.Text = "DANH MỤC SẢN PHẨM & QUẢN LÝ KHO";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e) => LoadProducts(txtSearch.Text);

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearProductForm();
            LoadProducts();
        }

        private void BtnClear_Click(object sender, EventArgs e) => ClearProductForm();

        private void BtnSearchReturns_Click(object sender, EventArgs e) => LoadReturnOrders(txtSearchReturns.Text);

        private void BtnRefreshReturns_Click(object sender, EventArgs e)
        {
            txtSearchReturns.Clear();
            LoadReturnOrders();
        }

        private void ApplyRolePermissions()
        {
            bool canEdit = (_userPosition == "Admin" || _userPosition == "KiemKho");
            btnAdd.Enabled = canEdit;
            btnEdit.Enabled = canEdit;
            btnDelete.Enabled = canEdit;

            if (!canEdit && _defaultTabIndex == 0)
            {
                lblHeader.Text = "DANH MỤC SẢN PHẨM (XEM & TÌM KIẾM)";
                txtProductName.ReadOnly = true;
                txtType.ReadOnly = true;
                txtUnitPrice.ReadOnly = true;
                txtOpeningQty.ReadOnly = true;
                txtDescription.ReadOnly = true;
            }
        }

        private void LoadProducts(string keyword = "")
        {
            var res = _productService.GetAllProducts(keyword);
            if (res.IsSuccess && res.Data != null)
            {
                dgvProducts.DataSource = res.Data;

                if (dgvProducts.Columns["ProductId"] != null) dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
                if (dgvProducts.Columns["ProductName"] != null) dgvProducts.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                if (dgvProducts.Columns["Type"] != null) dgvProducts.Columns["Type"].HeaderText = "Loại SP";
                if (dgvProducts.Columns["UnitPrice"] != null)
                {
                    dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                    dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                }
                if (dgvProducts.Columns["OpeningQuantity"] != null) dgvProducts.Columns["OpeningQuantity"].HeaderText = "Tồn Kho";
                if (dgvProducts.Columns["Description"] != null) dgvProducts.Columns["Description"].HeaderText = "Mô Tả";
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi tải dữ liệu sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product p)
            {
                _selectedProductId = p.ProductId;
                txtProductName.Text = p.ProductName ?? "";
                txtType.Text = p.Type ?? "";
                txtUnitPrice.Text = p.UnitPrice.ToString("N0");
                txtOpeningQty.Text = p.OpeningQuantity.ToString();
                txtDescription.Text = p.Description ?? "";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProductForm()) return;

            var newProd = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Type = txtType.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                OpeningQuantity = int.Parse(txtOpeningQty.Text.Trim()),
                Description = txtDescription.Text.Trim()
            };

            var res = _productService.AddProduct(newProd);

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearProductForm();
                LoadProducts();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedProductId <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateProductForm()) return;

            var updatedProd = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Type = txtType.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                OpeningQuantity = int.Parse(txtOpeningQty.Text.Trim()),
                Description = txtDescription.Text.Trim()
            };

            var res = _productService.UpdateProduct(_selectedProductId, updatedProd);

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearProductForm();
                LoadProducts();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{txtProductName.Text}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _productService.DeleteProduct(_selectedProductId);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess)
                {
                    ClearProductForm();
                    LoadProducts();
                }
            }
        }

        private void ClearProductForm()
        {
            _selectedProductId = 0;
            txtProductName.Clear();
            txtType.Clear();
            txtUnitPrice.Clear();
            txtOpeningQty.Clear();
            txtDescription.Clear();
        }

        private bool ValidateProductForm()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim().Replace(",", "").Replace(".", ""), out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtOpeningQty.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOpeningQty.Focus();
                return false;
            }

            return true;
        }

        private void LoadReturnOrders(string keyword = "")
        {
            var res = _productService.GetReturnOrders(keyword);
            if (res.IsSuccess && res.Data != null)
            {
                dgvReturnOrders.DataSource = res.Data;

                if (dgvReturnOrders.Columns["OrderId"] != null) dgvReturnOrders.Columns["OrderId"].HeaderText = "Mã Đơn Trả";
                if (dgvReturnOrders.Columns["CustomerName"] != null) dgvReturnOrders.Columns["CustomerName"].HeaderText = "Khách Hàng";
                if (dgvReturnOrders.Columns["ReturnReason"] != null) dgvReturnOrders.Columns["ReturnReason"].HeaderText = "Lý Do Trả";
                if (dgvReturnOrders.Columns["OrderDate"] != null) dgvReturnOrders.Columns["OrderDate"].HeaderText = "Ngày Đặt";
                if (dgvReturnOrders.Columns["InvoiceDate"] != null) dgvReturnOrders.Columns["InvoiceDate"].HeaderText = "Ngày Lập HĐ";
                if (dgvReturnOrders.Columns["Status"] != null) dgvReturnOrders.Columns["Status"].HeaderText = "Trạng Thái";
            }
        }

        private void DgvReturnOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReturnOrders.CurrentRow?.DataBoundItem is ReturnOrderDTO order)
            {
                lblReturnTitle.Text = $"Chi tiết kiện hàng bị trả về: #{order.OrderId}";
                lblReturnInfo.Text = $"• Khách hàng: {order.CustomerName}\n" +
                                     $"• Lý do trả: {order.ReturnReason}\n" +
                                     $"• Ngày đặt: {order.OrderDate:dd/MM/yyyy HH:mm}";

                var res = _productService.GetReturnOrderDetails(order.OrderId);
                if (res.IsSuccess && res.Data != null)
                {
                    dgvReturnDetails.DataSource = res.Data;
                    if (dgvReturnDetails.Columns["ProductId"] != null) dgvReturnDetails.Columns["ProductId"].HeaderText = "Mã SP";
                    if (dgvReturnDetails.Columns["ProductName"] != null) dgvReturnDetails.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                    if (dgvReturnDetails.Columns["Quantity"] != null) dgvReturnDetails.Columns["Quantity"].HeaderText = "SL Nhập Lại Kho";
                    if (dgvReturnDetails.Columns["UnitPrice"] != null) dgvReturnDetails.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                }

                btnApproveReturn.Tag = order.OrderId;
            }
        }

        private void BtnApproveReturn_Click(object sender, EventArgs e)
        {
            if (btnApproveReturn.Tag is int orderId && orderId > 0)
            {
                var confirm = MessageBox.Show($"Xác nhận KIỂM TRA ĐỦ HÀNG HÓA VÀ NHẬP TỒN KHO LẠI cho đơn hàng #{orderId}?", "Xác nhận nhập kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var res = _productService.ApproveReturnOrder(orderId);
                    MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (res.IsSuccess)
                    {
                        LoadProducts();
                        LoadReturnOrders();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần duyệt nhập kho!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
