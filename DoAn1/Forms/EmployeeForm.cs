using DoAn1.Clonee.Services;
using DoAn1.Models.Helpers;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using System.ComponentModel;

namespace DoAn1.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;
        private readonly BindingList<OrderGridView> _orderGridView;

        private Customer _currentCustomer;

        public EmployeeForm(int employeeId)
        {
            InitializeComponent();

            _customerService = new CustomerService();
            _orderService = new OrderService();
            _orderGridView = new BindingList<OrderGridView>();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _orderGridView;

            ResetGridView();

            this.WindowState = FormWindowState.Maximized;
        }

        #region --- QUẢN LÝ KHÁCH HÀNG ---

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            string identity = textIdentityNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(identity))
            {
                MessageBox.Show("Vui lòng nhập số CMND/CCCD để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessResult<Customer> result = _customerService.SearchCustomer(identity);
            MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.IsSuccess && result.Data != null)
            {
                _currentCustomer = result.Data;
                FillCustomerUI(_currentCustomer);
            }
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng tìm kiếm khách hàng trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputCustomer()) return;

            ProcessResult<Customer> result = _customerService.UpdateCustomer(_currentCustomer.CustomerId, GetCustomerFromTextBoxWithoutValidate());
            MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.IsSuccess)
            {
                _currentCustomer = result.Data;
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateInputCustomer()) return;

            Customer newCustomer = GetCustomerFromTextBoxWithoutValidate();
            ProcessResult<Customer> result = _customerService.AddCustomer(newCustomer);
            MessageBox.Show(result.Message, "Thông báo", MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (result.IsSuccess)
            {
                _currentCustomer = result.Data;
            }
        }

        private bool ValidateInputCustomer()
        {
            if (string.IsNullOrWhiteSpace(textIdentityNumber.Text)) return ShowValidationError("Vui lòng nhập số CMND/CCCD.", textIdentityNumber);
            if (string.IsNullOrWhiteSpace(textFullName.Text)) return ShowValidationError("Vui lòng nhập họ tên.", textFullName);
            if (string.IsNullOrWhiteSpace(textAddress.Text)) return ShowValidationError("Vui lòng nhập địa chỉ.", textAddress);
            if (string.IsNullOrWhiteSpace(textCity.Text)) return ShowValidationError("Vui lòng nhập thành phố.", textCity);
            if (string.IsNullOrWhiteSpace(textPhoneNumber.Text)) return ShowValidationError("Vui lòng nhập số điện thoại.", textPhoneNumber);
            if (string.IsNullOrWhiteSpace(textPostalCode.Text)) return ShowValidationError("Vui lòng nhập mã bưu chính.", textPostalCode);
            if (string.IsNullOrWhiteSpace(textTaxCode.Text)) return ShowValidationError("Vui lòng nhập mã số thuế.", textTaxCode);
            if (!decimal.TryParse(textCreditLimit.Text, out _)) return ShowValidationError("Mức tín dụng không hợp lệ.", textCreditLimit);

            return true;
        }

        private Customer GetCustomerFromTextBoxWithoutValidate()
        {
            decimal.TryParse(textCreditLimit.Text, out decimal creditLimit);
            return new Customer
            {
                IdentityNumber = textIdentityNumber.Text.Trim(),
                FullName = textFullName.Text.Trim(),
                Address = textAddress.Text.Trim(),
                City = textCity.Text.Trim(),
                PhoneNumber = textPhoneNumber.Text.Trim(),
                PostalCode = textPostalCode.Text.Trim(),
                TaxCode = textTaxCode.Text.Trim(),
                CreditLimit = creditLimit,
            };
        }

        private void FillCustomerUI(Customer customer)
        {
            textIdentityNumber.Text = customer.IdentityNumber;
            textFullName.Text = customer.FullName;
            textAddress.Text = customer.Address;
            textCity.Text = customer.City;
            textPhoneNumber.Text = customer.PhoneNumber;
            textPostalCode.Text = customer.PostalCode;
            textTaxCode.Text = customer.TaxCode;
            textCreditLimit.Text = customer.CreditLimit.ToString();
        }

        #endregion

        #region --- QUẢN LÝ ĐƠN HÀNG & SẢN PHẨM ---

        private bool ValidateInputOrder()
        {
            if (!int.TryParse(textBProductCode.Text, out _)) return ShowValidationError("Mã sản phẩm phải là một số nguyên hợp lệ.", textBProductCode);
            if (!int.TryParse(textBoxQuanity.Text, out int quantity) || quantity <= 0) return ShowValidationError("Số lượng sản phẩm không hợp lệ (phải lớn hơn 0).", textBoxQuanity);
            if (dateTimePickerDelivery.Value.Date < DateTime.Today) return ShowValidationError("Thời gian dự kiến vận chuyển không thể nằm trong quá khứ.", dateTimePickerDelivery);

            return true;
        }

        public void ResetGridView()
        {
            _orderGridView.ResetBindings();

            decimal totalMoney = _orderGridView.Sum(x => x.Quantity * x.UnitPrice);

            if (labelSumMoney != null)
            {
                labelSumMoney.Text = $"Tổng tiền: {totalMoney:N0} VNĐ";
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateInputOrder() || !ValidateInputCustomer()) return;

            int productId = int.Parse(textBProductCode.Text);
            int quantity = int.Parse(textBoxQuanity.Text);

            ProcessResult<Product> rsP = _orderService.getProduct(productId);
            if (!rsP.IsSuccess)
            {
                MessageBox.Show(rsP.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _orderGridView.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                _orderGridView.Add(new OrderGridView
                {
                    ProductId = rsP.Data.ProductId,
                    ProductName = rsP.Data.ProductName,
                    UnitPrice = rsP.Data.UnitPrice,
                    Quantity = quantity,
                });
            }

            ResetGridView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputOrder()) return;

            int productId = int.Parse(textBProductCode.Text);
            int quantity = int.Parse(textBoxQuanity.Text);

            OrderGridView item = _orderGridView.FirstOrDefault(z => z.ProductId == productId);
            if (item != null)
            {
                item.Quantity = quantity;
                ResetGridView();
                MessageBox.Show("Cập nhật số lượng sản phẩm trong giỏ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sản phẩm không có trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBProductCode.Text, out int productId))
            {
                MessageBox.Show("Mã sản phẩm cần xóa không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderGridView item = _orderGridView.FirstOrDefault(z => z.ProductId == productId);
            if (item != null)
            {
                _orderGridView.Remove(item);
                ResetGridView();
                MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sản phẩm chọn xóa không nằm trong danh sách giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputCustomer()) return;

            if (_orderGridView.Count <= 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong danh sách đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentCustomer == null)
            {
                MessageBox.Show("Vui lòng thực hiện tìm kiếm hoặc tạo thông tin khách hàng trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đơn hàng mới trong CSDL
            ProcessResult<Order> orderResult = _orderService.AddOrder(_currentCustomer.CustomerId, 0, dateTimePickerDelivery.Value);

            if (orderResult.IsSuccess && orderResult.Data != null)
            {
                int newOrderId = orderResult.Data.OrderId;

                // Thêm chi tiết đơn hàng vào CSDL
                foreach (var item in _orderGridView)
                {
                    _orderService.AddProduct(newOrderId, item.ProductId, item.Quantity);
                }

                MessageBox.Show("Thêm đơn hàng thành công vào cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dọn dẹp giỏ hàng
                _orderGridView.Clear();
                ResetGridView();
            }
            else
            {
                MessageBox.Show("Lưu đơn hàng thất bại: " + orderResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Index >= 0 &&
                dataGridView1.CurrentRow.Index < _orderGridView.Count)
            {
                var item = _orderGridView[dataGridView1.CurrentRow.Index];
                textBProductCode.Text = item.ProductId.ToString();
                textBoxQuanity.Text = item.Quantity.ToString();
            }
        }

        #endregion

        #region --- HELPER METHODS ---

        private bool ShowValidationError(string message, Control controlToFocus)
        {
            MessageBox.Show(message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            controlToFocus?.Focus();
            return false;
        }

        #endregion
    }
}