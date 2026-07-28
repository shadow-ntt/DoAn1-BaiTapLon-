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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControlWarehouse = new TabControl();
            tabInventory = new TabPage();
            pnlMain = new Panel();
            dgvProducts = new DataGridView();
            pnlActions = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
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
            tabReturnApproval = new TabPage();
            splitReturns = new SplitContainer();
            dgvReturnOrders = new DataGridView();
            pnlReturnSearch = new Panel();
            lblSearchReturns = new Label();
            txtSearchReturns = new TextBox();
            btnSearchReturns = new Button();
            btnRefreshReturns = new Button();
            pnlReturnDetails = new Panel();
            lblReturnTitle = new Label();
            lblReturnOrderId = new Label();
            txtReturnOrderId = new TextBox();
            lblReturnInvoiceDate = new Label();
            txtReturnInvoiceDate = new TextBox();
            lblReturnCustomer = new Label();
            txtReturnCustomer = new TextBox();
            lblReturnReasonDetail = new Label();
            txtReturnReasonDetail = new TextBox();
            lblReturnOrderDetails = new Label();
            dgvReturnOrderDetails = new DataGridView();
            btnApproveReturn = new Button();
            tabControlWarehouse.SuspendLayout();
            tabInventory.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlActions.SuspendLayout();
            pnlSidebar.SuspendLayout();
            tabReturnApproval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitReturns).BeginInit();
            splitReturns.Panel1.SuspendLayout();
            splitReturns.Panel2.SuspendLayout();
            splitReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnOrders).BeginInit();
            pnlReturnSearch.SuspendLayout();
            pnlReturnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // tabControlWarehouse
            // 
            tabControlWarehouse.Controls.Add(tabInventory);
            tabControlWarehouse.Controls.Add(tabReturnApproval);
            tabControlWarehouse.Dock = DockStyle.Fill;
            tabControlWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlWarehouse.Location = new Point(0, 0);
            tabControlWarehouse.Name = "tabControlWarehouse";
            tabControlWarehouse.SelectedIndex = 0;
            tabControlWarehouse.Size = new Size(1280, 800);
            tabControlWarehouse.TabIndex = 0;
            // 
            // tabInventory
            // 
            tabInventory.BackColor = Color.White;
            tabInventory.Controls.Add(pnlMain);
            tabInventory.Controls.Add(pnlSidebar);
            tabInventory.Location = new Point(4, 32);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(1272, 764);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Tồn kho hiện tại";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(dgvProducts);
            pnlMain.Controls.Add(pnlActions);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(343, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(15);
            pnlMain.Size = new Size(926, 758);
            pnlMain.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 242, 254);
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
            dgvProducts.Size = new Size(896, 668);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(txtSearch);
            pnlActions.Controls.Add(btnSearch);
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Controls.Add(btnEdit);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnClear);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(15, 15);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(896, 60);
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
            btnSearch.Size = new Size(90, 30);
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
            btnAdd.Size = new Size(110, 30);
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
            btnEdit.Location = new Point(520, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 30);
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
            btnDelete.Location = new Point(640, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 30);
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
            btnClear.Location = new Point(760, 13);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "LÀM MỚI (↻)";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(250, 250, 250);
            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
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
            pnlSidebar.Location = new Point(3, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(340, 758);
            pnlSidebar.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblSidebarTitle.Location = new Point(20, 15);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(300, 25);
            lblSidebarTitle.TabIndex = 0;
            lblSidebarTitle.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(71, 85, 105);
            lblId.Location = new Point(20, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(205, 23);
            lblId.TabIndex = 1;
            lblId.Text = "Mã Sản Phẩm (Tự động)";
            // 
            // txtProductId
            // 
            txtProductId.BackColor = Color.FromArgb(241, 245, 249);
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Enabled = false;
            txtProductId.Font = new Font("Segoe UI", 10F);
            txtProductId.ForeColor = Color.FromArgb(51, 65, 85);
            txtProductId.Location = new Point(20, 78);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(300, 30);
            txtProductId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(71, 85, 105);
            lblName.Location = new Point(20, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Tên Sản Phẩm *";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.ForeColor = Color.Black;
            txtProductName.Location = new Point(20, 138);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 30);
            txtProductName.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblType.ForeColor = Color.FromArgb(71, 85, 105);
            lblType.Location = new Point(20, 175);
            lblType.Name = "lblType";
            lblType.Size = new Size(150, 20);
            lblType.TabIndex = 5;
            lblType.Text = "Phân Loại";
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Segoe UI", 10F);
            txtType.ForeColor = Color.Black;
            txtType.Location = new Point(20, 198);
            txtType.Name = "txtType";
            txtType.Size = new Size(300, 30);
            txtType.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(71, 85, 105);
            lblPrice.Location = new Point(20, 235);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(150, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Đơn Giá *";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 10F);
            txtUnitPrice.ForeColor = Color.Black;
            txtUnitPrice.Location = new Point(20, 258);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(300, 30);
            txtUnitPrice.TabIndex = 8;
            // 
            // lblQty
            // 
            lblQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQty.ForeColor = Color.FromArgb(71, 85, 105);
            lblQty.Location = new Point(20, 295);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(150, 20);
            lblQty.TabIndex = 9;
            lblQty.Text = "Số Lượng Tồn Kho *";
            // 
            // txtOpeningQuantity
            // 
            txtOpeningQuantity.BackColor = Color.White;
            txtOpeningQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtOpeningQuantity.Font = new Font("Segoe UI", 10F);
            txtOpeningQuantity.ForeColor = Color.Black;
            txtOpeningQuantity.Location = new Point(20, 318);
            txtOpeningQuantity.Name = "txtOpeningQuantity";
            txtOpeningQuantity.Size = new Size(300, 30);
            txtOpeningQuantity.TabIndex = 10;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesc.ForeColor = Color.FromArgb(71, 85, 105);
            lblDesc.Location = new Point(20, 355);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(150, 20);
            lblDesc.TabIndex = 11;
            lblDesc.Text = "Mô Tả Chi Tiết";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(20, 378);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(300, 100);
            txtDescription.TabIndex = 12;
            // 
            // tabReturnApproval
            // 
            tabReturnApproval.BackColor = Color.White;
            tabReturnApproval.Controls.Add(splitReturns);
            tabReturnApproval.Location = new Point(4, 32);
            tabReturnApproval.Name = "tabReturnApproval";
            tabReturnApproval.Padding = new Padding(3);
            tabReturnApproval.Size = new Size(1272, 764);
            tabReturnApproval.TabIndex = 1;
            tabReturnApproval.Text = "Duyệt đơn trả hàng";
            // 
            // splitReturns
            // 
            splitReturns.Dock = DockStyle.Fill;
            splitReturns.Location = new Point(3, 3);
            splitReturns.Name = "splitReturns";
            // 
            // splitReturns.Panel1
            // 
            splitReturns.Panel1.Controls.Add(dgvReturnOrders);
            splitReturns.Panel1.Controls.Add(pnlReturnSearch);
            // 
            // splitReturns.Panel2
            // 
            splitReturns.Panel2.Controls.Add(pnlReturnDetails);
            splitReturns.Size = new Size(1266, 758);
            splitReturns.SplitterDistance = 500;
            splitReturns.TabIndex = 0;
            // 
            // dgvReturnOrders
            // 
            dgvReturnOrders.AllowUserToAddRows = false;
            dgvReturnOrders.AllowUserToDeleteRows = false;
            dgvReturnOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnOrders.BackgroundColor = Color.White;
            dgvReturnOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReturnOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReturnOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReturnOrders.ColumnHeadersHeight = 38;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvReturnOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dgvReturnOrders.Dock = DockStyle.Fill;
            dgvReturnOrders.EnableHeadersVisualStyles = false;
            dgvReturnOrders.GridColor = Color.FromArgb(226, 232, 240);
            dgvReturnOrders.Location = new Point(0, 55);
            dgvReturnOrders.Name = "dgvReturnOrders";
            dgvReturnOrders.ReadOnly = true;
            dgvReturnOrders.RowHeadersVisible = false;
            dgvReturnOrders.RowHeadersWidth = 51;
            dgvReturnOrders.RowTemplate.Height = 35;
            dgvReturnOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnOrders.Size = new Size(500, 703);
            dgvReturnOrders.TabIndex = 1;
            dgvReturnOrders.CellClick += dgvReturnOrders_CellClick;
            dgvReturnOrders.SelectionChanged += dgvReturnOrders_SelectionChanged;
            // 
            // pnlReturnSearch
            // 
            pnlReturnSearch.BackColor = Color.White;
            pnlReturnSearch.Controls.Add(lblSearchReturns);
            pnlReturnSearch.Controls.Add(txtSearchReturns);
            pnlReturnSearch.Controls.Add(btnSearchReturns);
            pnlReturnSearch.Controls.Add(btnRefreshReturns);
            pnlReturnSearch.Dock = DockStyle.Top;
            pnlReturnSearch.Location = new Point(0, 0);
            pnlReturnSearch.Name = "pnlReturnSearch";
            pnlReturnSearch.Size = new Size(500, 55);
            pnlReturnSearch.TabIndex = 0;
            // 
            // lblSearchReturns
            // 
            lblSearchReturns.AutoSize = true;
            lblSearchReturns.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearchReturns.Location = new Point(10, 16);
            lblSearchReturns.Name = "lblSearchReturns";
            lblSearchReturns.Size = new Size(85, 21);
            lblSearchReturns.TabIndex = 0;
            lblSearchReturns.Text = "Tìm kiếm:";
            // 
            // txtSearchReturns
            // 
            txtSearchReturns.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchReturns.BorderStyle = BorderStyle.FixedSingle;
            txtSearchReturns.Font = new Font("Segoe UI", 10F);
            txtSearchReturns.Location = new Point(95, 12);
            txtSearchReturns.Name = "txtSearchReturns";
            txtSearchReturns.Size = new Size(200, 30);
            txtSearchReturns.TabIndex = 1;
            // 
            // btnSearchReturns
            // 
            btnSearchReturns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchReturns.BackColor = Color.FromArgb(71, 85, 105);
            btnSearchReturns.FlatAppearance.BorderSize = 0;
            btnSearchReturns.FlatStyle = FlatStyle.Flat;
            btnSearchReturns.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearchReturns.ForeColor = Color.White;
            btnSearchReturns.Location = new Point(302, 12);
            btnSearchReturns.Name = "btnSearchReturns";
            btnSearchReturns.Size = new Size(85, 30);
            btnSearchReturns.TabIndex = 2;
            btnSearchReturns.Text = "TÌM";
            btnSearchReturns.UseVisualStyleBackColor = false;
            btnSearchReturns.Click += btnSearchReturns_Click;
            // 
            // btnRefreshReturns
            // 
            btnRefreshReturns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshReturns.BackColor = Color.FromArgb(100, 116, 139);
            btnRefreshReturns.FlatAppearance.BorderSize = 0;
            btnRefreshReturns.FlatStyle = FlatStyle.Flat;
            btnRefreshReturns.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshReturns.ForeColor = Color.White;
            btnRefreshReturns.Location = new Point(393, 12);
            btnRefreshReturns.Name = "btnRefreshReturns";
            btnRefreshReturns.Size = new Size(95, 30);
            btnRefreshReturns.TabIndex = 3;
            btnRefreshReturns.Text = "TẢI LẠI";
            btnRefreshReturns.UseVisualStyleBackColor = false;
            btnRefreshReturns.Click += btnRefreshReturns_Click;
            // 
            // pnlReturnDetails
            // 
            pnlReturnDetails.BackColor = Color.White;
            pnlReturnDetails.Controls.Add(lblReturnTitle);
            pnlReturnDetails.Controls.Add(lblReturnOrderId);
            pnlReturnDetails.Controls.Add(txtReturnOrderId);
            pnlReturnDetails.Controls.Add(lblReturnInvoiceDate);
            pnlReturnDetails.Controls.Add(txtReturnInvoiceDate);
            pnlReturnDetails.Controls.Add(lblReturnCustomer);
            pnlReturnDetails.Controls.Add(txtReturnCustomer);
            pnlReturnDetails.Controls.Add(lblReturnReasonDetail);
            pnlReturnDetails.Controls.Add(txtReturnReasonDetail);
            pnlReturnDetails.Controls.Add(lblReturnOrderDetails);
            pnlReturnDetails.Controls.Add(dgvReturnOrderDetails);
            pnlReturnDetails.Controls.Add(btnApproveReturn);
            pnlReturnDetails.Dock = DockStyle.Fill;
            pnlReturnDetails.Location = new Point(0, 0);
            pnlReturnDetails.Name = "pnlReturnDetails";
            pnlReturnDetails.Padding = new Padding(20);
            pnlReturnDetails.Size = new Size(762, 758);
            pnlReturnDetails.TabIndex = 0;
            // 
            // lblReturnTitle
            // 
            lblReturnTitle.AutoSize = true;
            lblReturnTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblReturnTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblReturnTitle.Location = new Point(20, 15);
            lblReturnTitle.Name = "lblReturnTitle";
            lblReturnTitle.Size = new Size(323, 31);
            lblReturnTitle.TabIndex = 0;
            lblReturnTitle.Text = "THÔNG TIN ĐƠN TRẢ HÀNG";
            // 
            // lblReturnOrderId
            // 
            lblReturnOrderId.AutoSize = true;
            lblReturnOrderId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReturnOrderId.ForeColor = Color.FromArgb(71, 85, 105);
            lblReturnOrderId.Location = new Point(20, 61);
            lblReturnOrderId.Name = "lblReturnOrderId";
            lblReturnOrderId.Size = new Size(115, 21);
            lblReturnOrderId.TabIndex = 1;
            lblReturnOrderId.Text = "Mã đơn hàng:";
            // 
            // txtReturnOrderId
            // 
            txtReturnOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReturnOrderId.BackColor = Color.FromArgb(241, 245, 249);
            txtReturnOrderId.BorderStyle = BorderStyle.FixedSingle;
            txtReturnOrderId.Location = new Point(180, 58);
            txtReturnOrderId.Name = "txtReturnOrderId";
            txtReturnOrderId.ReadOnly = true;
            txtReturnOrderId.Size = new Size(540, 30);
            txtReturnOrderId.TabIndex = 2;
            // 
            // lblReturnInvoiceDate
            // 
            lblReturnInvoiceDate.AutoSize = true;
            lblReturnInvoiceDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReturnInvoiceDate.ForeColor = Color.FromArgb(71, 85, 105);
            lblReturnInvoiceDate.Location = new Point(20, 103);
            lblReturnInvoiceDate.Name = "lblReturnInvoiceDate";
            lblReturnInvoiceDate.Size = new Size(150, 21);
            lblReturnInvoiceDate.TabIndex = 3;
            lblReturnInvoiceDate.Text = "Ngày lập hóa đơn:";
            // 
            // txtReturnInvoiceDate
            // 
            txtReturnInvoiceDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReturnInvoiceDate.BackColor = Color.FromArgb(241, 245, 249);
            txtReturnInvoiceDate.BorderStyle = BorderStyle.FixedSingle;
            txtReturnInvoiceDate.Location = new Point(180, 100);
            txtReturnInvoiceDate.Name = "txtReturnInvoiceDate";
            txtReturnInvoiceDate.ReadOnly = true;
            txtReturnInvoiceDate.Size = new Size(540, 30);
            txtReturnInvoiceDate.TabIndex = 4;
            // 
            // lblReturnCustomer
            // 
            lblReturnCustomer.AutoSize = true;
            lblReturnCustomer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReturnCustomer.ForeColor = Color.FromArgb(71, 85, 105);
            lblReturnCustomer.Location = new Point(20, 145);
            lblReturnCustomer.Name = "lblReturnCustomer";
            lblReturnCustomer.Size = new Size(104, 21);
            lblReturnCustomer.TabIndex = 5;
            lblReturnCustomer.Text = "Khách hàng:";
            // 
            // txtReturnCustomer
            // 
            txtReturnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReturnCustomer.BackColor = Color.FromArgb(241, 245, 249);
            txtReturnCustomer.BorderStyle = BorderStyle.FixedSingle;
            txtReturnCustomer.Location = new Point(180, 142);
            txtReturnCustomer.Name = "txtReturnCustomer";
            txtReturnCustomer.ReadOnly = true;
            txtReturnCustomer.Size = new Size(540, 30);
            txtReturnCustomer.TabIndex = 6;
            txtReturnCustomer.TextChanged += txtReturnCustomer_TextChanged;
            // 
            // lblReturnReasonDetail
            // 
            lblReturnReasonDetail.AutoSize = true;
            lblReturnReasonDetail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReturnReasonDetail.ForeColor = Color.FromArgb(71, 85, 105);
            lblReturnReasonDetail.Location = new Point(20, 187);
            lblReturnReasonDetail.Name = "lblReturnReasonDetail";
            lblReturnReasonDetail.Size = new Size(123, 21);
            lblReturnReasonDetail.TabIndex = 7;
            lblReturnReasonDetail.Text = "Lý do trả hàng:";
            // 
            // txtReturnReasonDetail
            // 
            txtReturnReasonDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReturnReasonDetail.BackColor = Color.FromArgb(254, 242, 242);
            txtReturnReasonDetail.BorderStyle = BorderStyle.FixedSingle;
            txtReturnReasonDetail.ForeColor = Color.FromArgb(153, 27, 27);
            txtReturnReasonDetail.Location = new Point(180, 184);
            txtReturnReasonDetail.Multiline = true;
            txtReturnReasonDetail.Name = "txtReturnReasonDetail";
            txtReturnReasonDetail.ReadOnly = true;
            txtReturnReasonDetail.ScrollBars = ScrollBars.Vertical;
            txtReturnReasonDetail.Size = new Size(540, 65);
            txtReturnReasonDetail.TabIndex = 8;
            // 
            // lblReturnOrderDetails
            // 
            lblReturnOrderDetails.AutoSize = true;
            lblReturnOrderDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReturnOrderDetails.ForeColor = Color.FromArgb(15, 23, 42);
            lblReturnOrderDetails.Location = new Point(20, 262);
            lblReturnOrderDetails.Name = "lblReturnOrderDetails";
            lblReturnOrderDetails.Size = new Size(230, 23);
            lblReturnOrderDetails.TabIndex = 9;
            lblReturnOrderDetails.Text = "Danh sách sản phẩm trả lại:";
            // 
            // dgvReturnOrderDetails
            // 
            dgvReturnOrderDetails.AllowUserToAddRows = false;
            dgvReturnOrderDetails.AllowUserToDeleteRows = false;
            dgvReturnOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReturnOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnOrderDetails.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvReturnOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvReturnOrderDetails.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvReturnOrderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            dgvReturnOrderDetails.EnableHeadersVisualStyles = false;
            dgvReturnOrderDetails.GridColor = Color.FromArgb(226, 232, 240);
            dgvReturnOrderDetails.Location = new Point(20, 290);
            dgvReturnOrderDetails.Name = "dgvReturnOrderDetails";
            dgvReturnOrderDetails.ReadOnly = true;
            dgvReturnOrderDetails.RowHeadersVisible = false;
            dgvReturnOrderDetails.RowHeadersWidth = 51;
            dgvReturnOrderDetails.RowTemplate.Height = 30;
            dgvReturnOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnOrderDetails.Size = new Size(700, 370);
            dgvReturnOrderDetails.TabIndex = 10;
            // 
            // btnApproveReturn
            // 
            btnApproveReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnApproveReturn.BackColor = Color.FromArgb(16, 185, 129);
            btnApproveReturn.Cursor = Cursors.Hand;
            btnApproveReturn.FlatAppearance.BorderSize = 0;
            btnApproveReturn.FlatStyle = FlatStyle.Flat;
            btnApproveReturn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnApproveReturn.ForeColor = Color.White;
            btnApproveReturn.Location = new Point(20, 675);
            btnApproveReturn.Name = "btnApproveReturn";
            btnApproveReturn.Size = new Size(700, 55);
            btnApproveReturn.TabIndex = 11;
            btnApproveReturn.Text = "XÁC NHẬN NHẬP KHO & DUYỆT TRẢ HÀNG";
            btnApproveReturn.UseVisualStyleBackColor = false;
            btnApproveReturn.Click += btnApproveReturn_Click;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 800);
            Controls.Add(tabControlWarehouse);
            MinimumSize = new Size(1200, 750);
            Name = "WarehouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavita Warehouse Management";
            WindowState = FormWindowState.Maximized;
            Load += WarehouseForm_Load;
            tabControlWarehouse.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            tabReturnApproval.ResumeLayout(false);
            splitReturns.Panel1.ResumeLayout(false);
            splitReturns.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitReturns).EndInit();
            splitReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReturnOrders).EndInit();
            pnlReturnSearch.ResumeLayout(false);
            pnlReturnSearch.PerformLayout();
            pnlReturnDetails.ResumeLayout(false);
            pnlReturnDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Main Tab Control
        private System.Windows.Forms.TabControl tabControlWarehouse;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabReturnApproval;

        // Tab 1 Controls (Current Warehouse)
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtOpeningQuantity;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        // Tab 2 Controls (Return Order Approval)
        private System.Windows.Forms.SplitContainer splitReturns;
        private System.Windows.Forms.Panel pnlReturnSearch;
        private System.Windows.Forms.Label lblSearchReturns;
        private System.Windows.Forms.TextBox txtSearchReturns;
        private System.Windows.Forms.Button btnSearchReturns;
        private System.Windows.Forms.Button btnRefreshReturns;
        private System.Windows.Forms.DataGridView dgvReturnOrders;
        private System.Windows.Forms.Panel pnlReturnDetails;
        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.Label lblReturnOrderId;
        private System.Windows.Forms.TextBox txtReturnOrderId;
        private System.Windows.Forms.Label lblReturnInvoiceDate;
        private System.Windows.Forms.TextBox txtReturnInvoiceDate;
        private System.Windows.Forms.Label lblReturnCustomer;
        private System.Windows.Forms.TextBox txtReturnCustomer;
        private System.Windows.Forms.Label lblReturnReasonDetail;
        private System.Windows.Forms.TextBox txtReturnReasonDetail;
        private System.Windows.Forms.Label lblReturnOrderDetails;
        private System.Windows.Forms.DataGridView dgvReturnOrderDetails;
        private System.Windows.Forms.Button btnApproveReturn;
    }
}