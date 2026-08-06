using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAn1.Clonee.Services;
using DoAn1.Models.Helpers;
using DoAn1.Models.Tables;

namespace DoAn1.Views
{
    public partial class OrderCreationControl : UserControl
    {
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;
        private readonly BindingList<OrderGridView> _cartList;

        private Customer _currentCustomer;

        public OrderCreationControl()
        {
            _customerService = new CustomerService();
            _orderService = new OrderService();
            _cartList = new BindingList<OrderGridView>();

            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "Mã SP",
                Width = 80
            });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên Sản Phẩm"
            });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Đơn Giá",
                DefaultCellStyle = { Format = "N0" }
            });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Số Lượng",
                Width = 90
            });

            dgvCart.DataSource = _cartList;
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            string identity = txtIdentity.Text.Trim();
            if (string.IsNullOrWhiteSpace(identity))
            {
                MessageBox.Show("Vui lòng nhập số CMND/CCCD!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = _customerService.SearchCustomer(identity);
            if (res.IsSuccess && res.Data != null)
            {
                _currentCustomer = res.Data;
                lblCustInfo.Text = $"• Tên KH: {_currentCustomer.FullName}\n" +
                                   $"• SĐT: {_currentCustomer.PhoneNumber}\n" +
                                   $"• Địa chỉ: {_currentCustomer.Address}, {_currentCustomer.City}\n" +
                                   $"• Mức tín dụng: {_currentCustomer.CreditLimit:N0} đ";
                lblCustInfo.ForeColor = Color.FromArgb(15, 23, 42);
            }
            else
            {
                _currentCustomer = null;
                lblCustInfo.Text = res.Message;
                lblCustInfo.ForeColor = Color.Red;
            }
        }

        private void UpdateTotalSum()
        {
            decimal totalMoney = _cartList.Sum(x => x.Quantity * x.UnitPrice);
            lblTotalMoney.Text = $"Tổng tiền: {totalMoney:N0} VNĐ";
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng tìm kiếm chọn khách hàng trước khi thêm sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductId.Text, out int productId) || !int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Mã sản phẩm hoặc số lượng nhập vào không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pRes = _orderService.getProduct(productId);
            if (!pRes.IsSuccess || pRes.Data == null)
            {
                MessageBox.Show(pRes.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingItem = _cartList.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += qty;
                _cartList.ResetBindings();
            }
            else
            {
                _cartList.Add(new OrderGridView
                {
                    ProductId = pRes.Data.ProductId,
                    ProductName = pRes.Data.ProductName,
                    UnitPrice = pRes.Data.UnitPrice,
                    Quantity = qty
                });
            }

            UpdateTotalSum();
        }

        private void BtnUpdateCart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int productId) || !int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Mã sản phẩm hoặc số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _cartList.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                item.Quantity = qty;
                _cartList.ResetBindings();
                UpdateTotalSum();
            }
            else
            {
                MessageBox.Show("Sản phẩm không có trong giỏ hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteCartItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int productId))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _cartList.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                _cartList.Remove(item);
                UpdateTotalSum();
            }
        }

        private void DgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null && dgvCart.CurrentRow.DataBoundItem is OrderGridView item)
            {
                txtProductId.Text = item.ProductId.ToString();
                txtQty.Text = item.Quantity.ToString();
            }
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_cartList.Count <= 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = _orderService.AddOrder(_currentCustomer.CustomerId, 0, dtpDelivery.Value);
            if (res.IsSuccess && res.Data != null)
            {
                int newOrderId = res.Data.OrderId;
                foreach (var item in _cartList)
                {
                    _orderService.AddProduct(newOrderId, item.ProductId, item.Quantity);
                }

                MessageBox.Show($"Tạo đơn hàng thành công! Mã đơn hàng: #{newOrderId}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _cartList.Clear();
                UpdateTotalSum();
            }
            else
            {
                MessageBox.Show("Lỗi tạo đơn hàng: " + res.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
