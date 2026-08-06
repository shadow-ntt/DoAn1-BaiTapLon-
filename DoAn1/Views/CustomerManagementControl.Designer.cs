namespace DoAn1.Views
{
    partial class CustomerManagementControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            panelTopActions = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvCustomers = new DataGridView();
            panelInput = new Panel();
            lblIdentity = new Label();
            txtIdentity = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblTaxCode = new Label();
            txtTaxCode = new TextBox();
            lblCreditLimit = new Label();
            txtCreditLimit = new TextBox();
            lblKsv = new Label();
            cbKsv = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelHeader.SuspendLayout();
            panelTopActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(79, 70, 229);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1086, 67);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(17, 0, 0, 0);
            lblHeader.Size = new Size(1086, 67);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ KHÁCH HÀNG";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTopActions
            // 
            panelTopActions.BackColor = Color.FromArgb(241, 245, 249);
            panelTopActions.Controls.Add(txtSearch);
            panelTopActions.Controls.Add(btnSearch);
            panelTopActions.Controls.Add(btnRefresh);
            panelTopActions.Dock = DockStyle.Top;
            panelTopActions.Location = new Point(0, 67);
            panelTopActions.Margin = new Padding(3, 4, 3, 4);
            panelTopActions.Name = "panelTopActions";
            panelTopActions.Size = new Size(1086, 67);
            panelTopActions.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(17, 13);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo CCCD, tên, SĐT...";
            txtSearch.Size = new Size(297, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(79, 70, 229);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(326, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(100, 116, 139);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(440, 12);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 134);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(800, 666);
            dgvCustomers.TabIndex = 3;
           // dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            dgvCustomers.SelectionChanged += DgvCustomers_SelectionChanged;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(lblIdentity);
            panelInput.Controls.Add(txtIdentity);
            panelInput.Controls.Add(lblFullName);
            panelInput.Controls.Add(txtFullName);
            panelInput.Controls.Add(lblAddress);
            panelInput.Controls.Add(txtAddress);
            panelInput.Controls.Add(lblCity);
            panelInput.Controls.Add(txtCity);
            panelInput.Controls.Add(lblPostalCode);
            panelInput.Controls.Add(txtPostalCode);
            panelInput.Controls.Add(lblPhone);
            panelInput.Controls.Add(txtPhone);
            panelInput.Controls.Add(lblTaxCode);
            panelInput.Controls.Add(txtTaxCode);
            panelInput.Controls.Add(lblCreditLimit);
            panelInput.Controls.Add(txtCreditLimit);
            panelInput.Controls.Add(lblKsv);
            panelInput.Controls.Add(cbKsv);
            panelInput.Controls.Add(btnAdd);
            panelInput.Controls.Add(btnEdit);
            panelInput.Controls.Add(btnDelete);
            panelInput.Controls.Add(btnClear);
            panelInput.Dock = DockStyle.Right;
            panelInput.Location = new Point(800, 134);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Padding = new Padding(11, 13, 11, 13);
            panelInput.Size = new Size(286, 666);
            panelInput.TabIndex = 2;
            // 
            // lblIdentity
            // 
            lblIdentity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdentity.Location = new Point(11, 13);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(97, 33);
            lblIdentity.TabIndex = 0;
            lblIdentity.Text = "CMND/CCCD:";
            // 
            // txtIdentity
            // 
            txtIdentity.Font = new Font("Segoe UI", 9F);
            txtIdentity.Location = new Point(109, 11);
            txtIdentity.Margin = new Padding(3, 4, 3, 4);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(159, 27);
            txtIdentity.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullName.Location = new Point(11, 56);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(97, 33);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F);
            txtFullName.Location = new Point(109, 53);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(159, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.Location = new Point(11, 99);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(97, 33);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(109, 96);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(159, 27);
            txtAddress.TabIndex = 5;
            // 
            // lblCity
            // 
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCity.Location = new Point(11, 141);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(97, 33);
            lblCity.TabIndex = 6;
            lblCity.Text = "Thành phố:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 9F);
            txtCity.Location = new Point(109, 139);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(159, 27);
            txtCity.TabIndex = 7;
            // 
            // lblPostalCode
            // 
            lblPostalCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPostalCode.Location = new Point(11, 184);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(97, 33);
            lblPostalCode.TabIndex = 8;
            lblPostalCode.Text = "Mã bưu chính:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 9F);
            txtPostalCode.Location = new Point(109, 181);
            txtPostalCode.Margin = new Padding(3, 4, 3, 4);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(159, 27);
            txtPostalCode.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.Location = new Point(11, 227);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 33);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(109, 224);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(159, 27);
            txtPhone.TabIndex = 11;
            // 
            // lblTaxCode
            // 
            lblTaxCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTaxCode.Location = new Point(11, 269);
            lblTaxCode.Name = "lblTaxCode";
            lblTaxCode.Size = new Size(97, 33);
            lblTaxCode.TabIndex = 12;
            lblTaxCode.Text = "Mã số thuế:";
            // 
            // txtTaxCode
            // 
            txtTaxCode.Font = new Font("Segoe UI", 9F);
            txtTaxCode.Location = new Point(109, 267);
            txtTaxCode.Margin = new Padding(3, 4, 3, 4);
            txtTaxCode.Name = "txtTaxCode";
            txtTaxCode.Size = new Size(159, 27);
            txtTaxCode.TabIndex = 13;
            // 
            // lblCreditLimit
            // 
            lblCreditLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCreditLimit.Location = new Point(11, 312);
            lblCreditLimit.Name = "lblCreditLimit";
            lblCreditLimit.Size = new Size(97, 33);
            lblCreditLimit.TabIndex = 14;
            lblCreditLimit.Text = "Hạn mức TĐ:";
            // 
            // txtCreditLimit
            // 
            txtCreditLimit.Font = new Font("Segoe UI", 9F);
            txtCreditLimit.Location = new Point(109, 309);
            txtCreditLimit.Margin = new Padding(3, 4, 3, 4);
            txtCreditLimit.Name = "txtCreditLimit";
            txtCreditLimit.Size = new Size(159, 27);
            txtCreditLimit.TabIndex = 15;
            // 
            // lblKsv
            // 
            lblKsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKsv.Location = new Point(11, 355);
            lblKsv.Name = "lblKsv";
            lblKsv.Size = new Size(97, 33);
            lblKsv.TabIndex = 16;
            lblKsv.Text = "KSV Phụ trách:";
            // 
            // cbKsv
            // 
            cbKsv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKsv.Font = new Font("Segoe UI", 9F);
            cbKsv.FormattingEnabled = true;
            cbKsv.Location = new Point(109, 352);
            cbKsv.Margin = new Padding(3, 4, 3, 4);
            cbKsv.Name = "cbKsv";
            cbKsv.Size = new Size(159, 28);
            cbKsv.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(16, 185, 129);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(11, 408);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 40);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(245, 158, 11);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(143, 408);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 40);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(11, 455);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 40);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(143, 455);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 40);
            btnClear.TabIndex = 21;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // CustomerManagementControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCustomers);
            Controls.Add(panelInput);
            Controls.Add(panelTopActions);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerManagementControl";
            Size = new Size(1086, 800);
            panelHeader.ResumeLayout(false);
            panelTopActions.ResumeLayout(false);
            panelTopActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelTopActions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label lblKsv;
        private System.Windows.Forms.ComboBox cbKsv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}
