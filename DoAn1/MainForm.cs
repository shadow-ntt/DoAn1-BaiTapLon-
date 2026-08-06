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
                DashboardForm dashboard = new DashboardForm(processResult.Data);
                dashboard.FormClosed += (s, args) => Application.Exit();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(processResult.Message, "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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