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
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            // Khóa ô nhập Mã sản phẩm lại vì DB tự tăng, không cho user nhập/sửa bậy
            txtProductId.ReadOnly = true;
            //txtProductId.BackColor = System.Drawing.Color.FromArgb(230, 235, 235); // Đổi sang màu xám nhạt cho ra dáng ReadOnly

            LoadProductData();
        }

        // Hàm tải dữ liệu lên GridView
        private void LoadProductData(string searchKeyword = "")
        {
            var result = _productService.GetAllProducts(searchKeyword);
            if (result.IsSuccess)
            {
                dgvProducts.DataSource = result.Data;
                // --- THÊM DÒNG NÀY ĐỂ ĐUỔI CÁI CỘT THỪA ĐI ---
                if (dgvProducts.Columns["OrderDetails"] != null) dgvProducts.Columns["OrderDetails"].Visible = false;

                // Format tiêu đề hiển thị tiếng Việt (nếu cần)
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
        }

        // Nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e) => LoadProductData(txtSearch.Text.Trim());

        // Nút Nhập hàng (+)
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

            if (result.IsSuccess) { ClearForm(); LoadProductData(); }
        }

        // Nút Sửa hàng
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Hãy click chọn 1 dòng dưới bảng để sửa nhé!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (result.IsSuccess) { ClearForm(); LoadProductData(); }
        }

        // Nút Xóa hàng (Có thông báo xác nhận và check ràng buộc an toàn)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa bằng cách click vào dòng trên bảng!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = int.Parse(txtProductId.Text);
            var confirmResult = MessageBox.Show($"Mày có chắc chắn muốn xóa sản phẩm có Mã là [{productId}] không?",
                                                "Xác nhận xóa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var result = _productService.DeleteProduct(productId);

                MessageBox.Show(result.Message, result.IsSuccess ? "Thành công" : "Bị chặn lại",
                                MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (result.IsSuccess) { ClearForm(); LoadProductData(); }
            }
        }


        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtDescription.Clear();
            txtType.Clear();
            txtUnitPrice.Clear();
            txtOpeningQuantity.Clear();
            dgvProducts.ClearSelection();
            LoadProductData();
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

            DataGridViewRow row = dgvProducts.CurrentRow;

            txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
            txtType.Text = row.Cells["Type"].Value?.ToString();
            txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
            txtOpeningQuantity.Text = row.Cells["OpeningQuantity"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }
        // Click chọn dòng dưới bảng đẩy ngược dữ liệu lên form nhập
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtType.Text = row.Cells["Type"].Value?.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                txtOpeningQuantity.Text = row.Cells["OpeningQuantity"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
            }
        }
    }
}