namespace DoAn1.Views
{
    partial class ProductManagementControl
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.panelTopActions = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblOpeningQty = new System.Windows.Forms.Label();
            this.txtOpeningQty = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabReturnOrders = new System.Windows.Forms.TabPage();
            this.panelReturnsTop = new System.Windows.Forms.Panel();
            this.txtSearchReturns = new System.Windows.Forms.TextBox();
            this.btnSearchReturns = new System.Windows.Forms.Button();
            this.btnRefreshReturns = new System.Windows.Forms.Button();
            this.splitContainerReturns = new System.Windows.Forms.SplitContainer();
            this.dgvReturnOrders = new System.Windows.Forms.DataGridView();
            this.panelReturnDetail = new System.Windows.Forms.Panel();
            this.lblReturnTitle = new System.Windows.Forms.Label();
            this.lblReturnInfo = new System.Windows.Forms.Label();
            this.dgvReturnDetails = new System.Windows.Forms.DataGridView();
            this.btnApproveReturn = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.panelTopActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelInput.SuspendLayout();
            this.tabReturnOrders.SuspendLayout();
            this.panelReturnsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReturns)).BeginInit();
            this.splitContainerReturns.Panel1.SuspendLayout();
            this.splitContainerReturns.Panel2.SuspendLayout();
            this.splitContainerReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOrders)).BeginInit();
            this.panelReturnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 45);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(950, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DANH MỤC SẢN PHẨM & QUẢN LÝ KHO";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabProducts);
            this.tabControlMain.Controls.Add(this.tabReturnOrders);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControlMain.Location = new System.Drawing.Point(0, 45);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(950, 555);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dgvProducts);
            this.tabProducts.Controls.Add(this.panelInput);
            this.tabProducts.Controls.Add(this.panelTopActions);
            this.tabProducts.Location = new System.Drawing.Point(4, 26);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(5);
            this.tabProducts.Size = new System.Drawing.Size(942, 525);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Danh Sách Sản Phẩm";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // panelTopActions
            // 
            this.panelTopActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelTopActions.Controls.Add(this.txtSearch);
            this.panelTopActions.Controls.Add(this.btnSearch);
            this.panelTopActions.Controls.Add(this.btnRefresh);
            this.panelTopActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopActions.Location = new System.Drawing.Point(5, 5);
            this.panelTopActions.Name = "panelTopActions";
            this.panelTopActions.Size = new System.Drawing.Size(932, 45);
            this.panelTopActions.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(10, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm tên sản phẩm, loại...";
            this.txtSearch.Size = new System.Drawing.Size(250, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(270, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(365, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.lblProductName);
            this.panelInput.Controls.Add(this.txtProductName);
            this.panelInput.Controls.Add(this.lblType);
            this.panelInput.Controls.Add(this.txtType);
            this.panelInput.Controls.Add(this.lblUnitPrice);
            this.panelInput.Controls.Add(this.txtUnitPrice);
            this.panelInput.Controls.Add(this.lblOpeningQty);
            this.panelInput.Controls.Add(this.txtOpeningQty);
            this.panelInput.Controls.Add(this.lblDescription);
            this.panelInput.Controls.Add(this.txtDescription);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.btnEdit);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Controls.Add(this.btnClear);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInput.Location = new System.Drawing.Point(687, 50);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.Size = new System.Drawing.Size(250, 470);
            this.panelInput.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(10, 10);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(85, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.Location = new System.Drawing.Point(95, 8);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(140, 25);
            this.txtProductName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(10, 45);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(85, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Loại sản phẩm:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtType.Location = new System.Drawing.Point(95, 43);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(140, 25);
            this.txtType.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 80);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(85, 25);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Đơn giá:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitPrice.Location = new System.Drawing.Point(95, 78);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(140, 25);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblOpeningQty
            // 
            this.lblOpeningQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOpeningQty.Location = new System.Drawing.Point(10, 115);
            this.lblOpeningQty.Name = "lblOpeningQty";
            this.lblOpeningQty.Size = new System.Drawing.Size(85, 25);
            this.lblOpeningQty.TabIndex = 6;
            this.lblOpeningQty.Text = "Số lượng tồn:";
            // 
            // txtOpeningQty
            // 
            this.txtOpeningQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpeningQty.Location = new System.Drawing.Point(95, 113);
            this.txtOpeningQty.Name = "txtOpeningQty";
            this.txtOpeningQty.Size = new System.Drawing.Size(140, 25);
            this.txtOpeningQty.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(10, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 25);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(95, 148);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(140, 55);
            this.txtDescription.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(125, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(125, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Làm mới";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(5, 50);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(682, 470);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.DgvProducts_SelectionChanged);
            // 
            // tabReturnOrders
            // 
            this.tabReturnOrders.Controls.Add(this.splitContainerReturns);
            this.tabReturnOrders.Controls.Add(this.panelReturnsTop);
            this.tabReturnOrders.Location = new System.Drawing.Point(4, 26);
            this.tabReturnOrders.Name = "tabReturnOrders";
            this.tabReturnOrders.Padding = new System.Windows.Forms.Padding(5);
            this.tabReturnOrders.Size = new System.Drawing.Size(942, 525);
            this.tabReturnOrders.TabIndex = 1;
            this.tabReturnOrders.Text = "Duyệt Đơn Trả Hàng";
            this.tabReturnOrders.UseVisualStyleBackColor = true;
            // 
            // panelReturnsTop
            // 
            this.panelReturnsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelReturnsTop.Controls.Add(this.txtSearchReturns);
            this.panelReturnsTop.Controls.Add(this.btnSearchReturns);
            this.panelReturnsTop.Controls.Add(this.btnRefreshReturns);
            this.panelReturnsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReturnsTop.Location = new System.Drawing.Point(5, 5);
            this.panelReturnsTop.Name = "panelReturnsTop";
            this.panelReturnsTop.Size = new System.Drawing.Size(932, 45);
            this.panelReturnsTop.TabIndex = 0;
            // 
            // txtSearchReturns
            // 
            this.txtSearchReturns.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchReturns.Location = new System.Drawing.Point(10, 9);
            this.txtSearchReturns.Name = "txtSearchReturns";
            this.txtSearchReturns.PlaceholderText = "Tìm mã đơn, tên khách...";
            this.txtSearchReturns.Size = new System.Drawing.Size(250, 27);
            this.txtSearchReturns.TabIndex = 0;
            // 
            // btnSearchReturns
            // 
            this.btnSearchReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSearchReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReturns.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchReturns.ForeColor = System.Drawing.Color.White;
            this.btnSearchReturns.Location = new System.Drawing.Point(270, 8);
            this.btnSearchReturns.Name = "btnSearchReturns";
            this.btnSearchReturns.Size = new System.Drawing.Size(85, 29);
            this.btnSearchReturns.TabIndex = 1;
            this.btnSearchReturns.Text = "Tìm kiếm";
            this.btnSearchReturns.Click += new System.EventHandler(this.BtnSearchReturns_Click);
            // 
            // btnRefreshReturns
            // 
            this.btnRefreshReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshReturns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshReturns.ForeColor = System.Drawing.Color.White;
            this.btnRefreshReturns.Location = new System.Drawing.Point(365, 8);
            this.btnRefreshReturns.Name = "btnRefreshReturns";
            this.btnRefreshReturns.Size = new System.Drawing.Size(85, 29);
            this.btnRefreshReturns.TabIndex = 2;
            this.btnRefreshReturns.Text = "Làm mới";
            this.btnRefreshReturns.Click += new System.EventHandler(this.BtnRefreshReturns_Click);
            // 
            // splitContainerReturns
            // 
            this.splitContainerReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerReturns.Location = new System.Drawing.Point(5, 50);
            this.splitContainerReturns.Name = "splitContainerReturns";
            // 
            // splitContainerReturns.Panel1
            // 
            this.splitContainerReturns.Panel1.Controls.Add(this.dgvReturnOrders);
            // 
            // splitContainerReturns.Panel2
            // 
            this.splitContainerReturns.Panel2.Controls.Add(this.panelReturnDetail);
            this.splitContainerReturns.Size = new System.Drawing.Size(932, 470);
            this.splitContainerReturns.SplitterDistance = 300;
            this.splitContainerReturns.TabIndex = 1;
            // 
            // dgvReturnOrders
            // 
            this.dgvReturnOrders.AllowUserToAddRows = false;
            this.dgvReturnOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturnOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvReturnOrders.Name = "dgvReturnOrders";
            this.dgvReturnOrders.ReadOnly = true;
            this.dgvReturnOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnOrders.Size = new System.Drawing.Size(300, 470);
            this.dgvReturnOrders.TabIndex = 0;
            this.dgvReturnOrders.SelectionChanged += new System.EventHandler(this.DgvReturnOrders_SelectionChanged);
            // 
            // panelReturnDetail
            // 
            this.panelReturnDetail.BackColor = System.Drawing.Color.White;
            this.panelReturnDetail.Controls.Add(this.dgvReturnDetails);
            this.panelReturnDetail.Controls.Add(this.btnApproveReturn);
            this.panelReturnDetail.Controls.Add(this.lblReturnInfo);
            this.panelReturnDetail.Controls.Add(this.lblReturnTitle);
            this.panelReturnDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReturnDetail.Location = new System.Drawing.Point(0, 0);
            this.panelReturnDetail.Name = "panelReturnDetail";
            this.panelReturnDetail.Padding = new System.Windows.Forms.Padding(10);
            this.panelReturnDetail.Size = new System.Drawing.Size(628, 470);
            this.panelReturnDetail.TabIndex = 0;
            // 
            // lblReturnTitle
            // 
            this.lblReturnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReturnTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblReturnTitle.Location = new System.Drawing.Point(10, 10);
            this.lblReturnTitle.Name = "lblReturnTitle";
            this.lblReturnTitle.Size = new System.Drawing.Size(608, 25);
            this.lblReturnTitle.TabIndex = 0;
            this.lblReturnTitle.Text = "Chi tiết kiện hàng bị trả về: ---";
            // 
            // lblReturnInfo
            // 
            this.lblReturnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReturnInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReturnInfo.Location = new System.Drawing.Point(10, 35);
            this.lblReturnInfo.Name = "lblReturnInfo";
            this.lblReturnInfo.Size = new System.Drawing.Size(608, 60);
            this.lblReturnInfo.TabIndex = 1;
            this.lblReturnInfo.Text = "Chọn đơn hàng bên trái để kiểm duyệt danh mục đóng gói nhập kho.";
            // 
            // btnApproveReturn
            // 
            this.btnApproveReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnApproveReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApproveReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApproveReturn.ForeColor = System.Drawing.Color.White;
            this.btnApproveReturn.Location = new System.Drawing.Point(10, 420);
            this.btnApproveReturn.Name = "btnApproveReturn";
            this.btnApproveReturn.Size = new System.Drawing.Size(608, 40);
            this.btnApproveReturn.TabIndex = 2;
            this.btnApproveReturn.Text = "✔ XÁC NHẬN KIỂM HÀNG ĐỦ & NHẬP LẠI TỒN KHO";
            this.btnApproveReturn.Click += new System.EventHandler(this.BtnApproveReturn_Click);
            // 
            // dgvReturnDetails
            // 
            this.dgvReturnDetails.AllowUserToAddRows = false;
            this.dgvReturnDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvReturnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturnDetails.Location = new System.Drawing.Point(10, 95);
            this.dgvReturnDetails.Name = "dgvReturnDetails";
            this.dgvReturnDetails.ReadOnly = true;
            this.dgvReturnDetails.Size = new System.Drawing.Size(608, 325);
            this.dgvReturnDetails.TabIndex = 3;
            // 
            // ProductManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "ProductManagementControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.panelTopActions.ResumeLayout(false);
            this.panelTopActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.tabReturnOrders.ResumeLayout(false);
            this.panelReturnsTop.ResumeLayout(false);
            this.panelReturnsTop.PerformLayout();
            this.splitContainerReturns.Panel1.ResumeLayout(false);
            this.splitContainerReturns.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReturns)).EndInit();
            this.splitContainerReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOrders)).EndInit();
            this.panelReturnDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Panel panelTopActions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblOpeningQty;
        private System.Windows.Forms.TextBox txtOpeningQty;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabReturnOrders;
        private System.Windows.Forms.Panel panelReturnsTop;
        private System.Windows.Forms.TextBox txtSearchReturns;
        private System.Windows.Forms.Button btnSearchReturns;
        private System.Windows.Forms.Button btnRefreshReturns;
        private System.Windows.Forms.SplitContainer splitContainerReturns;
        private System.Windows.Forms.DataGridView dgvReturnOrders;
        private System.Windows.Forms.Panel panelReturnDetail;
        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.Label lblReturnInfo;
        private System.Windows.Forms.DataGridView dgvReturnDetails;
        private System.Windows.Forms.Button btnApproveReturn;
    }
}
