namespace DoAn1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTitle = new Label();
            labelSubtitle = new Label();
            label1 = new Label();
            textBoxAcc = new TextBox();
            label2 = new Label();
            textBoxPass = new TextBox();
            checkBoxShowPass = new CheckBox(); // <-- ĐỔI THÀNH CHECKBOX
            buttonLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(labelSubtitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxAcc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(checkBoxShowPass); // <-- ĐÃ ĐỔI
            panel1.Controls.Add(buttonLogin);
            panel1.Location = new Point(50, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 410);
            panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(24, 43, 73);
            labelTitle.Location = new Point(30, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(157, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG NHẬP";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 9F);
            labelSubtitle.ForeColor = Color.Gray;
            labelSubtitle.Location = new Point(32, 67);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(198, 15);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Vui lòng nhập thông tin tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(30, 115);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // textBoxAcc
            // 
            textBoxAcc.Font = new Font("Segoe UI", 10.5F);
            textBoxAcc.Location = new Point(30, 138);
            textBoxAcc.Name = "textBoxAcc";
            textBoxAcc.Size = new Size(300, 26);
            textBoxAcc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(50, 50, 50);
            label2.Location = new Point(30, 185);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Segoe UI", 10.5F);
            textBoxPass.Location = new Point(30, 208);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(300, 26); // <-- Trả lại chiều rộng 300
            textBoxPass.TabIndex = 5;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Font = new Font("Segoe UI", 9F);
            checkBoxShowPass.ForeColor = Color.FromArgb(80, 80, 80);
            checkBoxShowPass.Location = new Point(30, 242); // <-- Đặt nằm ngay bên dưới ô mật khẩu
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(121, 19);
            checkBoxShowPass.TabIndex = 6;
            checkBoxShowPass.Text = "Hiển thị mật khẩu";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged; // <-- Sự kiện tích chọn
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(13, 110, 253);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(30, 280);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(300, 42);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "ĐĂNG NHẬP";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(460, 490);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Đăng Nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Label labelSubtitle;
        private Label label1;
        private TextBox textBoxAcc;
        private Label label2;
        private TextBox textBoxPass;
        private CheckBox checkBoxShowPass; // <-- ĐÃ ĐỔI THÀNH CHECKBOX
        private Button buttonLogin;
    }
}