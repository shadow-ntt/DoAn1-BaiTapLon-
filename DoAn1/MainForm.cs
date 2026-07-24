using DoAn1.Clonee.Services;
using DoAn1.Forms;
using DoAn1.Models;
using DoAn1.Models.Results;

namespace DoAn1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                // Log initialization exception to help find origin during debug
                System.IO.File.WriteAllText("init-exception.txt", ex.ToString());
                throw;
            }

            //init event
            this.textBoxPass.KeyDown += textBoxPass_KeyDown;
        }

        // Sự kiện khi tích chọn hoặc bỏ tích CheckBox
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = !checkBoxShowPass.Checked;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            ProcessResult<Account> processResult = accountService.Login(this.textBoxAcc.Text, this.textBoxPass.Text);

            if (processResult.IsSuccess)
            {
                Form? subForm = null;

                switch (processResult.Data.Employee.Position)
                {
                    case "GiaoDichVien":
                        subForm = new EmployeeForm(processResult.Data.EmployeeId);
                        break;
                    case "KiemSoatVien":
                        subForm = new SupervisorForm(processResult.Data.EmployeeId);
                        break;
                    case "KeToan":
                        subForm = new AccountantForm();
                        break;
                    case "GiaoHangVien":
                        subForm = new DeliveryForm(processResult.Data.EmployeeId);
                        break;
                    case "KiemKho":
                        subForm = new WarehouseForm();
                        break;
                }

                if (subForm != null)
                {
                    // Bắt sự kiện đóng Form phụ -> Thoát toàn bộ ứng dụng
                    subForm.FormClosed += (s, args) => Application.Exit();
                    subForm.Show();
                    this.Hide();
                }
            }

            MessageBox.Show(processResult.Message);
        }
        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Chặn tiếng "beep" mặc định của Windows khi nhấn Enter trong TextBox
                e.SuppressKeyPress = true;

                // Gọi trực tiếp sự kiện click của nút đăng nhập
                buttonLogin_Click(sender, e);
            }
        }
    }
}