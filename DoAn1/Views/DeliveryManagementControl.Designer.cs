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
            this.panelHeader.SuspendLayout();
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
            // DeliveryManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Name = "DeliveryManagementControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void BuildPendingView()
        {
            this.panelPendingTop = new System.Windows.Forms.Panel();
            this.txtSearchPending = new System.Windows.Forms.TextBox();
            this.btnRefreshPending = new System.Windows.Forms.Button();
            this.splitPending = new System.Windows.Forms.SplitContainer();
            this.lstPendingOrders = new System.Windows.Forms.ListBox();
            this.panelPendingRight = new System.Windows.Forms.Panel();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingCustInfo = new System.Windows.Forms.Label();
            this.btnStartDelivery = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).BeginInit();
            this.splitPending.Panel1.SuspendLayout();
            this.splitPending.Panel2.SuspendLayout();
            this.splitPending.SuspendLayout();
            this.panelPendingTop.SuspendLayout();
            this.panelPendingRight.SuspendLayout();

            this.splitPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPending.Location = new System.Drawing.Point(0, 45);
            this.splitPending.Name = "splitPending";
            this.splitPending.SplitterDistance = 220;

            this.panelPendingTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelPendingTop.Controls.Add(this.txtSearchPending);
            this.panelPendingTop.Controls.Add(this.btnRefreshPending);
            this.panelPendingTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPendingTop.Location = new System.Drawing.Point(0, 0);
            this.panelPendingTop.Name = "panelPendingTop";
            this.panelPendingTop.Size = new System.Drawing.Size(220, 36);

            this.txtSearchPending.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSearchPending.Location = new System.Drawing.Point(6, 6);
            this.txtSearchPending.Name = "txtSearchPending";
            this.txtSearchPending.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchPending.Size = new System.Drawing.Size(130, 23);
            this.txtSearchPending.TextChanged += new System.EventHandler(this.TxtSearchPending_TextChanged);

            this.btnRefreshPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPending.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshPending.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPending.Location = new System.Drawing.Point(141, 5);
            this.btnRefreshPending.Name = "btnRefreshPending";
            this.btnRefreshPending.Size = new System.Drawing.Size(68, 25);
            this.btnRefreshPending.Text = "Làm mới";
            this.btnRefreshPending.Click += new System.EventHandler(this.BtnRefreshPending_Click);

            this.lstPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPendingOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstPendingOrders.ItemHeight = 22;
            this.lstPendingOrders.Location = new System.Drawing.Point(0, 36);
            this.lstPendingOrders.Name = "lstPendingOrders";
            this.lstPendingOrders.Size = new System.Drawing.Size(220, 519);
            this.lstPendingOrders.SelectedIndexChanged += new System.EventHandler(this.LstPendingOrders_SelectedIndexChanged);

            this.splitPending.Panel1.Controls.Add(this.lstPendingOrders);
            this.splitPending.Panel1.Controls.Add(this.panelPendingTop);

            this.panelPendingRight.BackColor = System.Drawing.Color.White;
            this.panelPendingRight.Controls.Add(this.lblPendingCustInfo);
            this.panelPendingRight.Controls.Add(this.lblPendingTitle);
            this.panelPendingRight.Controls.Add(this.btnStartDelivery);
            this.panelPendingRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendingRight.Location = new System.Drawing.Point(0, 0);
            this.panelPendingRight.Name = "panelPendingRight";
            this.panelPendingRight.Padding = new System.Windows.Forms.Padding(15);

            this.lblPendingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(696, 30);
            this.lblPendingTitle.Text = "Thông tin vận chuyển đơn hàng: ---";

            this.lblPendingCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingCustInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPendingCustInfo.Location = new System.Drawing.Point(15, 45);
            this.lblPendingCustInfo.Name = "lblPendingCustInfo";
            this.lblPendingCustInfo.Size = new System.Drawing.Size(696, 450);
            this.lblPendingCustInfo.Text = "Chọn đơn hàng bên trái để xem thông tin.";

            this.btnStartDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnStartDelivery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartDelivery.ForeColor = System.Drawing.Color.White;
            this.btnStartDelivery.Location = new System.Drawing.Point(15, 498);
            this.btnStartDelivery.Name = "btnStartDelivery";
            this.btnStartDelivery.Size = new System.Drawing.Size(696, 42);
            this.btnStartDelivery.Text = "🚀 BẮT ĐẦU ĐI GIAO HÀNG";
            this.btnStartDelivery.Click += new System.EventHandler(this.BtnStartDelivery_Click);

            this.splitPending.Panel2.Controls.Add(this.panelPendingRight);
            this.Controls.Add(this.splitPending);
            this.panelHeader.SendToBack();

            this.splitPending.Panel1.ResumeLayout(false);
            this.splitPending.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).EndInit();
            this.splitPending.ResumeLayout(false);
            this.panelPendingTop.ResumeLayout(false);
            this.panelPendingTop.PerformLayout();
            this.panelPendingRight.ResumeLayout(false);
        }

        private void BuildDeliveringView()
        {
            this.panelDeliveringTop = new System.Windows.Forms.Panel();
            this.txtSearchDelivering = new System.Windows.Forms.TextBox();
            this.btnRefreshDelivering = new System.Windows.Forms.Button();
            this.splitDelivering = new System.Windows.Forms.SplitContainer();
            this.lstDeliveringOrders = new System.Windows.Forms.ListBox();
            this.panelDeliveringRight = new System.Windows.Forms.Panel();
            this.lblDeliveringTitle = new System.Windows.Forms.Label();
            this.lblDeliveringCustInfo = new System.Windows.Forms.Label();
            this.lblReturnReasonHeader = new System.Windows.Forms.Label();
            this.txtReturnReason = new System.Windows.Forms.TextBox();
            this.btnConfirmSuccess = new System.Windows.Forms.Button();
            this.btnConfirmReturn = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitDelivering)).BeginInit();
            this.splitDelivering.Panel1.SuspendLayout();
            this.splitDelivering.Panel2.SuspendLayout();
            this.splitDelivering.SuspendLayout();
            this.panelDeliveringTop.SuspendLayout();
            this.panelDeliveringRight.SuspendLayout();

            this.splitDelivering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDelivering.Location = new System.Drawing.Point(0, 45);
            this.splitDelivering.Name = "splitDelivering";
            this.splitDelivering.SplitterDistance = 220;

            this.panelDeliveringTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelDeliveringTop.Controls.Add(this.txtSearchDelivering);
            this.panelDeliveringTop.Controls.Add(this.btnRefreshDelivering);
            this.panelDeliveringTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeliveringTop.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveringTop.Name = "panelDeliveringTop";
            this.panelDeliveringTop.Size = new System.Drawing.Size(220, 36);

            this.txtSearchDelivering.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSearchDelivering.Location = new System.Drawing.Point(6, 6);
            this.txtSearchDelivering.Name = "txtSearchDelivering";
            this.txtSearchDelivering.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchDelivering.Size = new System.Drawing.Size(130, 23);
            this.txtSearchDelivering.TextChanged += new System.EventHandler(this.TxtSearchDelivering_TextChanged);

            this.btnRefreshDelivering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshDelivering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDelivering.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshDelivering.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDelivering.Location = new System.Drawing.Point(141, 5);
            this.btnRefreshDelivering.Name = "btnRefreshDelivering";
            this.btnRefreshDelivering.Size = new System.Drawing.Size(68, 25);
            this.btnRefreshDelivering.Text = "Làm mới";
            this.btnRefreshDelivering.Click += new System.EventHandler(this.BtnRefreshDelivering_Click);

            this.lstDeliveringOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDeliveringOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstDeliveringOrders.ItemHeight = 22;
            this.lstDeliveringOrders.Location = new System.Drawing.Point(0, 36);
            this.lstDeliveringOrders.Name = "lstDeliveringOrders";
            this.lstDeliveringOrders.Size = new System.Drawing.Size(220, 519);
            this.lstDeliveringOrders.SelectedIndexChanged += new System.EventHandler(this.LstDeliveringOrders_SelectedIndexChanged);

            this.splitDelivering.Panel1.Controls.Add(this.lstDeliveringOrders);
            this.splitDelivering.Panel1.Controls.Add(this.panelDeliveringTop);

            this.panelDeliveringRight.BackColor = System.Drawing.Color.White;
            this.panelDeliveringRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliveringRight.Location = new System.Drawing.Point(0, 0);
            this.panelDeliveringRight.Name = "panelDeliveringRight";
            this.panelDeliveringRight.Padding = new System.Windows.Forms.Padding(15);

            this.lblDeliveringTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeliveringTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeliveringTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDeliveringTitle.Name = "lblDeliveringTitle";
            this.lblDeliveringTitle.Size = new System.Drawing.Size(696, 30);
            this.lblDeliveringTitle.Text = "Thông tin đơn đang giao: ---";

            this.lblDeliveringCustInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeliveringCustInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDeliveringCustInfo.Location = new System.Drawing.Point(15, 45);
            this.lblDeliveringCustInfo.Name = "lblDeliveringCustInfo";
            this.lblDeliveringCustInfo.Size = new System.Drawing.Size(696, 380);
            this.lblDeliveringCustInfo.Text = "Chọn đơn hàng bên trái để cập nhật kết quả giao hàng.";

            this.lblReturnReasonHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReturnReasonHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnReasonHeader.Location = new System.Drawing.Point(15, 425);
            this.lblReturnReasonHeader.Name = "lblReturnReasonHeader";
            this.lblReturnReasonHeader.Size = new System.Drawing.Size(696, 22);
            this.lblReturnReasonHeader.Text = "Lý do khách trả hàng (nếu không giao thành công):";

            this.txtReturnReason.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReturnReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReturnReason.Location = new System.Drawing.Point(15, 447);
            this.txtReturnReason.Multiline = true;
            this.txtReturnReason.Name = "txtReturnReason";
            this.txtReturnReason.PlaceholderText = "Nhập lý do trả hàng...";
            this.txtReturnReason.Size = new System.Drawing.Size(696, 45);

            System.Windows.Forms.Panel pBtns = new System.Windows.Forms.Panel();
            pBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            pBtns.Height = 45;
            pBtns.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);

            this.btnConfirmSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnConfirmSuccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfirmSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSuccess.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmSuccess.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSuccess.Location = new System.Drawing.Point(0, 8);
            this.btnConfirmSuccess.Name = "btnConfirmSuccess";
            this.btnConfirmSuccess.Size = new System.Drawing.Size(200, 37);
            this.btnConfirmSuccess.Text = "✔ GIAO THÀNH CÔNG";
            this.btnConfirmSuccess.Click += new System.EventHandler(this.BtnConfirmSuccess_Click);

            this.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnConfirmReturn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmReturn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReturn.Location = new System.Drawing.Point(536, 8);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(160, 37);
            this.btnConfirmReturn.Text = "✖ KHÁCH TRẢ";
            this.btnConfirmReturn.Click += new System.EventHandler(this.BtnConfirmReturn_Click);

            pBtns.Controls.Add(this.btnConfirmSuccess);
            pBtns.Controls.Add(this.btnConfirmReturn);

            this.panelDeliveringRight.Controls.Add(this.lblDeliveringCustInfo);
            this.panelDeliveringRight.Controls.Add(this.lblDeliveringTitle);
            this.panelDeliveringRight.Controls.Add(this.lblReturnReasonHeader);
            this.panelDeliveringRight.Controls.Add(this.txtReturnReason);
            this.panelDeliveringRight.Controls.Add(pBtns);

            this.splitDelivering.Panel2.Controls.Add(this.panelDeliveringRight);
            this.Controls.Add(this.splitDelivering);
            this.panelHeader.SendToBack();

            this.splitDelivering.Panel1.ResumeLayout(false);
            this.splitDelivering.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDelivering)).EndInit();
            this.splitDelivering.ResumeLayout(false);
            this.panelDeliveringTop.ResumeLayout(false);
            this.panelDeliveringTop.PerformLayout();
            this.panelDeliveringRight.ResumeLayout(false);
            this.panelDeliveringRight.PerformLayout();
        }

        private void BuildHistoryView()
        {
            this.panelHistoryTop = new System.Windows.Forms.Panel();
            this.txtSearchHistory = new System.Windows.Forms.TextBox();
            this.btnRefreshHistory = new System.Windows.Forms.Button();
            this.splitHistory = new System.Windows.Forms.SplitContainer();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.panelHistoryRight = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lblHistoryDetails = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).BeginInit();
            this.splitHistory.Panel1.SuspendLayout();
            this.splitHistory.Panel2.SuspendLayout();
            this.splitHistory.SuspendLayout();
            this.panelHistoryTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panelHistoryRight.SuspendLayout();

            this.splitHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHistory.Location = new System.Drawing.Point(0, 45);
            this.splitHistory.Name = "splitHistory";
            this.splitHistory.SplitterDistance = 380;

            this.panelHistoryTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelHistoryTop.Controls.Add(this.txtSearchHistory);
            this.panelHistoryTop.Controls.Add(this.btnRefreshHistory);
            this.panelHistoryTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistoryTop.Location = new System.Drawing.Point(0, 0);
            this.panelHistoryTop.Name = "panelHistoryTop";
            this.panelHistoryTop.Size = new System.Drawing.Size(380, 40);

            this.txtSearchHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchHistory.Location = new System.Drawing.Point(10, 6);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.PlaceholderText = "Tìm mã đơn, tên khách...";
            this.txtSearchHistory.Size = new System.Drawing.Size(250, 27);
            this.txtSearchHistory.TextChanged += new System.EventHandler(this.TxtSearchHistory_TextChanged);

            this.btnRefreshHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshHistory.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHistory.Location = new System.Drawing.Point(265, 5);
            this.btnRefreshHistory.Name = "btnRefreshHistory";
            this.btnRefreshHistory.Size = new System.Drawing.Size(85, 28);
            this.btnRefreshHistory.Text = "Làm mới";
            this.btnRefreshHistory.Click += new System.EventHandler(this.BtnRefreshHistory_Click);

            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 40);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(380, 515);
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.DgvHistory_SelectionChanged);

            this.splitHistory.Panel1.Controls.Add(this.dgvHistory);
            this.splitHistory.Panel1.Controls.Add(this.panelHistoryTop);

            this.panelHistoryRight.BackColor = System.Drawing.Color.White;
            this.panelHistoryRight.Controls.Add(this.lblHistoryDetails);
            this.panelHistoryRight.Controls.Add(this.lblHistoryTitle);
            this.panelHistoryRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoryRight.Location = new System.Drawing.Point(0, 0);
            this.panelHistoryRight.Name = "panelHistoryRight";
            this.panelHistoryRight.Padding = new System.Windows.Forms.Padding(15);

            this.lblHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(536, 30);
            this.lblHistoryTitle.Text = "Chi tiết lịch sử đơn hàng:";

            this.lblHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHistoryDetails.Location = new System.Drawing.Point(15, 45);
            this.lblHistoryDetails.Name = "lblHistoryDetails";
            this.lblHistoryDetails.Size = new System.Drawing.Size(536, 495);
            this.lblHistoryDetails.Text = "Chọn đơn hàng bên trái để xem kết quả vận chuyển.";

            this.splitHistory.Panel2.Controls.Add(this.panelHistoryRight);
            this.Controls.Add(this.splitHistory);
            this.panelHeader.SendToBack();

            this.splitHistory.Panel1.ResumeLayout(false);
            this.splitHistory.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHistory)).EndInit();
            this.splitHistory.ResumeLayout(false);
            this.panelHistoryTop.ResumeLayout(false);
            this.panelHistoryTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panelHistoryRight.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
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
