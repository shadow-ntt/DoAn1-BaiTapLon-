using DoAn1.Clonee.Services;
using DoAn1.Models;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Models.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn1.Forms
{
    public partial class EmployeeForm : Form
    {
        private CustomerService customerService;
        private OrderService orderService;
        private Customer currentCustomer;
        private List<OrderGridView> orderGridView;
        public int OrderId;
        public int EmployeeId;

        public EmployeeForm(int EmployeeId)
        {
            InitializeComponent();
            customerService = new CustomerService();
            orderService = new OrderService();
            orderGridView = new List<OrderGridView>();
            OrderId = -1;
            this.EmployeeId = EmployeeId;

            // Hiển thị trạng thái giỏ hàng & tổng tiền ban đầu (0 VNĐ)
            resetGridView();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        #region --- QUẢN LÝ KHÁCH HÀNG ---

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textIdentityNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số CMND/CCCD để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessResult<Customer> processResult = customerService.SearchCustomer(this.textIdentityNumber.Text);
            MessageBox.Show(processResult.Message, "Thông báo", MessageBoxButtons.OK, processResult.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (processResult.IsSuccess)
            {
                currentCustomer = processResult.Data;
                textIdentityNumber.Text = currentCustomer.IdentityNumber;
                textFullName.Text = currentCustomer.FullName;
                textAddress.Text = currentCustomer.Address;
                textCity.Text = currentCustomer.City;
                textPhoneNumber.Text = currentCustomer.PhoneNumber;
                textPostalCode.Text = currentCustomer.PostalCode;
                textTaxCode.Text = currentCustomer.TaxCode;
                textCreditLimit.Text = currentCustomer.CreditLimit.ToString();
            }
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Vui lòng tìm kiếm khách hàng trước khi cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!validateInputCustomer()) return;

            ProcessResult<Customer> processResult = customerService.UpdateCustomer(currentCustomer.CustomerId, GetCustomerFromTextBoxWithoutValidate());
            MessageBox.Show(processResult.Message, "Thông báo", MessageBoxButtons.OK, processResult.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (processResult.IsSuccess)
            {
                currentCustomer = processResult.Data;
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (!validateInputCustomer()) return;

            Customer newCustomer = GetCustomerFromTextBoxWithoutValidate();
            ProcessResult<Customer> processResult = customerService.AddCustomer(newCustomer);
            MessageBox.Show(processResult.Message, "Thông báo", MessageBoxButtons.OK, processResult.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (processResult.IsSuccess)
            {
                currentCustomer = processResult.Data;
            }
        }

        private bool validateInputCustomer()
        {
            if (string.IsNullOrWhiteSpace(textIdentityNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số CMND/CCCD.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textIdentityNumber.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textCity.Text))
            {
                MessageBox.Show("Vui lòng nhập thành phố.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCity.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPhoneNumber.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textPostalCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bưu chính.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPostalCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textTaxCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số thuế.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textTaxCode.Focus();
                return false;
            }
            if (!decimal.TryParse(textCreditLimit.Text, out _))
            {
                MessageBox.Show("Mức tín dụng không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCreditLimit.Focus();
                return false;
            }
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

        #endregion

        #region --- QUẢN LÝ ĐƠN HÀNG & SẢN PHẨM ---

        private bool validateInputOrder()
        {
            if (!int.TryParse(textBProductCode.Text, out _))
            {
                MessageBox.Show("Mã sản phẩm phải là một số nguyên hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBProductCode.Focus();
                return false;
            }
            if (!int.TryParse(textBoxQuanity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ (phải lớn hơn 0).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuanity.Focus();
                return false;
            }
            if (dateTimePickerDelivery.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Thời gian dự kiến vận chuyển không thể nằm trong quá khứ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerDelivery.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cập nhật lại hiển thị DataGridView và tự động tính Tổng tiền Real-Time
        /// </summary>
        public void resetGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orderGridView;

            // 1. Tự động tính tổng tiền từ tất cả sản phẩm có trong giỏ hàng
            decimal totalMoney = orderGridView != null ? orderGridView.Sum(x => x.Quantity * x.UnitPrice) : 0;

            // 2. Hiển thị lên Label với định dạng phân cách hàng nghìn (VD: 1,500,000 VNĐ)
            if (labelSumMoney != null)
            {
                labelSumMoney.Text = $"Tổng tiền: {totalMoney:N0} VNĐ";
                labelSumMoney.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                labelSumMoney.ForeColor = Color.FromArgb(192, 57, 43); // Màu đỏ/cam nổi bật
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (!validateInputOrder()) return;
            if (!validateInputCustomer()) return;

            int productId = int.Parse(this.textBProductCode.Text);
            int quantity = int.Parse(this.textBoxQuanity.Text);

            ProcessResult<Product> rsP = orderService.getProduct(productId);
            if (!rsP.IsSuccess)
            {
                MessageBox.Show(rsP.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = orderGridView.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                orderGridView.Add(new OrderGridView
                {
                    ProductId = rsP.Data.ProductId,
                    ProductName = rsP.Data.ProductName,
                    UnitPrice = rsP.Data.UnitPrice,
                    Quantity = quantity,
                });
            }

            // Gọi hàm resetGridView để cập nhật cả DataGridView lẫn Tổng tiền
            resetGridView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validateInputOrder()) return;

            int productId = int.Parse(this.textBProductCode.Text);
            int quantity = int.Parse(this.textBoxQuanity.Text);

            OrderGridView og = orderGridView.FirstOrDefault(z => z.ProductId == productId);
            if (og != null)
            {
                if (OrderId >= 0)
                {
                    ProcessResult<OrderGridView> rs = orderService.UpdateOrder(OrderId, productId, quantity);
                    if (!rs.IsSuccess)
                    {
                        MessageBox.Show(rs.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                og.Quantity = quantity;

                // Tính lại tổng tiền sau khi cập nhật số lượng
                resetGridView();
                MessageBox.Show("Cập nhật số lượng sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sản phẩm không có sẵn trong danh sách giỏ hàng hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBProductCode.Text) || !int.TryParse(textBProductCode.Text, out int productId))
            {
                MessageBox.Show("Mã sản phẩm cần xóa không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderGridView og = orderGridView.FirstOrDefault(z => z.ProductId == productId);
            if (og != null)
            {
                orderGridView.Remove(og);
                if (OrderId >= 0)
                {
                    ProcessResult<OrderGridView> rs = orderService.DeleteProduct(OrderId, productId);
                    if (!rs.IsSuccess)
                    {
                        MessageBox.Show(rs.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Cập nhật lại giao diện & trừ tổng tiền
                resetGridView();
                MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sản phẩm chọn xóa không nằm trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!validateInputCustomer()) return;

            if (orderGridView.Count <= 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong danh sách đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentCustomer == null)
            {
                MessageBox.Show("Vui lòng thực hiện tìm kiếm hoặc tạo thông tin khách hàng trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessResult<Order> order = orderService.AddOrder(currentCustomer.CustomerId, EmployeeId, dateTimePickerDelivery.Value);

            if (order.IsSuccess && order.Data != null)
            {
                OrderId = order.Data.OrderId;
                foreach (var item in orderGridView)
                {
                    orderService.AddProduct(order.Data.OrderId, item.ProductId, item.Quantity);
                }
                MessageBox.Show("Thêm đơn hàng thành công vào cơ sở dữ liệu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dọn dẹp giỏ hàng & reset tổng tiền về 0 VNĐ
                orderGridView.Clear();
                resetGridView();
            }
            else
            {
                MessageBox.Show("Lưu đơn hàng thất bại: " + order.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.CurrentRow != null)
            {
                textBProductCode.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                textBoxQuanity.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
            }
        }

        #endregion
    }
}