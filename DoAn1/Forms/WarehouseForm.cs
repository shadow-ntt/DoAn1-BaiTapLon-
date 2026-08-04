using System;
using System.Windows.Forms;
using DoAn1.Models.Tables;
using DoAn1.Services;

namespace DoAn1.Forms
{
    public partial class WarehouseForm : Form
    {
        private readonly ProductService _productService = new ProductService();

        public WarehouseForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            txtProductId.ReadOnly = true;
            LoadProductData();
            LoadReturnOrders();
        }

        #region TAB 1: QUẢN LÝ TỒN KHO HÀNG HÓA

        /// <summary>
        /// 1. Tải danh sách sản phẩm
        /// </summary>
        private void LoadProductData(string searchKeyword = "")
        {
            var result = _productService.GetAllProducts(searchKeyword);
            if (result.IsSuccess)
            {
                dgvProducts.DataSource = result.Data;

                if (dgvProducts.Columns["OrderDetails"] != null)
                    dgvProducts.Columns["OrderDetails"].Visible = false;

                if (dgvProducts.Columns["ProductId"] != null) dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
                if (dgvProducts.Columns["ProductName"] != null) dgvProducts.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                if (dgvProducts.Columns["Type"] != null) dgvProducts.Columns["Type"].HeaderText = "Loại";
                if (dgvProducts.Columns["UnitPrice"] != null) dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                if (dgvProducts.Columns["OpeningQuantity"] != null) dgvProducts.Columns["OpeningQuantity"].HeaderText = "Tồn Kho";
                if (dgvProducts.Columns["Description"] != null) dgvProducts.Columns["Description"].HeaderText = "Mô Tả";
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();
        }

        /// <summary>
        /// 2. Tìm kiếm sản phẩm
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e) => LoadProductData(txtSearch.Text.Trim());

