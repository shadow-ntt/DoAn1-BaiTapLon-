namespace DoAn1.Views
{
    partial class DeliveryManagementControl
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
            this.tabPending = new System.Windows.Forms.TabPage();
            this.splitPending = new System.Windows.Forms.SplitContainer();
            this.panelPendingTop = new System.Windows.Forms.Panel();
            this.txtSearchPending = new System.Windows.Forms.TextBox();
            this.btnRefreshPending = new System.Windows.Forms.Button();
            this.lstPendingOrders = new System.Windows.Forms.ListBox();
            this.panelPendingRight = new System.Windows.Forms.Panel();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingCustInfo = new System.Windows.Forms.Label();
            this.btnStartDelivery = new System.Windows.Forms.Button();
            this.tabDelivering = new System.Windows.Forms.TabPage();
            this.splitDelivering = new System.Windows.Forms.SplitContainer();
            this.panelDeliveringTop = new System.Windows.Forms.Panel();
            this.txtSearchDelivering = new System.Windows.Forms.TextBox();
            this.btnRefreshDelivering = new System.Windows.Forms.Button();
            this.lstDeliveringOrders = new System.Windows.Forms.ListBox();
            this.panelDeliveringRight = new System.Windows.Forms.Panel();
            this.lblDeliveringTitle = new System.Windows.Forms.Label();
            this.lblDeliveringCustInfo = new System.Windows.Forms.Label();
            this.lblReturnReasonHeader = new System.Windows.Forms.Label();
            this.txtReturnReason = new System.Windows.Forms.TextBox();
            this.panelDeliveringBtns = new System.Windows.Forms.Panel();
            this.btnConfirmSuccess = new System.Windows.Forms.Button();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.splitHistory = new System.Windows.Forms.SplitContainer();
            this.panelHistoryTop = new System.Windows.Forms.Panel();
            this.txtSearchHistory = new System.Windows.Forms.TextBox();
            this.btnRefreshHistory = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.panelHistoryRight = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lblHistoryDetails = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).BeginInit();
            this.splitPending.Panel1.SuspendLayout();
            this.splitPending.Panel2.SuspendLayout();
            this.splitPending.SuspendLayout();
            this.panelPendingTop.SuspendLayout();
            this.panelPendingRight.SuspendLayout();
            this.tabDelivering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDelivering)).BeginInit();
            this.splitDelivering.Panel1.SuspendLayout();
            this.splitDelivering.Panel2.SuspendLayout();
            this.splitDelivering.SuspendLayout();
            this.panelDeliveringTop.SuspendLayout();
            this.panelDeliveringRight.SuspendLayout();
            this.panelDeliveringBtns.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).BeginInit();
            this.splitHistory.Panel1.SuspendLayout();
            this.splitHistory.Panel2.SuspendLayout();
            this.splitHistory.SuspendLayout();
            this.panelHistoryTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelHistoryRight.SuspendLayout();
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
            this.lblHeader.Text = "QUẢN LÝ GIAO HÀNG";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPending);
            this.tabControlMain.Controls.Add(this.tabDelivering);
            this.tabControlMain.Controls.Add(this.tabHistory);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.tabControlMain.Location = new System.Drawing.Point(0, 45);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(950, 555);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPending
            // 
            this.tabPending.Controls.Add(this.splitPending);
            this.tabPending.Location = new System.Drawing.Point(4, 26);
            this.tabPending.Name = "tabPending";
            this.tabPending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPending.Size = new System.Drawing.Size(942, 525);
            this.tabPending.TabIndex = 0;
            this.tabPending.Text = "Chờ nhận giao";
            this.tabPending.UseVisualStyleBackColor = true;
            // 
            // splitPending
            // 
            this.splitPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPending.Location = new System.Drawing.Point(3, 3);
            this.splitPending.Name = "splitPending";
            // 
            // splitPending.Panel1
            // 
            this.splitPending.Panel1.Controls.Add(this.lstPendingOrders);
            this.splitPending.Panel1.Controls.Add(this.panelPendingTop);
            // 
            // splitPending.Panel2
            // 
            this.splitPending.Panel2.Controls.Add(this.panelPendingRight);
            this.splitPending.Size = new System.Drawing.Size(936, 519);
            this.splitPending.SplitterDistance = 280;
            this.splitPending.TabIndex = 0;
            // 
            // panelPendingTop
            // 
            this.panelPendingTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelPendingTop.Controls.Add(this.txtSearchPending);
            this.panelPendingTop.Controls.Add(this.btnRefreshPending);
            this.panelPendingTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPendingTop.Location = new System.Drawing.Point(0, 0);
            this.panelPendingTop.Name = "panelPendingTop";
            this.panelPendingTop.Size = new System.Drawing.Size(280, 40);
            this.panelPendingTop.TabIndex = 0;
            // 
            // txtSearchPending
            // 
            this.txtSearchPending.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPending.Location = new System.Drawing.Point(6, 8);
            this.txtSearchPending.Name = "txtSearchPending";
            this.txtSearchPending.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchPending.Size = new System.Drawing.Size(180, 23);
            this.txtSearchPending.TabIndex = 0;
            // 
            // btnRefreshPending
            // 
            this.btnRefreshPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPending.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshPending.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPending.Location = new System.Drawing.Point(192, 7);
            this.btnRefreshPending.Name = "btnRefreshPending";
            this.btnRefreshPending.Size = new System.Drawing.Size(80, 25);
            this.btnRefreshPending.TabIndex = 1;
            this.btnRefreshPending.Text = "Làm mới";
            this.btnRefreshPending.UseVisualStyleBackColor = false;
            // 
            // lstPendingOrders
            // 
            this.lstPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPendingOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstPendingOrders.ItemHeight = 17;
            this.lstPendingOrders.Location = new System.Drawing.Point(0, 40);
            this.lstPendingOrders.Name = "lstPendingOrders";
            this.lstPendingOrders.Size = new System.Drawing.Size(280, 479);
            this.lstPendingOrders.TabIndex = 1;
            // 
            // panelPendingRight
            // 
            this.panelPendingRight.BackColor = System.Drawing.Color.White;
            this.panelPendingRight.Controls.Add(this.lblPendingCustInfo);
            this.panelPendingRight.Controls.Add(this.lblPendingTitle);
            this.panelPendingRight.Controls.Add(this.btnStartDelivery);
            this.panelPendingRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendingRight.Location = new System.Drawing.Point(0, 0);
            this.panelPendingRight.Name = "panelPendingRight";
            this.panelPendingRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelPendingRight.Size = new System.Drawing.Size(652, 519);
            this.panelPendingRight.TabIndex = 0;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(622, 30);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "Thông tin vận chuyển đơn hàng: ---";
            // 
            // lblPendingCustInfo
            // 
            this.lblPendingCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingCustInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPendingCustInfo.Location = new System.Drawing.Point(15, 45);
            this.lblPendingCustInfo.Name = "lblPendingCustInfo";
            this.lblPendingCustInfo.Size = new System.Drawing.Size(622, 417);
            this.lblPendingCustInfo.TabIndex = 1;
            this.lblPendingCustInfo.Text = "Chọn đơn hàng bên trái để xem thông tin.";
            // 
            // btnStartDelivery
            // 
            this.btnStartDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnStartDelivery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartDelivery.ForeColor = System.Drawing.Color.White;
            this.btnStartDelivery.Location = new System.Drawing.Point(15, 462);
            this.btnStartDelivery.Name = "btnStartDelivery";
            this.btnStartDelivery.Size = new System.Drawing.Size(622, 42);
            this.btnStartDelivery.TabIndex = 2;
            this.btnStartDelivery.Text = "🚀 BẮT ĐẦU ĐI GIAO HÀNG";
            this.btnStartDelivery.UseVisualStyleBackColor = false;
            // 
            // tabDelivering
            // 
            this.tabDelivering.Controls.Add(this.splitDelivering);
            this.tabDelivering.Location = new System.Drawing.Point(4, 26);
            this.tabDelivering.Name = "tabDelivering";
            this.tabDelivering.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivering.Size = new System.Drawing.Size(942, 525);
            this.tabDelivering.TabIndex = 1;
            this.tabDelivering.Text = "Đang giao hàng";
            this.tabDelivering.UseVisualStyleBackColor = true;
            // 
            // splitDelivering
            // 
            this.splitDelivering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDelivering.Location = new System.Drawing.Point(3, 3);
            this.splitDelivering.Name = "splitDelivering";
            // 
            // splitDelivering.Panel1
            // 
            this.splitDelivering.Panel1.Controls.Add(this.lstDeliveringOrders);
            this.splitDelivering.Panel1.Controls.Add(this.panelDeliveringTop);
            // 
            // splitDelivering.Panel2
            // 
            this.splitDelivering.Panel2.Controls.Add(this.panelDeliveringRight);
            this.splitDelivering.Size = new System.Drawing.Size(936, 519);
            this.splitDelivering.SplitterDistance = 280;
            this.splitDelivering.TabIndex = 0;
            // 
            // panelDeliveringTop
            // 
            this.panelDeliveringTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelDeliveringTop.Controls.Add(this.txtSearchDelivering);
            this.panelDeliveringTop.Controls.Add(this.btnRefreshDelivering);
            this.panelDeliveringTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeliveringTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveringTop.Name = "panelDeliveringTop";
            this.panelDeliveringTop.Size = new System.Drawing.Size(280, 40);
            this.panelDeliveringTop.TabIndex = 0;
            // 
            // txtSearchDelivering
            // 
            this.txtSearchDelivering.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchDelivering.Location = new System.Drawing.Point(6, 8);
            this.txtSearchDelivering.Name = "txtSearchDelivering";
            this.txtSearchDelivering.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchDelivering.Size = new System.Drawing.Size(180, 23);
            this.txtSearchDelivering.TabIndex = 0;
            // 
            // btnRefreshDelivering
            // 
            this.btnRefreshDelivering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshDelivering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDelivering.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshDelivering.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDelivering.Location = new System.Drawing.Point(192, 7);
            this.btnRefreshDelivering.Name = "btnRefreshDelivering";
            this.btnRefreshDelivering.Size = new System.Drawing.Size(80, 25);
            this.btnRefreshDelivering.TabIndex = 1;
            this.btnRefreshDelivering.Text = "Làm mới";
            this.btnRefreshDelivering.UseVisualStyleBackColor = false;
            // 
            // lstDeliveringOrders
            // 
            this.lstDeliveringOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDeliveringOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstDeliveringOrders.ItemHeight = 17;
            this.lstDeliveringOrders.Location = new System.Drawing.Point(0, 40);
            this.lstDeliveringOrders.Name = "lstDeliveringOrders";
            this.lstDeliveringOrders.Size = new System.Drawing.Size(280, 479);
            this.lstDeliveringOrders.TabIndex = 1;
            // 
            // panelDeliveringRight
            // 
            this.panelDeliveringRight.BackColor = System.Drawing.Color.White;
            this.panelDeliveringRight.Controls.Add(this.lblDeliveringCustInfo);
            this.panelDeliveringRight.Controls.Add(this.lblDeliveringTitle);
            this.panelDeliveringRight.Controls.Add(this.lblReturnReasonHeader);
            this.panelDeliveringRight.Controls.Add(this.txtReturnReason);
            this.panelDeliveringRight.Controls.Add(this.panelDeliveringBtns);
            this.panelDeliveringRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliveringRight.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveringRight.Name = "panelDeliveringRight";
            this.panelDeliveringRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelDeliveringRight.Size = new System.Drawing.Size(652, 519);
            this.panelDeliveringRight.TabIndex = 0;
            // 
            // lblDeliveringTitle
            // 
            this.lblDeliveringTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeliveringTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeliveringTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDeliveringTitle.Name = "lblDeliveringTitle";
            this.lblDeliveringTitle.Size = new System.Drawing.Size(622, 30);
            this.lblDeliveringTitle.TabIndex = 0;
            this.lblDeliveringTitle.Text = "Thông tin đơn đang giao: ---";
            // 
            // lblDeliveringCustInfo
            // 
            this.lblDeliveringCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeliveringCustInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDeliveringCustInfo.Location = new System.Drawing.Point(15, 45);
            this.lblDeliveringCustInfo.Name = "lblDeliveringCustInfo";
            this.lblDeliveringCustInfo.Size = new System.Drawing.Size(622, 335);
            this.lblDeliveringCustInfo.TabIndex = 1;
            this.lblDeliveringCustInfo.Text = "Chọn đơn hàng bên trái để cập nhật kết quả giao hàng.";
            // 
            // lblReturnReasonHeader
            // 
            this.lblReturnReasonHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReturnReasonHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnReasonHeader.Location = new System.Drawing.Point(15, 380);
            this.lblReturnReasonHeader.Name = "lblReturnReasonHeader";
            this.lblReturnReasonHeader.Size = new System.Drawing.Size(622, 22);
            this.lblReturnReasonHeader.TabIndex = 2;
            this.lblReturnReasonHeader.Text = "Lý do khách trả hàng (nếu không giao thành công):";
            // 
            // txtReturnReason
            // 
            this.txtReturnReason.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReturnReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReturnReason.Location = new System.Drawing.Point(15, 402);
            this.txtReturnReason.Multiline = true;
            this.txtReturnReason.Name = "txtReturnReason";
            this.txtReturnReason.PlaceholderText = "Nhập lý do trả hàng...";
            this.txtReturnReason.Size = new System.Drawing.Size(622, 50);
            this.txtReturnReason.TabIndex = 3;
            // 
            // panelDeliveringBtns
            // 
            this.panelDeliveringBtns.Controls.Add(this.btnConfirmSuccess);
            this.panelDeliveringBtns.Controls.Add(this.btnConfirmReturn);
            this.panelDeliveringBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeliveringBtns.Location = new System.Drawing.Point(15, 452);
            this.panelDeliveringBtns.Name = "panelDeliveringBtns";
            this.panelDeliveringBtns.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelDeliveringBtns.Size = new System.Drawing.Size(622, 52);
            this.panelDeliveringBtns.TabIndex = 4;
            // 
            // btnConfirmSuccess
            // 
            this.btnConfirmSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnConfirmSuccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfirmSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSuccess.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSuccess.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSuccess.Location = new System.Drawing.Point(0, 8);
            this.btnConfirmSuccess.Name = "btnConfirmSuccess";
            this.btnConfirmSuccess.Size = new System.Drawing.Size(200, 44);
            this.btnConfirmSuccess.TabIndex = 0;
            this.btnConfirmSuccess.Text = "✔ GIAO THÀNH CÔNG";
            this.btnConfirmSuccess.UseVisualStyleBackColor = false;
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnConfirmReturn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmReturn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReturn.Location = new System.Drawing.Point(462, 8);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(160, 44);
            this.btnConfirmReturn.TabIndex = 1;
            this.btnConfirmReturn.Text = "✖ KHÁCH TRẢ";
            this.btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.splitHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 26);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(942, 525);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "Lịch sử giao hàng";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // splitHistory
            // 
            this.splitHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHistory.Location = new System.Drawing.Point(3, 3);
            this.splitHistory.Name = "splitHistory";
            // 
            // splitHistory.Panel1
            // 
            this.splitHistory.Panel1.Controls.Add(this.dgvHistory);
            this.splitHistory.Panel1.Controls.Add(this.panelHistoryTop);
            // 
            // splitHistory.Panel2
            // 
            this.splitHistory.Panel2.Controls.Add(this.panelHistoryRight);
            this.splitHistory.Size = new System.Drawing.Size(936, 519);
            this.splitHistory.SplitterDistance = 420;
            this.splitHistory.TabIndex = 0;
            // 
            // panelHistoryTop
            // 
            this.panelHistoryTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelHistoryTop.Controls.Add(this.txtSearchHistory);
            this.panelHistoryTop.Controls.Add(this.btnRefreshHistory);
            this.panelHistoryTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistoryTop.Location = new System.Drawing.Point(0, 0);
            this.panelHistoryTop.Name = "panelHistoryTop";
            this.panelHistoryTop.Size = new System.Drawing.Size(420, 40);
            this.panelHistoryTop.TabIndex = 0;
            // 
            // txtSearchHistory
            // 
            this.txtSearchHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchHistory.Location = new System.Drawing.Point(8, 8);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.PlaceholderText = "Tìm mã đơn, tên khách...";
            this.txtSearchHistory.Size = new System.Drawing.Size(280, 23);
            this.txtSearchHistory.TabIndex = 0;
            // 
            // btnRefreshHistory
            // 
            this.btnRefreshHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHistory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshHistory.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHistory.Location = new System.Drawing.Point(300, 7);
            this.btnRefreshHistory.Name = "btnRefreshHistory";
            this.btnRefreshHistory.Size = new System.Drawing.Size(85, 25);
            this.btnRefreshHistory.TabIndex = 1;
            this.btnRefreshHistory.Text = "Làm mới";
            this.btnRefreshHistory.UseVisualStyleBackColor = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 40);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(420, 479);
            this.dgvHistory.TabIndex = 1;
            // 
            // panelHistoryRight
            // 
            this.panelHistoryRight.BackColor = System.Drawing.Color.White;
            this.panelHistoryRight.Controls.Add(this.lblHistoryDetails);
            this.panelHistoryRight.Controls.Add(this.lblHistoryTitle);
            this.panelHistoryRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoryRight.Location = new System.Drawing.Point(0, 0);
            this.panelHistoryRight.Name = "panelHistoryRight";
            this.panelHistoryRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelHistoryRight.Size = new System.Drawing.Size(512, 519);
            this.panelHistoryRight.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(482, 30);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Chi tiết lịch sử đơn hàng:";
            // 
            // lblHistoryDetails
            // 
            this.lblHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHistoryDetails.Location = new System.Drawing.Point(15, 45);
            this.lblHistoryDetails.Name = "lblHistoryDetails";
            this.lblHistoryDetails.Size = new System.Drawing.Size(482, 459);
            this.lblHistoryDetails.TabIndex = 1;
            this.lblHistoryDetails.Text = "Chọn đơn hàng bên trái để xem kết quả vận chuyển.";
            // 
            // DeliveryManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "DeliveryManagementControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPending.ResumeLayout(false);
            this.splitPending.Panel1.ResumeLayout(false);
            this.splitPending.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).EndInit();
            this.splitPending.ResumeLayout(false);
            this.panelPendingTop.ResumeLayout(false);
            this.panelPendingTop.PerformLayout();
            this.panelPendingRight.ResumeLayout(false);
            this.tabDelivering.ResumeLayout(false);
            this.splitDelivering.Panel1.ResumeLayout(false);
            this.splitDelivering.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDelivering)).EndInit();
            this.splitDelivering.ResumeLayout(false);
            this.panelDeliveringTop.ResumeLayout(false);
            this.panelDeliveringTop.PerformLayout();
            this.panelDeliveringRight.ResumeLayout(false);
            this.panelDeliveringRight.PerformLayout();
            this.panelDeliveringBtns.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.splitHistory.Panel1.ResumeLayout(false);
            this.splitHistory.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).EndInit();
            this.splitHistory.ResumeLayout(false);
            this.panelHistoryTop.ResumeLayout(false);
            this.panelHistoryTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelHistoryRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabDelivering;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Panel panelPendingTop;
        private System.Windows.Forms.TextBox txtSearchPending;
        private System.Windows.Forms.Button btnRefreshPending;
        private System.Windows.Forms.SplitContainer splitPending;
        private System.Windows.Forms.ListBox lstPendingOrders;
        private System.Windows.Forms.Panel panelPendingRight;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingCustInfo;
        private System.Windows.Forms.Button btnStartDelivery;
        private System.Windows.Forms.Panel panelDeliveringTop;
        private System.Windows.Forms.TextBox txtSearchDelivering;
        private System.Windows.Forms.Button btnRefreshDelivering;
        private System.Windows.Forms.SplitContainer splitDelivering;
        private System.Windows.Forms.ListBox lstDeliveringOrders;
        private System.Windows.Forms.Panel panelDeliveringRight;
        private System.Windows.Forms.Label lblDeliveringTitle;
        private System.Windows.Forms.Label lblDeliveringCustInfo;
        private System.Windows.Forms.Label lblReturnReasonHeader;
        private System.Windows.Forms.TextBox txtReturnReason;
        private System.Windows.Forms.Panel panelDeliveringBtns;
        private System.Windows.Forms.Button btnConfirmSuccess;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.Panel panelHistoryTop;
        private System.Windows.Forms.TextBox txtSearchHistory;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.SplitContainer splitHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel panelHistoryRight;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Label lblHistoryDetails;
    }
}
