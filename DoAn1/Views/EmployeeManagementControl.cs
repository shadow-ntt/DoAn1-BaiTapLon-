using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAn1.Models.Tables;
using DoAn1.Services;

namespace DoAn1.Views
{
    public partial class EmployeeManagementControl : UserControl
    {
        private readonly EmployeeService _employeeService;
        private int _selectedEmployeeId = 0;

        public EmployeeManagementControl()
        {
            _employeeService = new EmployeeService();
            InitializeComponent();
            LoadDepartments();
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

        private void LoadDepartments()
        {
            var res = _employeeService.GetDepartments();
            if (res.IsSuccess && res.Data != null && res.Data.Count > 0)
            {
                cbDepartment.DataSource = res.Data;
                cbDepartment.DisplayMember = "DepartmentName";
                cbDepartment.ValueMember = "DepartmentId";
            }
            else
            {
                cbDepartment.Items.Add(new Department { DepartmentId = "PB01", DepartmentName = "Phòng Hành Chính" });
                cbDepartment.DisplayMember = "DepartmentName";
                cbDepartment.ValueMember = "DepartmentId";
            }
        }

        private void LoadData(string keyword = "")
        {
            var res = _employeeService.GetAllEmployees(keyword);
            if (res.IsSuccess && res.Data != null)
            {
                // EmployeeDTO has: EmployeeId, Name, Salary, Position, DepartmentId, DepartmentName, Username, Password
                dgvEmployees.DataSource = res.Data;

                if (dgvEmployees.Columns["EmployeeId"] != null) dgvEmployees.Columns["EmployeeId"].HeaderText = "Mã NV";
                if (dgvEmployees.Columns["Name"] != null) dgvEmployees.Columns["Name"].HeaderText = "Họ và Tên";
                if (dgvEmployees.Columns["Salary"] != null)
                {
                    dgvEmployees.Columns["Salary"].HeaderText = "Mức Lương";
                    dgvEmployees.Columns["Salary"].DefaultCellStyle.Format = "N0";
                }
                if (dgvEmployees.Columns["Position"] != null) dgvEmployees.Columns["Position"].HeaderText = "Chức Vụ";
                if (dgvEmployees.Columns["DepartmentName"] != null) dgvEmployees.Columns["DepartmentName"].HeaderText = "Phòng Ban";
                if (dgvEmployees.Columns["DepartmentId"] != null) dgvEmployees.Columns["DepartmentId"].Visible = false;
                if (dgvEmployees.Columns["Username"] != null) dgvEmployees.Columns["Username"].HeaderText = "Tài Khoản";
                if (dgvEmployees.Columns["Password"] != null) dgvEmployees.Columns["Password"].Visible = false;
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null && dgvEmployees.CurrentRow.DataBoundItem is EmployeeDTO emp)
            {
                _selectedEmployeeId = emp.EmployeeId;
                txtName.Text = emp.Name ?? "";
                txtSalary.Text = emp.Salary.ToString("N0");

                int posIndex = cbPosition.Items.IndexOf(emp.Position ?? "");
                cbPosition.SelectedIndex = posIndex >= 0 ? posIndex : 0;

                if (!string.IsNullOrEmpty(emp.DepartmentId) && cbDepartment.DataSource != null)
                {
                    cbDepartment.SelectedValue = emp.DepartmentId;
                }

                txtUsername.Text = emp.Username ?? "";
                txtPassword.Text = "";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            string selectedDeptId = cbDepartment.SelectedValue?.ToString() ?? "PB01";

            var newEmp = new Employee
            {
                Name = txtName.Text.Trim(),
                Salary = decimal.Parse(txtSalary.Text.Trim()),
                Position = cbPosition.SelectedItem.ToString(),
                DepartmentId = selectedDeptId
            };

            var res = _employeeService.AddEmployee(newEmp, txtUsername.Text.Trim(), txtPassword.Text.Trim());

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearForm();
                LoadData();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm(isEdit: true)) return;

            string selectedDeptId = cbDepartment.SelectedValue?.ToString() ?? "PB01";

            var updatedEmp = new Employee
            {
                Name = txtName.Text.Trim(),
                Salary = decimal.Parse(txtSalary.Text.Trim()),
                Position = cbPosition.SelectedItem.ToString(),
                DepartmentId = selectedDeptId
            };

            var res = _employeeService.UpdateEmployee(_selectedEmployeeId, updatedEmp, txtUsername.Text.Trim(), txtPassword.Text.Trim());

            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                ClearForm();
                LoadData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên [{txtName.Text}] và tài khoản liên quan?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _employeeService.DeleteEmployee(_selectedEmployeeId);
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
            _selectedEmployeeId = 0;
            txtName.Clear();
            txtSalary.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            if (cbPosition.Items.Count > 0) cbPosition.SelectedIndex = 0;
            if (cbDepartment.Items.Count > 0) cbDepartment.SelectedIndex = 0;
        }

        private bool ValidateForm(bool isEdit = false)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text.Trim(), out decimal salary) || salary < 0)
            {
                MessageBox.Show("Mức lương phải là số hợp lệ >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            if (cbPosition.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isEdit && string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống khi thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            return true;
        }
    }
}