        /// <summary>
        /// 3. Thêm sản phẩm mới vào kho
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal price, out int qty)) return;

            var newProduct = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Type = txtType.Text.Trim(),
                UnitPrice = price,
                OpeningQuantity = qty
            };

            var result = _productService.AddProduct(newProduct);
            MessageBox.Show(result.Message, result.IsSuccess ? "Thành công" : "Thất bại",
                            MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.IsSuccess)
            {
                LoadProductData();
            }
        }

        /// <summary>
        /// 4. Sửa thông tin sản phẩm
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Hãy chọn 1 dòng dưới bảng để sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(out decimal price, out int qty)) return;

            int productId = int.Parse(txtProductId.Text);
            var updatedData = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Type = txtType.Text.Trim(),
                UnitPrice = price,
                OpeningQuantity = qty
            };

            var result = _productService.UpdateProduct(productId, updatedData);
            MessageBox.Show(result.Message, result.IsSuccess ? "Thành công" : "Thất bại",
                            MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.IsSuccess)
            {
                LoadProductData();
            }
        }

        /// <summary>
        /// 5. Xóa sản phẩm khỏi kho
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa bằng cách click vào dòng trên bảng!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = int.Parse(txtProductId.Text);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm có Mã là [{productId}] không?",
                                                "Xác nhận xóa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var result = _productService.DeleteProduct(productId);

                MessageBox.Show(result.Message, result.IsSuccess ? "Thành công" : "Bị chặn lại",
                                MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.IsSuccess)
                {
                    LoadProductData();
                }
            }
        }

        /// <summary>
        /// 6. Nút Làm mới (Tab 1)
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadProductData();
            MessageBox.Show("Đã làm mới dữ liệu và xóa trắng thông tin nhập kho!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            dgvProducts.ClearSelection();
            txtProductId.Clear();
            txtProductName.Clear();
            txtDescription.Clear();
            txtType.Clear();
            txtUnitPrice.Clear();
            txtOpeningQuantity.Clear();
            txtSearch.Clear();
        }

        private bool ValidateInput(out decimal price, out int qty)
        {
            price = 0; qty = 0;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được bỏ trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtUnitPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtOpeningQuantity.Text, out qty) || qty < 0)
            {
                MessageBox.Show("Số lượng tồn kho phải là số nguyên lớn hơn hoặc bằng 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            FillProductFormFromRow(dgvProducts.CurrentRow);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex] != null)
            {
                FillProductFormFromRow(dgvProducts.Rows[e.RowIndex]);
            }
        }

        private void FillProductFormFromRow(DataGridViewRow row)
        {
            txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
            txtType.Text = row.Cells["Type"].Value?.ToString();
            txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
            txtOpeningQuantity.Text = row.Cells["OpeningQuantity"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }

        #endregion

        #region TAB 2: QUẢN LÝ & DUYỆT ĐƠN TRẢ HÀNG

        /// <summary>
        /// 1. Tải danh sách đơn trả hàng
        /// </summary>
        private void LoadReturnOrders(string keyword = "")
        {
            var result = _productService.GetReturnOrders(keyword);
            if (result.IsSuccess)
            {
                dgvReturnOrders.DataSource = result.Data;

                if (dgvReturnOrders.Columns["OrderId"] != null) dgvReturnOrders.Columns["OrderId"].HeaderText = "Mã Đơn";
                if (dgvReturnOrders.Columns["InvoiceDate"] != null) dgvReturnOrders.Columns["InvoiceDate"].HeaderText = "Ngày Lập HĐ";
                if (dgvReturnOrders.Columns["CustomerName"] != null) dgvReturnOrders.Columns["CustomerName"].HeaderText = "Khách Hàng";
                if (dgvReturnOrders.Columns["OrderDate"] != null) dgvReturnOrders.Columns["OrderDate"].HeaderText = "Ngày Đặt";
                if (dgvReturnOrders.Columns["Status"] != null) dgvReturnOrders.Columns["Status"].HeaderText = "Trạng Thái";
                if (dgvReturnOrders.Columns["ReturnReason"] != null) dgvReturnOrders.Columns["ReturnReason"].HeaderText = "Lý Do Trả";
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi tải đơn trả hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 2. Tìm kiếm đơn trả hàng
        /// </summary>
        private void btnSearchReturns_Click(object sender, EventArgs e)
        {
            LoadReturnOrders(txtSearchReturns.Text.Trim());
        }

        /// <summary>
        /// 3. Nút Làm mới (Tab 2)
        /// </summary>
        private void btnRefreshReturns_Click(object sender, EventArgs e)
        {
            txtSearchReturns.Clear();
            ClearReturnDetails();
            LoadReturnOrders();

            MessageBox.Show("Đã làm mới và cập nhật lại danh sách đơn trả hàng!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 4. Click/Chọn đơn hàng để xem chi tiết
        /// </summary>
        private void dgvReturnOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReturnOrders.CurrentRow != null)
            {
                DisplayReturnOrderDetails(dgvReturnOrders.CurrentRow);
            }
        }

        private void dgvReturnOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReturnOrders.Rows[e.RowIndex] != null)
            {
                DisplayReturnOrderDetails(dgvReturnOrders.Rows[e.RowIndex]);
            }
        }

        private void DisplayReturnOrderDetails(DataGridViewRow row)
        {
            if (row.Cells["OrderId"].Value == null) return;

            int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);

            txtReturnOrderId.Text = orderId.ToString();

            // Hiển thị và định dạng Ngày lập hóa đơn
            if (row.Cells["InvoiceDate"].Value != null && DateTime.TryParse(row.Cells["InvoiceDate"].Value.ToString(), out DateTime invDate))
            {
                txtReturnInvoiceDate.Text = invDate.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                txtReturnInvoiceDate.Text = "Chưa lập HĐ";
            }

            txtReturnCustomer.Text = row.Cells["CustomerName"].Value?.ToString();
            txtReturnReasonDetail.Text = row.Cells["ReturnReason"].Value?.ToString();

            var detailsResult = _productService.GetReturnOrderDetails(orderId);
            if (detailsResult.IsSuccess)
            {
                dgvReturnOrderDetails.DataSource = detailsResult.Data;

                if (dgvReturnOrderDetails.Columns["ProductId"] != null) dgvReturnOrderDetails.Columns["ProductId"].HeaderText = "Mã SP";
                if (dgvReturnOrderDetails.Columns["ProductName"] != null) dgvReturnOrderDetails.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";
                if (dgvReturnOrderDetails.Columns["Quantity"] != null) dgvReturnOrderDetails.Columns["Quantity"].HeaderText = "SL Trả";
                if (dgvReturnOrderDetails.Columns["UnitPrice"] != null) dgvReturnOrderDetails.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                if (dgvReturnOrderDetails.Columns["TotalPrice"] != null) dgvReturnOrderDetails.Columns["TotalPrice"].HeaderText = "Thành Tiền";
            }
        }

        /// <summary>
        /// 5. Duyệt đơn trả hàng và tự động cộng kho
        /// </summary>
        private void btnApproveReturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnOrderId.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 đơn hàng cần duyệt từ danh sách bên trái!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = int.Parse(txtReturnOrderId.Text);
            var confirm = MessageBox.Show($"Xác nhận duyệt trả hàng cho Đơn #{orderId} và cộng trả lại số lượng vào kho?",
                                          "Xác nhận duyệt trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var result = _productService.ApproveReturnOrder(orderId);

                MessageBox.Show(result.Message, result.IsSuccess ? "Thành công" : "Lỗi",
                                MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (result.IsSuccess)
                {
                    ClearReturnDetails();
                    LoadReturnOrders();
                    LoadProductData(); // Tự động cập nhật lại tồn kho Tab 1
                }
            }
        }

        private void ClearReturnDetails()
        {
            txtReturnOrderId.Clear();
            txtReturnInvoiceDate.Clear();
            txtReturnCustomer.Clear();
            txtReturnReasonDetail.Clear();
            dgvReturnOrderDetails.DataSource = null;
        }

        // Đã giữ lại hàm này để trùng khớp với Designer
        private void txtReturnCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}