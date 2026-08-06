namespace DoAn1.Views
{
    partial class OrderInspectionControl
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
            this.panelPendingTop = new System.Windows.Forms.Panel();
            this.txtSearchPending = new System.Windows.Forms.TextBox();
            this.btnRefreshPending = new System.Windows.Forms.Button();
            this.splitPending = new System.Windows.Forms.SplitContainer();
            this.lstPendingOrders = new System.Windows.Forms.ListBox();
            this.panelPendingRight = new System.Windows.Forms.Panel();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCreditWarning = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblNotesHeader = new System.Windows.Forms.Label();
            this.txtRejectNotes = new System.Windows.Forms.TextBox();
            this.panelPendingButtons = new System.Windows.Forms.Panel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelPendingTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).BeginInit();
            this.splitPending.Panel1.SuspendLayout();
            this.splitPending.Panel2.SuspendLayout();
            this.splitPending.SuspendLayout();
            this.panelPendingRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelPendingButtons.SuspendLayout();
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
            this.lblHeader.Text = "KIỂM TRA & PHÊ DUYỆT ĐƠN HÀNG";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitPending
            // 
            this.splitPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPending.Location = new System.Drawing.Point(0, 45);
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
            this.splitPending.Size = new System.Drawing.Size(950, 555);
            this.splitPending.SplitterDistance = 220;
            this.splitPending.TabIndex = 1;
            // 
            // panelPendingTop
            // 
            this.panelPendingTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelPendingTop.Controls.Add(this.txtSearchPending);
            this.panelPendingTop.Controls.Add(this.btnRefreshPending);
            this.panelPendingTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPendingTop.Location = new System.Drawing.Point(0, 0);
            this.panelPendingTop.Name = "panelPendingTop";
            this.panelPendingTop.Size = new System.Drawing.Size(220, 36);
            this.panelPendingTop.TabIndex = 0;
            // 
            // txtSearchPending
            // 
            this.txtSearchPending.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSearchPending.Location = new System.Drawing.Point(6, 6);
            this.txtSearchPending.Name = "txtSearchPending";
            this.txtSearchPending.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchPending.Size = new System.Drawing.Size(130, 23);
            this.txtSearchPending.TabIndex = 0;
            this.txtSearchPending.TextChanged += new System.EventHandler(this.TxtSearchPending_TextChanged);
            // 
            // btnRefreshPending
            // 
            this.btnRefreshPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefreshPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPending.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshPending.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPending.Location = new System.Drawing.Point(141, 5);
            this.btnRefreshPending.Name = "btnRefreshPending";
            this.btnRefreshPending.Size = new System.Drawing.Size(68, 25);
            this.btnRefreshPending.TabIndex = 1;
            this.btnRefreshPending.Text = "Làm mới";
            this.btnRefreshPending.Click += new System.EventHandler(this.BtnRefreshPending_Click);
            // 
            // lstPendingOrders
            // 
            this.lstPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPendingOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstPendingOrders.ItemHeight = 22;
            this.lstPendingOrders.Location = new System.Drawing.Point(0, 36);
            this.lstPendingOrders.Name = "lstPendingOrders";
            this.lstPendingOrders.Size = new System.Drawing.Size(220, 519);
            this.lstPendingOrders.TabIndex = 1;
            this.lstPendingOrders.SelectedIndexChanged += new System.EventHandler(this.LstPendingOrders_SelectedIndexChanged);
            // 
            // panelPendingRight
            // 
            this.panelPendingRight.BackColor = System.Drawing.Color.White;
            this.panelPendingRight.Controls.Add(this.dgvStock);
            this.panelPendingRight.Controls.Add(this.lblNotesHeader);
            this.panelPendingRight.Controls.Add(this.txtRejectNotes);
            this.panelPendingRight.Controls.Add(this.panelPendingButtons);
            this.panelPendingRight.Controls.Add(this.lblCreditWarning);
            this.panelPendingRight.Controls.Add(this.lblCustomerInfo);
            this.panelPendingRight.Controls.Add(this.lblOrderTitle);
            this.panelPendingRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendingRight.Location = new System.Drawing.Point(0, 0);
            this.panelPendingRight.Name = "panelPendingRight";
            this.panelPendingRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelPendingRight.Size = new System.Drawing.Size(726, 555);
            this.panelPendingRight.TabIndex = 0;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(696, 30);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "Chi tiết đơn hàng: ---";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCustomerInfo.Location = new System.Drawing.Point(15, 45);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(696, 25);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Khách hàng: ---";
            // 
            // lblCreditWarning
            // 
            this.lblCreditWarning.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreditWarning.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCreditWarning.Location = new System.Drawing.Point(15, 70);
            this.lblCreditWarning.Name = "lblCreditWarning";
            this.lblCreditWarning.Size = new System.Drawing.Size(696, 50);
            this.lblCreditWarning.TabIndex = 2;
            this.lblCreditWarning.Text = "Tình trạng tín dụng: ---";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Tên Sản Phẩm", Name = "ProdName" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "SL Đặt", Name = "OrderQty" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Tồn Kho", Name = "StockQty" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Tình Trạng Kho", Name = "Status" }});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(15, 120);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(696, 303);
            this.dgvStock.TabIndex = 3;
            // 
            // lblNotesHeader
            // 
            this.lblNotesHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNotesHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotesHeader.Location = new System.Drawing.Point(15, 423);
            this.lblNotesHeader.Name = "lblNotesHeader";
            this.lblNotesHeader.Size = new System.Drawing.Size(696, 22);
            this.lblNotesHeader.TabIndex = 4;
            this.lblNotesHeader.Text = "Lý do từ chối (nếu có):";
            // 
            // txtRejectNotes
            // 
            this.txtRejectNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRejectNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRejectNotes.Location = new System.Drawing.Point(15, 445);
            this.txtRejectNotes.Multiline = true;
            this.txtRejectNotes.Name = "txtRejectNotes";
            this.txtRejectNotes.PlaceholderText = "Nhập ghi chú lý do nếu trả về...";
            this.txtRejectNotes.Size = new System.Drawing.Size(696, 45);
            this.txtRejectNotes.TabIndex = 5;
            // 
            // panelPendingButtons
            // 
            this.panelPendingButtons.Controls.Add(this.btnApprove);
            this.panelPendingButtons.Controls.Add(this.btnReject);
            this.panelPendingButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPendingButtons.Location = new System.Drawing.Point(15, 490);
            this.panelPendingButtons.Name = "panelPendingButtons";
            this.panelPendingButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelPendingButtons.Size = new System.Drawing.Size(696, 45);
            this.panelPendingButtons.TabIndex = 6;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnApprove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(0, 8);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(200, 37);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "✔ PHÊ DUYỆT ĐƠN HÀNG";
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(536, 8);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(160, 37);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "✖ TỪ CHỐI / TRẢ VỀ";
            this.btnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // OrderInspectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitPending);
            this.Controls.Add(this.panelHeader);
            this.Name = "OrderInspectionControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.panelPendingTop.ResumeLayout(false);
            this.panelPendingTop.PerformLayout();
            this.splitPending.Panel1.ResumeLayout(false);
            this.splitPending.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPending)).EndInit();
            this.splitPending.ResumeLayout(false);
            this.panelPendingRight.ResumeLayout(false);
            this.panelPendingRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelPendingButtons.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCreditWarning;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblNotesHeader;
        private System.Windows.Forms.TextBox txtRejectNotes;
        private System.Windows.Forms.Panel panelPendingButtons;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}
