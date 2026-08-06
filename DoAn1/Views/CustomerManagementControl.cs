using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAn1.Clonee.Services;
using DoAn1.Models.Tables;

namespace DoAn1.Views
{
    public partial class CustomerManagementControl : UserControl
    {
        private readonly CustomerService _customerService;
        private int _selectedCustomerId = 0;

        public CustomerManagementControl()
        {
            _customerService = new CustomerService();
            InitializeComponent();
            LoadSupervisors();
            LoadData();
        }

        private void BtnSearch_Click(object sender, EventArgs e) => LoadData(txtSearch.Text);

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadData();
        }

        private void BtnClear_Click(object sender, EventArgs e) => ClearForm();

        private void LoadSupervisors()
        {
            var res = _customerService.GetSupervisors();
            if (res.IsSuccess && res.Data != null && res.Data.Count > 0)
            {
                cbKsv.DisplayMember = "Name";
                cbKsv.ValueMember = "EmployeeId";
                cbKsv.DataSource = res.Data;
            }
            else
            {
                cbKsv.DisplayMember = "Name";
                cbKsv.ValueMember = "EmployeeId";
                cbKsv.DataSource = new List<Employee>
                {
                    new Employee { EmployeeId = 1, Name = "Trần Thị B (KSV)" }
                };
            }
        }

        private void LoadData(string keyword = "")
        {
            var res = _customerService.GetAllCustomers(keyword);
            if (res.IsSuccess && res.Data != null)
            {
                dgvCustomers.DataSource = res.Data;

                if (dgvCustomers.Columns["CustomerId"] != null) dgvCustomers.Columns["CustomerId"].HeaderText = "Mã KH";
                if (dgvCustomers.Columns["IdentityNumber"] != null) dgvCustomers.Columns["IdentityNumber"].HeaderText = "CMND/CCCD";
                if (dgvCustomers.Columns["FullName"] != null) dgvCustomers.Columns["FullName"].HeaderText = "Họ và Tên";
                if (dgvCustomers.Columns["Address"] != null) dgvCustomers.Columns["Address"].HeaderText = "Địa Chỉ";
                if (dgvCustomers.Columns["City"] != null) dgvCustomers.Columns["City"].HeaderText = "Thành Phố";
                if (dgvCustomers.Columns["PostalCode"] != null) dgvCustomers.Columns["PostalCode"].HeaderText = "Mã Bưu Chính";
                if (dgvCustomers.Columns["PhoneNumber"] != null) dgvCustomers.Columns["PhoneNumber"].HeaderText = "SĐT";
                if (dgvCustomers.Columns["TaxCode"] != null) dgvCustomers.Columns["TaxCode"].HeaderText = "Mã Số Thuế";
                if (dgvCustomers.Columns["CreditLimit"] != null)
                {
                    dgvCustomers.Columns["CreditLimit"].HeaderText = "Hạn Mức TĐ";
                    dgvCustomers.Columns["CreditLimit"].DefaultCellStyle.Format = "N0";
                }
                if (dgvCustomers.Columns["EmployeeId"] != null) dgvCustomers.Columns["EmployeeId"].Visible = false;
                if (dgvCustomers.Columns["Employee"] != null) dgvCustomers.Columns["Employee"].Visible = false;
                if (dgvCustomers.Columns["Orders"] != null) dgvCustomers.Columns["Orders"].Visible = false;
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null && dgvCustomers.CurrentRow.DataBoundItem is Customer c)
            {
                _selectedCustomerId = c.CustomerId;

                txtIdentity.Text = c.IdentityNumber ?? "";
                txtFullName.Text = c.FullName ?? "";
                txtAddress.Text = c.Address ?? "";
                txtCity.Text = c.City ?? "";
                txtPostalCode.Text = c.PostalCode ?? "";
                txtPhone.Text = c.PhoneNumber ?? "";
                txtTaxCode.Text = c.TaxCode ?? "";
                txtCreditLimit.Text = c.CreditLimit.ToString("0"); // Unformatted number to enable clean parsing on Edit

                if (c.EmployeeId > 0 && cbKsv.Items.Count > 0)
                {
                    cbKsv.SelectedValue = c.EmployeeId;
                    if (cbKsv.SelectedIndex < 0 || cbKsv.SelectedValue == null || (cbKsv.SelectedValue is int empId && empId != c.EmployeeId))
                    {
                        bool found = false;
                        for (int i = 0; i < cbKsv.Items.Count; i++)
                        {
                            if (cbKsv.Items[i] is Employee emp && emp.EmployeeId == c.EmployeeId)
                            {
                                cbKsv.SelectedIndex = i;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            cbKsv.SelectedIndex = -1;
                            MessageBox.Show($"Lỗi: Không tìm thấy thông tin KSV phụ trách (Mã KSV #{c.EmployeeId}) cho khách hàng [{c.FullName}] trong danh sách!", "Lỗi KSV phụ trách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (c.EmployeeId <= 0)
                {
                    cbKsv.SelectedIndex = -1;
                    MessageBox.Show($"Cảnh báo: Khách hàng [{c.FullName}] chưa được phân công KSV phụ trách!", "Cảnh báo KSV phụ trách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private int GetSelectedKsvId()
        {
            if (cbKsv.SelectedValue is int id && id > 0) return id;
            if (cbKsv.SelectedItem is Employee emp && emp.EmployeeId > 0) return emp.EmployeeId;
            return 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            int selectedKsvId = GetSelectedKsvId();

            string cleanCredit = txtCreditLimit.Text.Trim().Replace(",", "").Replace(".", "");
            decimal.TryParse(cleanCredit, out decimal creditLimit);

            var newCustomer = new Customer
            {
                IdentityNumber = txtIdentity.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                TaxCode = txtTaxCode.Text.Trim(),
                CreditLimit = creditLimit,
                EmployeeId = selectedKsvId
            };

            var res = _customerService.AddCustomer(newCustomer);

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearForm();
                LoadData();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            int selectedKsvId = GetSelectedKsvId();

            string cleanCredit = txtCreditLimit.Text.Trim().Replace(",", "").Replace(".", "");
            decimal.TryParse(cleanCredit, out decimal creditLimit);

            var updatedCustomer = new Customer
            {
                IdentityNumber = txtIdentity.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                TaxCode = txtTaxCode.Text.Trim(),
                CreditLimit = creditLimit,
                EmployeeId = selectedKsvId
            };

            var res = _customerService.UpdateCustomer(_selectedCustomerId, updatedCustomer);

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearForm();
                LoadData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng [{txtFullName.Text}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _customerService.DeleteCustomer(_selectedCustomerId);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess)
                {
                    ClearForm();
                    LoadData();
                }
            }
        }

        private void ClearForm()
        {
            _selectedCustomerId = 0;
            txtIdentity.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            txtPhone.Clear();
            txtTaxCode.Clear();
            txtCreditLimit.Clear();
            if (cbKsv.Items.Count > 0) cbKsv.SelectedIndex = -1;
            dgvCustomers.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtIdentity.Text))
            {
                MessageBox.Show("Số CMND/CCCD không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            string cleanCredit = txtCreditLimit.Text.Trim().Replace(",", "").Replace(".", "");
            if (!decimal.TryParse(cleanCredit, out decimal limit) || limit < 0)
            {
                MessageBox.Show("Hạn mức tín dụng phải là số hợp lệ >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCreditLimit.Focus();
                return false;
            }

            if (GetSelectedKsvId() <= 0)
            {
                MessageBox.Show("Vui lòng chọn KSV phụ trách hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbKsv.Focus();
                return false;
            }

            return true;
        }
    }
}
