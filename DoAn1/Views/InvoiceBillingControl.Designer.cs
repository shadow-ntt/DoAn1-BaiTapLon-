namespace DoAn1.Views
{
    partial class InvoiceBillingControl
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.txtSearchInvoice = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstApprovedOrders = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.tabPreviews = new System.Windows.Forms.TabControl();
            this.tabInvoicePreview = new System.Windows.Forms.TabPage();
            this.txtInvoicePreview = new System.Windows.Forms.TextBox();
            this.tabPackingSlipPreview = new System.Windows.Forms.TabPage();
            this.txtPackingSlipPreview = new System.Windows.Forms.TextBox();
            this.panelBottomButtons = new System.Windows.Forms.Panel();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.btnExportPackingSlip = new System.Windows.Forms.Button();
            this.btnCompleteInvoice = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPreviews.SuspendLayout();
            this.tabInvoicePreview.SuspendLayout();
            this.tabPackingSlipPreview.SuspendLayout();
            this.panelBottomButtons.SuspendLayout();
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
            this.lblHeader.Text = "LẬP HÓA ĐƠN BÁN HÀNG TỜ KHAI KIỆN HÀNG (KẾ TOÁN)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 45);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.lstApprovedOrders);
            this.splitMain.Panel1.Controls.Add(this.panelLeftTop);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelRight);
            this.splitMain.Size = new System.Drawing.Size(950, 555);
            this.splitMain.SplitterDistance = 220;
            this.splitMain.TabIndex = 1;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelLeftTop.Controls.Add(this.txtSearchInvoice);
            this.panelLeftTop.Controls.Add(this.btnRefresh);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(220, 36);
            this.panelLeftTop.TabIndex = 0;
            // 
            // txtSearchInvoice
            // 
            this.txtSearchInvoice.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtSearchInvoice.Location = new System.Drawing.Point(6, 6);
            this.txtSearchInvoice.Name = "txtSearchInvoice";
            this.txtSearchInvoice.PlaceholderText = "Tìm mã đơn, tên...";
            this.txtSearchInvoice.Size = new System.Drawing.Size(130, 23);
            this.txtSearchInvoice.TabIndex = 0;
            this.txtSearchInvoice.TextChanged += new System.EventHandler(this.TxtSearchInvoice_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(141, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lstApprovedOrders
            // 
            this.lstApprovedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstApprovedOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstApprovedOrders.ItemHeight = 20;
            this.lstApprovedOrders.Location = new System.Drawing.Point(0, 36);
            this.lstApprovedOrders.Name = "lstApprovedOrders";
            this.lstApprovedOrders.Size = new System.Drawing.Size(220, 519);
            this.lstApprovedOrders.TabIndex = 1;
            this.lstApprovedOrders.SelectedIndexChanged += new System.EventHandler(this.LstApprovedOrders_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.tabPreviews);
            this.panelRight.Controls.Add(this.panelBottomButtons);
            this.panelRight.Controls.Add(this.panelInfo);
            this.panelRight.Controls.Add(this.lblOrderTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(12);
            this.panelRight.Size = new System.Drawing.Size(726, 555);
            this.panelRight.TabIndex = 0;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.Location = new System.Drawing.Point(12, 12);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(702, 28);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "Chi tiết đơn hàng hợp lệ: ---";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblCustName);
            this.panelInfo.Controls.Add(this.txtCustName);
            this.panelInfo.Controls.Add(this.lblTaxCode);
            this.panelInfo.Controls.Add(this.txtTaxCode);
            this.panelInfo.Controls.Add(this.lblOrderDate);
            this.panelInfo.Controls.Add(this.txtOrderDate);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(12, 40);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(702, 36);
            this.panelInfo.TabIndex = 1;
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustName.Location = new System.Drawing.Point(0, 7);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(45, 22);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Khách:";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustName.Location = new System.Drawing.Point(48, 5);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(130, 23);
            this.txtCustName.TabIndex = 1;
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTaxCode.Location = new System.Drawing.Point(190, 7);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(35, 22);
            this.lblTaxCode.TabIndex = 2;
            this.lblTaxCode.Text = "MST:";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaxCode.Location = new System.Drawing.Point(228, 5);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.ReadOnly = true;
            this.txtTaxCode.Size = new System.Drawing.Size(100, 23);
            this.txtTaxCode.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate.Location = new System.Drawing.Point(340, 7);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(60, 22);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Ngày đặt:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrderDate.Location = new System.Drawing.Point(402, 5);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(125, 23);
            this.txtOrderDate.TabIndex = 5;
            // 
            // tabPreviews
            // 
            this.tabPreviews.Controls.Add(this.tabInvoicePreview);
            this.tabPreviews.Controls.Add(this.tabPackingSlipPreview);
            this.tabPreviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPreviews.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabPreviews.Location = new System.Drawing.Point(12, 76);
            this.tabPreviews.Name = "tabPreviews";
            this.tabPreviews.SelectedIndex = 0;
            this.tabPreviews.Size = new System.Drawing.Size(702, 425);
            this.tabPreviews.TabIndex = 2;
            // 
            // tabInvoicePreview
            // 
            this.tabInvoicePreview.Controls.Add(this.txtInvoicePreview);
            this.tabInvoicePreview.Location = new System.Drawing.Point(4, 26);
            this.tabInvoicePreview.Name = "tabInvoicePreview";
            this.tabInvoicePreview.Size = new System.Drawing.Size(694, 395);
            this.tabInvoicePreview.TabIndex = 0;
            this.tabInvoicePreview.Text = "Xem Trước Hóa Đơn (2 Bản)";
            this.tabInvoicePreview.UseVisualStyleBackColor = true;
            // 
            // txtInvoicePreview
            // 
            this.txtInvoicePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoicePreview.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtInvoicePreview.Location = new System.Drawing.Point(0, 0);
            this.txtInvoicePreview.Multiline = true;
            this.txtInvoicePreview.Name = "txtInvoicePreview";
            this.txtInvoicePreview.ReadOnly = true;
            this.txtInvoicePreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoicePreview.Size = new System.Drawing.Size(694, 395);
            this.txtInvoicePreview.TabIndex = 0;
            // 
            // tabPackingSlipPreview
            // 
            this.tabPackingSlipPreview.Controls.Add(this.txtPackingSlipPreview);
            this.tabPackingSlipPreview.Location = new System.Drawing.Point(4, 26);
            this.tabPackingSlipPreview.Name = "tabPackingSlipPreview";
            this.tabPackingSlipPreview.Size = new System.Drawing.Size(694, 395);
            this.tabPackingSlipPreview.TabIndex = 1;
            this.tabPackingSlipPreview.Text = "Xem Trước Tờ Khai Kiện Hàng";
            this.tabPackingSlipPreview.UseVisualStyleBackColor = true;
            // 
            // txtPackingSlipPreview
            // 
            this.txtPackingSlipPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPackingSlipPreview.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.txtPackingSlipPreview.Location = new System.Drawing.Point(0, 0);
            this.txtPackingSlipPreview.Multiline = true;
            this.txtPackingSlipPreview.Name = "txtPackingSlipPreview";
            this.txtPackingSlipPreview.ReadOnly = true;
            this.txtPackingSlipPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPackingSlipPreview.Size = new System.Drawing.Size(694, 395);
            this.txtPackingSlipPreview.TabIndex = 0;
            // 
            // panelBottomButtons
            // 
            this.panelBottomButtons.Controls.Add(this.btnExportInvoice);
            this.panelBottomButtons.Controls.Add(this.btnExportPackingSlip);
            this.panelBottomButtons.Controls.Add(this.btnCompleteInvoice);
            this.panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtons.Location = new System.Drawing.Point(12, 501);
            this.panelBottomButtons.Name = "panelBottomButtons";
            this.panelBottomButtons.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelBottomButtons.Size = new System.Drawing.Size(702, 42);
            this.panelBottomButtons.TabIndex = 3;
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnExportInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportInvoice.ForeColor = System.Drawing.Color.White;
            this.btnExportInvoice.Location = new System.Drawing.Point(0, 6);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(160, 30);
            this.btnExportInvoice.TabIndex = 0;
            this.btnExportInvoice.Text = "In/Xuất Hóa Đơn";
            this.btnExportInvoice.Click += new System.EventHandler(this.BtnExportInvoice_Click);
            // 
            // btnExportPackingSlip
            // 
            this.btnExportPackingSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnExportPackingSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPackingSlip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportPackingSlip.ForeColor = System.Drawing.Color.White;
            this.btnExportPackingSlip.Location = new System.Drawing.Point(168, 6);
            this.btnExportPackingSlip.Name = "btnExportPackingSlip";
            this.btnExportPackingSlip.Size = new System.Drawing.Size(160, 30);
            this.btnExportPackingSlip.TabIndex = 1;
            this.btnExportPackingSlip.Text = "In/Xuất Tờ Khai";
            this.btnExportPackingSlip.Click += new System.EventHandler(this.BtnExportPackingSlip_Click);
            // 
            // btnCompleteInvoice
            // 
            this.btnCompleteInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnCompleteInvoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCompleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCompleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCompleteInvoice.Location = new System.Drawing.Point(502, 6);
            this.btnCompleteInvoice.Name = "btnCompleteInvoice";
            this.btnCompleteInvoice.Size = new System.Drawing.Size(200, 36);
            this.btnCompleteInvoice.TabIndex = 2;
            this.btnCompleteInvoice.Text = "✔ HOÀN TẤT LẬP HÓA ĐƠN";
            this.btnCompleteInvoice.Click += new System.EventHandler(this.BtnCompleteInvoice_Click);
            // 
            // InvoiceBillingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "InvoiceBillingControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tabPreviews.ResumeLayout(false);
            this.tabInvoicePreview.ResumeLayout(false);
            this.tabInvoicePreview.PerformLayout();
            this.tabPackingSlipPreview.ResumeLayout(false);
            this.tabPackingSlipPreview.PerformLayout();
            this.panelBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.TextBox txtSearchInvoice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstApprovedOrders;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TabControl tabPreviews;
        private System.Windows.Forms.TabPage tabInvoicePreview;
        private System.Windows.Forms.TabPage tabPackingSlipPreview;
        private System.Windows.Forms.TextBox txtInvoicePreview;
        private System.Windows.Forms.TextBox txtPackingSlipPreview;
        private System.Windows.Forms.Panel panelBottomButtons;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.Button btnExportPackingSlip;
        private System.Windows.Forms.Button btnCompleteInvoice;
    }
}
