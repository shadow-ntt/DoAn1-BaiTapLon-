using System.Drawing;
using System.Windows.Forms;

namespace DoAn1.Forms
{
    partial class SupervisorForm
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
            DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle();

            tabControlMain = new TabControl();
            tabPending = new TabPage();
            splitMain = new SplitContainer();
            lstOrders = new ListBox();
            pnlLeftHeader = new Panel();
            btnRefresh = new Button();
            lblLeftTitle = new Label();
            tlpRightMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblCustomerInfo = new Label();
            lblOrderTitle = new Label();
            tlpMiddle = new TableLayoutPanel();
            grpCreditInfo = new GroupBox();
            lblCreditPlaceholder = new Label();
            grpInventory = new GroupBox();
            dgvInventory = new DataGridView();
            colProduct = new DataGridViewTextBoxColumn();
            colRequest = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            grpReview = new GroupBox();
            txtNotes = new TextBox();
            lblWarningNote = new Label();
            flpButtons = new FlowLayoutPanel();
            btnApprove = new Button();
            btnReturn = new Button();
            tabHistory = new TabPage();
            splitHistory = new SplitContainer();
            dgvHistoryList = new DataGridView();
            colHOrderId = new DataGridViewTextBoxColumn();
            colHCustomer = new DataGridViewTextBoxColumn();
            colHDate = new DataGridViewTextBoxColumn();
            colHStatus = new DataGridViewTextBoxColumn();
            pnlSearch = new Panel();
            btnRefreshHistory = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            tlpHistoryDetails = new TableLayoutPanel();
            grpHistoryInfo = new GroupBox();
            lblHistoryCustomerDetails = new Label();
            grpHistoryReason = new GroupBox();
            txtHistoryReason = new TextBox();
            grpHistoryProducts = new GroupBox();
            dgvHistoryProducts = new DataGridView();
            colHPName = new DataGridViewTextBoxColumn();
            colHPQty = new DataGridViewTextBoxColumn();
            colHPPrice = new DataGridViewTextBoxColumn();
            colHPTotal = new DataGridViewTextBoxColumn();
            tabControlMain.SuspendLayout();
            tabPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlLeftHeader.SuspendLayout();
            tlpRightMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpMiddle.SuspendLayout();
            grpCreditInfo.SuspendLayout();
            grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            grpReview.SuspendLayout();
            flpButtons.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitHistory).BeginInit();
            splitHistory.Panel1.SuspendLayout();
            splitHistory.Panel2.SuspendLayout();
            splitHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryList).BeginInit();
            pnlSearch.SuspendLayout();
            tlpHistoryDetails.SuspendLayout();
            grpHistoryInfo.SuspendLayout();
            grpHistoryReason.SuspendLayout();
            grpHistoryProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryProducts).BeginInit();
            SuspendLayout();

            // Setup kieu Font chuẩn cho toàn bộ DataGridView
            dgvHeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvHeaderStyle.ForeColor = Color.FromArgb(15, 23, 42);

            dgvCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgvCellStyle.SelectionForeColor = Color.FromArgb(79, 70, 229);

            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPending);
            tabControlMain.Controls.Add(tabHistory);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1486, 1055);
            tabControlMain.TabIndex = 0;
            // 
            // tabPending
            // 
            tabPending.Controls.Add(splitMain);
            tabPending.Location = new Point(4, 32);
            tabPending.Margin = new Padding(3, 4, 3, 4);
            tabPending.Name = "tabPending";
            tabPending.Padding = new Padding(3, 4, 3, 4);
            tabPending.Size = new Size(1478, 1019);
            tabPending.TabIndex = 0;
            tabPending.Text = "Kiểm duyệt đơn hàng";
            tabPending.UseVisualStyleBackColor = true;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.FixedPanel = FixedPanel.Panel1;
            splitMain.Location = new Point(3, 4);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.BackColor = Color.FromArgb(248, 249, 250);
            splitMain.Panel1.Controls.Add(lstOrders);
            splitMain.Panel1.Controls.Add(pnlLeftHeader);
            splitMain.Panel1.Padding = new Padding(14, 16, 14, 16);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.BackColor = Color.White;
            splitMain.Panel2.Controls.Add(tlpRightMain);
            splitMain.Size = new Size(1472, 1011);
            splitMain.SplitterDistance = 366;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            // 
            // lstOrders
            // 
            lstOrders.Dock = DockStyle.Fill;
            lstOrders.DrawMode = DrawMode.OwnerDrawFixed;
            lstOrders.ItemHeight = 78;
            lstOrders.Location = new Point(14, 66);
            lstOrders.Margin = new Padding(3, 4, 3, 4);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(338, 929);
            lstOrders.TabIndex = 1;
            // 
            // pnlLeftHeader
            // 
            pnlLeftHeader.Controls.Add(btnRefresh);
            pnlLeftHeader.Controls.Add(lblLeftTitle);
            pnlLeftHeader.Dock = DockStyle.Top;
            pnlLeftHeader.Location = new Point(14, 16);
            pnlLeftHeader.Name = "pnlLeftHeader";
            pnlLeftHeader.Size = new Size(338, 50);
            pnlLeftHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(238, 242, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(79, 70, 229);
            btnRefresh.Location = new Point(235, 8);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblLeftTitle
            // 
            lblLeftTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLeftTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLeftTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblLeftTitle.Location = new Point(0, 0);
            lblLeftTitle.Name = "lblLeftTitle";
            lblLeftTitle.Size = new Size(230, 50);
            lblLeftTitle.TabIndex = 0;
            lblLeftTitle.Text = "ĐƠN HÀNG CHỜ DUYỆT";
            lblLeftTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpRightMain
            // 
            tlpRightMain.ColumnCount = 1;
            tlpRightMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRightMain.Controls.Add(pnlHeader, 0, 0);
            tlpRightMain.Controls.Add(tlpMiddle, 0, 1);
            tlpRightMain.Controls.Add(grpReview, 0, 2);
            tlpRightMain.Dock = DockStyle.Fill;
            tlpRightMain.Location = new Point(0, 0);
            tlpRightMain.Margin = new Padding(3, 4, 3, 4);
            tlpRightMain.Name = "tlpRightMain";
            tlpRightMain.RowCount = 3;
            tlpRightMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpRightMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRightMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            tlpRightMain.Size = new Size(1101, 1011);
            tlpRightMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(241, 245, 249);
            pnlHeader.Controls.Add(lblCustomerInfo);
            pnlHeader.Controls.Add(lblOrderTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 4);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1095, 92);
            pnlHeader.TabIndex = 0;
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            lblCustomerInfo.ForeColor = Color.FromArgb(51, 65, 85);
            lblCustomerInfo.Location = new Point(14, 51);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(130, 25);
            lblCustomerInfo.TabIndex = 0;
            lblCustomerInfo.Text = "Khách hàng: ---";
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblOrderTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblOrderTitle.Location = new Point(11, 11);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(245, 31);
            lblOrderTitle.TabIndex = 1;
            lblOrderTitle.Text = "Chi tiết đơn hàng: ---";
            // 
            // tlpMiddle
            // 
            tlpMiddle.ColumnCount = 2;
            tlpMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpMiddle.Controls.Add(grpCreditInfo, 0, 0);
            tlpMiddle.Controls.Add(grpInventory, 1, 0);
            tlpMiddle.Dock = DockStyle.Fill;
            tlpMiddle.Location = new Point(3, 104);
            tlpMiddle.Margin = new Padding(3, 4, 3, 4);
            tlpMiddle.Name = "tlpMiddle";
            tlpMiddle.RowCount = 1;
            tlpMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMiddle.Size = new Size(1095, 663);
            tlpMiddle.TabIndex = 1;
            // 
            // grpCreditInfo
            // 
            grpCreditInfo.Controls.Add(lblCreditPlaceholder);
            grpCreditInfo.Dock = DockStyle.Fill;
            grpCreditInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpCreditInfo.Location = new Point(3, 4);
            grpCreditInfo.Margin = new Padding(3, 4, 3, 4);
            grpCreditInfo.Name = "grpCreditInfo";
            grpCreditInfo.Padding = new Padding(8);
            grpCreditInfo.Size = new Size(377, 655);
            grpCreditInfo.TabIndex = 0;
            grpCreditInfo.TabStop = false;
            grpCreditInfo.Text = "Thông tin tín dụng";
            // 
            // lblCreditPlaceholder
            // 
            lblCreditPlaceholder.Dock = DockStyle.Fill;
            lblCreditPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblCreditPlaceholder.ForeColor = Color.FromArgb(30, 41, 59);
            lblCreditPlaceholder.Location = new Point(8, 32);
            lblCreditPlaceholder.Name = "lblCreditPlaceholder";
            lblCreditPlaceholder.Size = new Size(361, 615);
            lblCreditPlaceholder.TabIndex = 0;
            // 
            // grpInventory
            // 
            grpInventory.Controls.Add(dgvInventory);
            grpInventory.Dock = DockStyle.Fill;
            grpInventory.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpInventory.Location = new Point(386, 4);
            grpInventory.Margin = new Padding(3, 4, 3, 4);
            grpInventory.Name = "grpInventory";
            grpInventory.Padding = new Padding(3, 4, 3, 4);
            grpInventory.Size = new Size(706, 655);
            grpInventory.TabIndex = 1;
            grpInventory.TabStop = false;
            grpInventory.Text = "Tồn kho sản phẩm";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvInventory.ColumnHeadersHeight = 35;
            dgvInventory.DefaultCellStyle = dgvCellStyle;
            dgvInventory.RowTemplate.Height = 32;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colProduct, colRequest, colStock, colStatus });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(3, 29);
            dgvInventory.Margin = new Padding(3, 4, 3, 4);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(700, 622);
            dgvInventory.TabIndex = 0;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "SẢN PHẨM";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colRequest
            // 
            colRequest.HeaderText = "YÊU CẦU";
            colRequest.MinimumWidth = 6;
            colRequest.Name = "colRequest";
            colRequest.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "TỒN KHO";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "TRẠNG THÁI";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // grpReview
            // 
            grpReview.Controls.Add(txtNotes);
            grpReview.Controls.Add(lblWarningNote);
            grpReview.Controls.Add(flpButtons);
            grpReview.Dock = DockStyle.Fill;
            grpReview.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpReview.Location = new Point(3, 775);
            grpReview.Margin = new Padding(3, 4, 3, 4);
            grpReview.Name = "grpReview";
            grpReview.Padding = new Padding(3, 4, 3, 4);
            grpReview.Size = new Size(1095, 232);
            grpReview.TabIndex = 2;
            grpReview.TabStop = false;
            grpReview.Text = "Ý kiến kiểm duyệt";
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtNotes.Location = new Point(14, 60);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Nhập lý do nếu bạn trả lại đơn hàng...";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(1067, 85);
            txtNotes.TabIndex = 1;
            // 
            // lblWarningNote
            // 
            lblWarningNote.AutoSize = true;
            lblWarningNote.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblWarningNote.ForeColor = Color.FromArgb(71, 85, 105);
            lblWarningNote.Location = new Point(14, 31);
            lblWarningNote.Name = "lblWarningNote";
            lblWarningNote.Size = new Size(207, 21);
            lblWarningNote.TabIndex = 0;
            lblWarningNote.Text = "Ghi chú duyệt / Lý do từ chối:";
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnApprove);
            flpButtons.Controls.Add(btnReturn);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 155);
            flpButtons.Margin = new Padding(3, 4, 3, 4);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(1089, 73);
            flpButtons.TabIndex = 2;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(13, 110, 253);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(926, 4);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(160, 56);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Duyệt đơn";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(220, 53, 69);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(753, 4);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(167, 56);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Trả / Từ chối";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(splitHistory);
            tabHistory.Location = new Point(4, 32);
            tabHistory.Margin = new Padding(3, 4, 3, 4);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3, 4, 3, 4);
            tabHistory.Size = new Size(1478, 1019);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "Lịch sử kiểm duyệt";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // splitHistory
            // 
            splitHistory.Dock = DockStyle.Fill;
            splitHistory.Location = new Point(3, 4);
            splitHistory.Margin = new Padding(3, 4, 3, 4);
            splitHistory.Name = "splitHistory";
            // 
            // splitHistory.Panel1
            // 
            splitHistory.Panel1.Controls.Add(dgvHistoryList);
            splitHistory.Panel1.Controls.Add(pnlSearch);
            // 
            // splitHistory.Panel2
            // 
            splitHistory.Panel2.Controls.Add(tlpHistoryDetails);
            splitHistory.Size = new Size(1472, 1011);
            splitHistory.SplitterDistance = 549;
            splitHistory.SplitterWidth = 5;
            splitHistory.TabIndex = 0;
            // 
            // dgvHistoryList
            // 
            dgvHistoryList.AllowUserToAddRows = false;
            dgvHistoryList.AllowUserToDeleteRows = false;
            dgvHistoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoryList.BackgroundColor = Color.White;
            dgvHistoryList.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvHistoryList.ColumnHeadersHeight = 35;
            dgvHistoryList.DefaultCellStyle = dgvCellStyle;
            dgvHistoryList.RowTemplate.Height = 32;
            dgvHistoryList.Columns.AddRange(new DataGridViewColumn[] { colHOrderId, colHCustomer, colHDate, colHStatus });
            dgvHistoryList.Dock = DockStyle.Fill;
            dgvHistoryList.Location = new Point(0, 67);
            dgvHistoryList.Margin = new Padding(3, 4, 3, 4);
            dgvHistoryList.MultiSelect = false;
            dgvHistoryList.Name = "dgvHistoryList";
            dgvHistoryList.ReadOnly = true;
            dgvHistoryList.RowHeadersVisible = false;
            dgvHistoryList.RowHeadersWidth = 51;
            dgvHistoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistoryList.Size = new Size(549, 944);
            dgvHistoryList.TabIndex = 1;
            // 
            // colHOrderId
            // 
            colHOrderId.FillWeight = 60F;
            colHOrderId.HeaderText = "MÃ ĐƠN";
            colHOrderId.MinimumWidth = 6;
            colHOrderId.Name = "colHOrderId";
            colHOrderId.ReadOnly = true;
            // 
            // colHCustomer
            // 
            colHCustomer.FillWeight = 120F;
            colHCustomer.HeaderText = "KHÁCH HÀNG";
            colHCustomer.MinimumWidth = 6;
            colHCustomer.Name = "colHCustomer";
            colHCustomer.ReadOnly = true;
            // 
            // colHDate
            // 
            colHDate.FillWeight = 90F;
            colHDate.HeaderText = "NGÀY DUYỆT";
            colHDate.MinimumWidth = 6;
            colHDate.Name = "colHDate";
            colHDate.ReadOnly = true;
            // 
            // colHStatus
            // 
            colHStatus.FillWeight = 80F;
            colHStatus.HeaderText = "TRẠNG THÁI";
            colHStatus.MinimumWidth = 6;
            colHStatus.Name = "colHStatus";
            colHStatus.ReadOnly = true;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(btnRefreshHistory);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(549, 67);
            pnlSearch.TabIndex = 0;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshHistory.BackColor = Color.FromArgb(238, 242, 255);
            btnRefreshHistory.Cursor = Cursors.Hand;
            btnRefreshHistory.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnRefreshHistory.FlatStyle = FlatStyle.Flat;
            btnRefreshHistory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefreshHistory.ForeColor = Color.FromArgb(79, 70, 229);
            btnRefreshHistory.Location = new Point(439, 14);
            btnRefreshHistory.Margin = new Padding(3, 4, 3, 4);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(100, 34);
            btnRefreshHistory.TabIndex = 2;
            btnRefreshHistory.Text = "Làm mới";
            btnRefreshHistory.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtSearch.Location = new Point(95, 16);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã đơn hoặc tên khách hàng...";
            txtSearch.Size = new Size(336, 30);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(15, 23, 42);
            lblSearch.Location = new Point(11, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // tlpHistoryDetails
            // 
            tlpHistoryDetails.ColumnCount = 1;
            tlpHistoryDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistoryDetails.Controls.Add(grpHistoryInfo, 0, 0);
            tlpHistoryDetails.Controls.Add(grpHistoryReason, 0, 1);
            tlpHistoryDetails.Controls.Add(grpHistoryProducts, 0, 2);
            tlpHistoryDetails.Dock = DockStyle.Fill;
            tlpHistoryDetails.Location = new Point(0, 0);
            tlpHistoryDetails.Margin = new Padding(3, 4, 3, 4);
            tlpHistoryDetails.Name = "tlpHistoryDetails";
            tlpHistoryDetails.RowCount = 3;
            tlpHistoryDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            tlpHistoryDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tlpHistoryDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistoryDetails.Size = new Size(918, 1011);
            tlpHistoryDetails.TabIndex = 0;
            // 
            // grpHistoryInfo
            // 
            grpHistoryInfo.Controls.Add(lblHistoryCustomerDetails);
            grpHistoryInfo.Dock = DockStyle.Fill;
            grpHistoryInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpHistoryInfo.Location = new Point(3, 4);
            grpHistoryInfo.Margin = new Padding(3, 4, 3, 4);
            grpHistoryInfo.Name = "grpHistoryInfo";
            grpHistoryInfo.Padding = new Padding(8);
            grpHistoryInfo.Size = new Size(912, 165);
            grpHistoryInfo.TabIndex = 0;
            grpHistoryInfo.TabStop = false;
            grpHistoryInfo.Text = "Thông tin chung đơn hàng";
            // 
            // lblHistoryCustomerDetails
            // 
            lblHistoryCustomerDetails.Dock = DockStyle.Fill;
            lblHistoryCustomerDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblHistoryCustomerDetails.ForeColor = Color.FromArgb(30, 41, 59);
            lblHistoryCustomerDetails.Location = new Point(8, 32);
            lblHistoryCustomerDetails.Name = "lblHistoryCustomerDetails";
            lblHistoryCustomerDetails.Size = new Size(896, 125);
            lblHistoryCustomerDetails.TabIndex = 0;
            lblHistoryCustomerDetails.Text = "Vui lòng chọn đơn hàng bên trái để xem thông tin...";
            // 
            // grpHistoryReason
            // 
            grpHistoryReason.Controls.Add(txtHistoryReason);
            grpHistoryReason.Dock = DockStyle.Fill;
            grpHistoryReason.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpHistoryReason.Location = new Point(3, 177);
            grpHistoryReason.Margin = new Padding(3, 4, 3, 4);
            grpHistoryReason.Name = "grpHistoryReason";
            grpHistoryReason.Padding = new Padding(8);
            grpHistoryReason.Size = new Size(912, 139);
            grpHistoryReason.TabIndex = 1;
            grpHistoryReason.TabStop = false;
            grpHistoryReason.Text = "Lý do hủy / Ghi chú phản hồi";
            // 
            // txtHistoryReason
            // 
            txtHistoryReason.Dock = DockStyle.Fill;
            txtHistoryReason.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtHistoryReason.Location = new Point(8, 32);
            txtHistoryReason.Margin = new Padding(3, 4, 3, 4);
            txtHistoryReason.Multiline = true;
            txtHistoryReason.Name = "txtHistoryReason";
            txtHistoryReason.ReadOnly = true;
            txtHistoryReason.ScrollBars = ScrollBars.Vertical;
            txtHistoryReason.Size = new Size(896, 99);
            txtHistoryReason.TabIndex = 0;
            // 
            // grpHistoryProducts
            // 
            grpHistoryProducts.Controls.Add(dgvHistoryProducts);
            grpHistoryProducts.Dock = DockStyle.Fill;
            grpHistoryProducts.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpHistoryProducts.Location = new Point(3, 324);
            grpHistoryProducts.Margin = new Padding(3, 4, 3, 4);
            grpHistoryProducts.Name = "grpHistoryProducts";
            grpHistoryProducts.Padding = new Padding(3, 4, 3, 4);
            grpHistoryProducts.Size = new Size(912, 683);
            grpHistoryProducts.TabIndex = 2;
            grpHistoryProducts.TabStop = false;
            grpHistoryProducts.Text = "Danh sách sản phẩm trong đơn";
            // 
            // dgvHistoryProducts
            // 
            dgvHistoryProducts.AllowUserToAddRows = false;
            dgvHistoryProducts.AllowUserToDeleteRows = false;
            dgvHistoryProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoryProducts.BackgroundColor = Color.White;
            dgvHistoryProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvHistoryProducts.ColumnHeadersHeight = 35;
            dgvHistoryProducts.DefaultCellStyle = dgvCellStyle;
            dgvHistoryProducts.RowTemplate.Height = 32;
            dgvHistoryProducts.Columns.AddRange(new DataGridViewColumn[] { colHPName, colHPQty, colHPPrice, colHPTotal });
            dgvHistoryProducts.Dock = DockStyle.Fill;
            dgvHistoryProducts.Location = new Point(3, 29);
            dgvHistoryProducts.Margin = new Padding(3, 4, 3, 4);
            dgvHistoryProducts.Name = "dgvHistoryProducts";
            dgvHistoryProducts.ReadOnly = true;
            dgvHistoryProducts.RowHeadersVisible = false;
            dgvHistoryProducts.RowHeadersWidth = 51;
            dgvHistoryProducts.Size = new Size(906, 650);
            dgvHistoryProducts.TabIndex = 0;
            // 
            // colHPName
            // 
            colHPName.FillWeight = 150F;
            colHPName.HeaderText = "TÊN SẢN PHẨM";
            colHPName.MinimumWidth = 6;
            colHPName.Name = "colHPName";
            colHPName.ReadOnly = true;
            // 
            // colHPQty
            // 
            colHPQty.HeaderText = "SỐ LƯỢNG";
            colHPQty.MinimumWidth = 6;
            colHPQty.Name = "colHPQty";
            colHPQty.ReadOnly = true;
            // 
            // colHPPrice
            // 
            colHPPrice.HeaderText = "ĐƠN GIÁ";
            colHPPrice.MinimumWidth = 6;
            colHPPrice.Name = "colHPPrice";
            colHPPrice.ReadOnly = true;
            // 
            // colHPTotal
            // 
            colHPTotal.HeaderText = "THÀNH TIỀN";
            colHPTotal.MinimumWidth = 6;
            colHPTotal.Name = "colHPTotal";
            colHPTotal.ReadOnly = true;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1486, 1055);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SupervisorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống duyệt đơn hàng & Tra cứu lịch sử";
            tabControlMain.ResumeLayout(false);
            tabPending.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlLeftHeader.ResumeLayout(false);
            tlpRightMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpMiddle.ResumeLayout(false);
            grpCreditInfo.ResumeLayout(false);
            grpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            grpReview.ResumeLayout(false);
            grpReview.PerformLayout();
            flpButtons.ResumeLayout(false);
            tabHistory.ResumeLayout(false);
            splitHistory.Panel1.ResumeLayout(false);
            splitHistory.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitHistory).EndInit();
            splitHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistoryList).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            tlpHistoryDetails.ResumeLayout(false);
            grpHistoryInfo.ResumeLayout(false);
            grpHistoryReason.ResumeLayout(false);
            grpHistoryReason.PerformLayout();
            grpHistoryProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistoryProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabHistory;

        // Tab Pending controls
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlLeftHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLeftTitle;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.TableLayoutPanel tlpRightMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.TableLayoutPanel tlpMiddle;
        private System.Windows.Forms.GroupBox grpCreditInfo;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.GroupBox grpReview;
        private System.Windows.Forms.Label lblWarningNote;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCreditPlaceholder;

        // Tab History controls
        private System.Windows.Forms.SplitContainer splitHistory;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.DataGridView dgvHistoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHStatus;
        private System.Windows.Forms.TableLayoutPanel tlpHistoryDetails;
        private System.Windows.Forms.GroupBox grpHistoryInfo;
        private System.Windows.Forms.Label lblHistoryCustomerDetails;
        private System.Windows.Forms.GroupBox grpHistoryReason;
        private System.Windows.Forms.TextBox txtHistoryReason;
        private System.Windows.Forms.GroupBox grpHistoryProducts;
        private System.Windows.Forms.DataGridView dgvHistoryProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHPQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHPTotal;
    }
}