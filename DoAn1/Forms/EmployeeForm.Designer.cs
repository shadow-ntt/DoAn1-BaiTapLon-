namespace DoAn1.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textIdentityNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textAddress = new TextBox();
            label3 = new Label();
            textPostalCode = new TextBox();
            label4 = new Label();
            textCity = new TextBox();
            label5 = new Label();
            textPhoneNumber = new TextBox();
            label6 = new Label();
            textTaxCode = new TextBox();
            label7 = new Label();
            textFullName = new TextBox();
            label8 = new Label();
            textCreditLimit = new TextBox();
            panel1 = new Panel();
            buttonAddCustomer = new Button();
            label13 = new Label();
            buttonUpdateCustomer = new Button();
            buttonSearchCustomer = new Button();
            dateTimePickerDelivery = new DateTimePicker();
            label11 = new Label();
            panel3 = new Panel();
            label17 = new Label();
            labelSumMoney = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAddProduct = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label14 = new Label();
            textBoxQuanity = new TextBox();
            label12 = new Label();
            textBProductCode = new TextBox();
            buttonSubmit = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textIdentityNumber
            // 
            textIdentityNumber.Font = new Font("Segoe UI", 9.5F);
            textIdentityNumber.Location = new Point(140, 110);
            textIdentityNumber.Name = "textIdentityNumber";
            textIdentityNumber.Size = new Size(275, 29);
            textIdentityNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(20, 115);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 13;
            label1.Text = "CMND/CCCD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(20, 165);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 15;
            label2.Text = "Địa chỉ";
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 9.5F);
            textAddress.Location = new Point(140, 160);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(275, 29);
            textAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(20, 215);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 17;
            label3.Text = "Mã bưu điện";
            // 
            // textPostalCode
            // 
            textPostalCode.Font = new Font("Segoe UI", 9.5F);
            textPostalCode.Location = new Point(140, 210);
            textPostalCode.Name = "textPostalCode";
            textPostalCode.Size = new Size(275, 29);
            textPostalCode.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(20, 265);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 19;
            label4.Text = "Thành phố";
            // 
            // textCity
            // 
            textCity.Font = new Font("Segoe UI", 9.5F);
            textCity.Location = new Point(140, 260);
            textCity.Name = "textCity";
            textCity.Size = new Size(275, 29);
            textCity.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(71, 85, 105);
            label5.Location = new Point(20, 315);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 18;
            label5.Text = "Số điện thoại";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            textPhoneNumber.Location = new Point(140, 310);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(275, 29);
            textPhoneNumber.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(71, 85, 105);
            label6.Location = new Point(20, 365);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 16;
            label6.Text = "Mã số thuế";
            // 
            // textTaxCode
            // 
            textTaxCode.Font = new Font("Segoe UI", 9.5F);
            textTaxCode.Location = new Point(140, 360);
            textTaxCode.Name = "textTaxCode";
            textTaxCode.Size = new Size(275, 29);
            textTaxCode.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(71, 85, 105);
            label7.Location = new Point(20, 65);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 14;
            label7.Text = "Họ và Tên";
            // 
            // textFullName
            // 
            textFullName.Font = new Font("Segoe UI", 9.5F);
            textFullName.Location = new Point(140, 60);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(275, 29);
            textFullName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(71, 85, 105);
            label8.Location = new Point(20, 415);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 12;
            label8.Text = "Hạn tín dụng";
            // 
            // textCreditLimit
            // 
            textCreditLimit.Font = new Font("Segoe UI", 9.5F);
            textCreditLimit.Location = new Point(140, 410);
            textCreditLimit.Name = "textCreditLimit";
            textCreditLimit.Size = new Size(275, 29);
            textCreditLimit.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonAddCustomer);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(buttonUpdateCustomer);
            panel1.Controls.Add(buttonSearchCustomer);
            panel1.Controls.Add(textCity);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textIdentityNumber);
            panel1.Controls.Add(textCreditLimit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textAddress);
            panel1.Controls.Add(textFullName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textPostalCode);
            panel1.Controls.Add(textTaxCode);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textPhoneNumber);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 620);
            panel1.TabIndex = 0;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = Color.FromArgb(37, 99, 235);
            buttonAddCustomer.FlatAppearance.BorderSize = 0;
            buttonAddCustomer.FlatStyle = FlatStyle.Flat;
            buttonAddCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddCustomer.ForeColor = Color.White;
            buttonAddCustomer.Location = new Point(155, 550);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(125, 42);
            buttonAddCustomer.TabIndex = 10;
            buttonAddCustomer.Text = "Thêm KH";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(30, 41, 59);
            label13.Location = new Point(16, 16);
            label13.Name = "label13";
            label13.Size = new Size(264, 28);
            label13.TabIndex = 0;
            label13.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.BackColor = Color.FromArgb(241, 245, 249);
            buttonUpdateCustomer.FlatAppearance.BorderSize = 0;
            buttonUpdateCustomer.FlatStyle = FlatStyle.Flat;
            buttonUpdateCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdateCustomer.ForeColor = Color.FromArgb(30, 41, 59);
            buttonUpdateCustomer.Location = new Point(290, 550);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(125, 42);
            buttonUpdateCustomer.TabIndex = 11;
            buttonUpdateCustomer.Text = " Sửa KH";
            buttonUpdateCustomer.UseVisualStyleBackColor = false;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // buttonSearchCustomer
            // 
            buttonSearchCustomer.BackColor = Color.FromArgb(241, 245, 249);
            buttonSearchCustomer.FlatAppearance.BorderSize = 0;
            buttonSearchCustomer.FlatStyle = FlatStyle.Flat;
            buttonSearchCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearchCustomer.ForeColor = Color.FromArgb(30, 41, 59);
            buttonSearchCustomer.Location = new Point(20, 550);
            buttonSearchCustomer.Name = "buttonSearchCustomer";
            buttonSearchCustomer.Size = new Size(125, 42);
            buttonSearchCustomer.TabIndex = 9;
            buttonSearchCustomer.Text = " Tìm kiếm";
            buttonSearchCustomer.UseVisualStyleBackColor = false;
            buttonSearchCustomer.Click += buttonSearchCustomer_Click;
            // 
            // dateTimePickerDelivery
            // 
            dateTimePickerDelivery.Font = new Font("Segoe UI", 9.5F);
            dateTimePickerDelivery.Format = DateTimePickerFormat.Short;
            dateTimePickerDelivery.Location = new Point(320, 85);
            dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            dateTimePickerDelivery.Size = new Size(160, 29);
            dateTimePickerDelivery.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(71, 85, 105);
            label11.Location = new Point(320, 60);
            label11.Name = "label11";
            label11.Size = new Size(142, 20);
            label11.TabIndex = 4;
            label11.Text = "Ngày Giao Dự Kiến";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label17);
            panel3.Controls.Add(dateTimePickerDelivery);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(labelSumMoney);
            panel3.Controls.Add(buttonDelete);
            panel3.Controls.Add(buttonUpdate);
            panel3.Controls.Add(buttonAddProduct);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBoxQuanity);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBProductCode);
            panel3.Location = new Point(480, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(740, 550);
            panel3.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(30, 41, 59);
            label17.Location = new Point(16, 16);
            label17.Name = "label17";
            label17.Size = new Size(210, 28);
            label17.TabIndex = 0;
            label17.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // labelSumMoney
            // 
            labelSumMoney.AutoSize = true;
            labelSumMoney.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelSumMoney.ForeColor = Color.FromArgb(220, 38, 38);
            labelSumMoney.Location = new Point(20, 490);
            labelSumMoney.Name = "labelSumMoney";
            labelSumMoney.Size = new Size(191, 30);
            labelSumMoney.TabIndex = 8;
            labelSumMoney.Text = "Tổng tiền: 0 VNĐ";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(254, 226, 226);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.FromArgb(220, 38, 38);
            buttonDelete.Location = new Point(668, 80);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(50, 36);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(241, 245, 249);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.FromArgb(30, 41, 59);
            buttonUpdate.Location = new Point(610, 80);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(50, 36);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Sửa";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = Color.FromArgb(37, 99, 235);
            buttonAddProduct.FlatAppearance.BorderSize = 0;
            buttonAddProduct.FlatStyle = FlatStyle.Flat;
            buttonAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddProduct.ForeColor = Color.White;
            buttonAddProduct.Location = new Point(500, 80);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(100, 36);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Thêm";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 8, 0, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(241, 245, 249);
            dataGridView1.Location = new Point(20, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 330);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductId";
            Column1.HeaderText = "Mã Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "Tên Hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "UnitPrice";
            Column3.HeaderText = "Đơn Giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Quantity";
            Column4.HeaderText = "Số Lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TotalPrice";
            Column5.HeaderText = "Thành Tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(71, 85, 105);
            label14.Location = new Point(180, 60);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 9;
            label14.Text = "Số Lượng";
            // 
            // textBoxQuanity
            // 
            textBoxQuanity.Font = new Font("Segoe UI", 9.5F);
            textBoxQuanity.Location = new Point(180, 85);
            textBoxQuanity.Name = "textBoxQuanity";
            textBoxQuanity.Size = new Size(120, 29);
            textBoxQuanity.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(71, 85, 105);
            label12.Location = new Point(20, 60);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 10;
            label12.Text = "Mã Hàng";
            // 
            // textBProductCode
            // 
            textBProductCode.Font = new Font("Segoe UI", 9.5F);
            textBProductCode.Location = new Point(20, 85);
            textBProductCode.Name = "textBProductCode";
            textBProductCode.Size = new Size(140, 29);
            textBProductCode.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(16, 185, 129);
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(1040, 585);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(180, 50);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = " DUYỆT ĐƠN";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1242, 660);
            Controls.Add(buttonSubmit);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống TẠO & QUẢN LÝ ĐƠN HÀNG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textIdentityNumber;
        private Label label1;
        private Label label2;
        private TextBox textAddress;
        private Label label3;
        private TextBox textPostalCode;
        private Label label4;
        private TextBox textCity;
        private Label label5;
        private TextBox textPhoneNumber;
        private Label label6;
        private TextBox textTaxCode;
        private Label label7;
        private TextBox textFullName;
        private Label label8;
        private TextBox textCreditLimit;
        private Panel panel1;
        private Label label11;
        private DateTimePicker dateTimePickerDelivery;
        private Panel panel3;
        private Label label14;
        private TextBox textBoxQuanity;
        private Label label12;
        private TextBox textBProductCode;
        private DataGridView dataGridView1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAddProduct;
        private Button buttonUpdateCustomer;
        private Button buttonSearchCustomer;
        private Label labelSumMoney;
        private Label label13;
        private Label label17;
        private Button buttonSubmit;
        private Button buttonAddCustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}