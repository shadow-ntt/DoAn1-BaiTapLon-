namespace DoAn1.Forms
{
    partial class WarehouseForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            lblSidebarTitle = new Label();
            lblId = new Label();
            txtProductId = new TextBox();
            lblName = new Label();
            txtProductName = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            lblPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQty = new Label();
            txtOpeningQuantity = new TextBox();
            lblDesc = new Label();
            txtDescription = new TextBox();
            pnlMain = new Panel();
            dgvProducts = new DataGridView();
            pnlActions = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 23, 42);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1184, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(248, 250, 252);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(20, 0, 0, 0);
            lblTitle.Size = new Size(500, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LAVITA WAREHOUSE MANAGEMENT";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 41, 59);
            pnlSidebar.Controls.Add(lblSidebarTitle);
            pnlSidebar.Controls.Add(lblId);
            pnlSidebar.Controls.Add(txtProductId);
            pnlSidebar.Controls.Add(lblName);
            pnlSidebar.Controls.Add(txtProductName);
            pnlSidebar.Controls.Add(lblType);
            pnlSidebar.Controls.Add(txtType);
            pnlSidebar.Controls.Add(lblPrice);
            pnlSidebar.Controls.Add(txtUnitPrice);
            pnlSidebar.Controls.Add(lblQty);
            pnlSidebar.Controls.Add(txtOpeningQuantity);
            pnlSidebar.Controls.Add(lblDesc);
            pnlSidebar.Controls.Add(txtDescription);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 60);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(340, 601);
            pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.FromArgb(16, 185, 129);
            lblSidebarTitle.Location = new Point(20, 15);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(300, 25);
            lblSidebarTitle.TabIndex = 0;
            lblSidebarTitle.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(148, 163, 184);
            lblId.Location = new Point(20, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(205, 23);
            lblId.TabIndex = 1;
            lblId.Text = "Mã Sản Phẩm (Tự động)";
            // 
            // txtProductId
            // 
            txtProductId.BackColor = Color.FromArgb(51, 65, 85);
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Enabled = false;
            txtProductId.Font = new Font("Segoe UI", 10F);
            txtProductId.ForeColor = Color.FromArgb(241, 245, 249);
            txtProductId.Location = new Point(20, 78);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(300, 30);
            txtProductId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(148, 163, 184);
            lblName.Location = new Point(20, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Tên Sản Phẩm *";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(51, 65, 85);
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.ForeColor = Color.White;
            txtProductName.Location = new Point(20, 138);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 30);
            txtProductName.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblType.ForeColor = Color.FromArgb(148, 163, 184);
            lblType.Location = new Point(20, 175);
            lblType.Name = "lblType";
            lblType.Size = new Size(150, 20);
            lblType.TabIndex = 5;
            lblType.Text = "Phân Loại";
            // 
            // txtType
            // 
            txtType.BackColor = Color.FromArgb(51, 65, 85);
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Segoe UI", 10F);
            txtType.ForeColor = Color.White;
            txtType.Location = new Point(20, 198);
            txtType.Name = "txtType";
            txtType.Size = new Size(300, 30);
            txtType.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(148, 163, 184);
            lblPrice.Location = new Point(20, 235);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(150, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Đơn Giá *";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.FromArgb(51, 65, 85);
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 10F);
            txtUnitPrice.ForeColor = Color.White;
            txtUnitPrice.Location = new Point(20, 258);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(300, 30);
            txtUnitPrice.TabIndex = 8;
            // 
            // lblQty
            // 
            lblQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQty.ForeColor = Color.FromArgb(148, 163, 184);
            lblQty.Location = new Point(20, 295);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(150, 20);
            lblQty.TabIndex = 9;
            lblQty.Text = "Số Lượng Tồn Kho *";
            // 
            // txtOpeningQuantity
            // 
            txtOpeningQuantity.BackColor = Color.FromArgb(51, 65, 85);
            txtOpeningQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtOpeningQuantity.Font = new Font("Segoe UI", 10F);
            txtOpeningQuantity.ForeColor = Color.White;
            txtOpeningQuantity.Location = new Point(20, 318);
            txtOpeningQuantity.Name = "txtOpeningQuantity";
            txtOpeningQuantity.Size = new Size(300, 30);
            txtOpeningQuantity.TabIndex = 10;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesc.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc.Location = new Point(20, 355);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(150, 20);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "Mô Tả Chi Tiết";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(51, 65, 85);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(20, 378);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(300, 100);
            txtDescription.TabIndex = 12;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvProducts);
            pnlMain.Controls.Add(pnlActions);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(340, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(15);
            pnlMain.Size = new Size(844, 601);
            pnlMain.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(226, 232, 240);
            dgvProducts.Location = new Point(15, 75);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(814, 511);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(248, 250, 252);
            pnlActions.Controls.Add(txtSearch);
            pnlActions.Controls.Add(btnSearch);
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnClear);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(15, 15);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(814, 60);
            pnlActions.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(0, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(71, 85, 105);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(210, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 28);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "TÌM KIẾM";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(16, 185, 129);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(400, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "NHẬP KHO (+)";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(245, 158, 11);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(505, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 28);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "CẬP NHẬT (✎)";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(610, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "XÓA HÀNG (✗)";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(715, 13);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 28);
            btnClear.TabIndex = 5;
            btnClear.Text = "LÀM MỚI (↻)";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // WarehouseForm
            // 
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1200, 700);
            Name = "WarehouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavita Warehouse Control Panel";
            Load += WarehouseForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtOpeningQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDesc;
    }
}