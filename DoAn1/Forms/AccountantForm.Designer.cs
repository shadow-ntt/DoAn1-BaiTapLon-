using System.Drawing;
using System.Windows.Forms;

namespace DoAn1.Forms
{
    partial class AccountantForm
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
            tabControlAccountant = new TabControl();
            tabInvoice = new TabPage();
            pnlDetails = new Panel();
            tlpPreviews = new TableLayoutPanel();
            lblInvoicePreview = new Label();
            lblPackingSlip = new Label();
            txtInvoicePreview = new TextBox();
            txtPackingSlipPreview = new TextBox();
            btnPrintInvoice = new Button();
            btnPrintPackingSlip = new Button();
            btnCreateInvoice = new Button();
            txtOrderDate = new TextBox();
            lblOrderDate = new Label();
            txtTaxCode = new TextBox();
            lblTaxCode = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblOrderTitle = new Label();
            lstApprovedOrders = new ListBox();
            pnlInvoiceHeader = new Panel();
            flpInvoiceHeaderActions = new FlowLayoutPanel();
            btnRefreshInvoice = new Button();
            lblListHeader = new Label();
            tabRevenue = new TabPage();
            pnlRevenueGrid = new Panel();
            dgvRevenue = new DataGridView();
            colInvoiceId = new DataGridViewTextBoxColumn();
            colOrderId = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colTaxCode = new DataGridViewTextBoxColumn();
            colPaidDate = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlRevenueSummary = new Panel();
            pnlCardAvg = new Panel();
            lblCardAvgValue = new Label();
            lblCardAvgTitle = new Label();
            pnlCardCount = new Panel();
            lblCardCountValue = new Label();
            lblCardCountTitle = new Label();
            pnlCardTotal = new Panel();
            lblCardTotalValue = new Label();
            lblCardTotalTitle = new Label();
            pnlRevenueFilter = new Panel();
            flpRevenueActions = new FlowLayoutPanel();
            btnRefreshRevenue = new Button();
            btnExportExcel = new Button();
            btnFilterRevenue = new Button();
            txtSearchRevenue = new TextBox();
            lblSearchRevenue = new Label();
            dtpToDate = new DateTimePicker();
            lblToDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblFromDate = new Label();
            tabControlAccountant.SuspendLayout();
            tabInvoice.SuspendLayout();
            pnlDetails.SuspendLayout();
            tlpPreviews.SuspendLayout();
            pnlInvoiceHeader.SuspendLayout();
            flpInvoiceHeaderActions.SuspendLayout();
            tabRevenue.SuspendLayout();
            pnlRevenueGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            pnlRevenueSummary.SuspendLayout();
            pnlCardAvg.SuspendLayout();
            pnlCardCount.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            pnlRevenueFilter.SuspendLayout();
            flpRevenueActions.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAccountant
            // 
            tabControlAccountant.Controls.Add(tabInvoice);
            tabControlAccountant.Controls.Add(tabRevenue);
            tabControlAccountant.Dock = DockStyle.Fill;
            tabControlAccountant.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            tabControlAccountant.ItemSize = new Size(280, 45);
            tabControlAccountant.Location = new Point(0, 0);
            tabControlAccountant.Margin = new Padding(3, 4, 3, 4);
            tabControlAccountant.Name = "tabControlAccountant";
            tabControlAccountant.SelectedIndex = 0;
            tabControlAccountant.Size = new Size(1438, 1052);
            tabControlAccountant.SizeMode = TabSizeMode.Fixed;
            tabControlAccountant.TabIndex = 0;
            tabControlAccountant.SelectedIndexChanged += TabControlAccountant_SelectedIndexChanged;
            // 
            // tabInvoice
            // 
            tabInvoice.BackColor = Color.FromArgb(240, 244, 250);
            tabInvoice.Controls.Add(pnlDetails);
            tabInvoice.Controls.Add(lstApprovedOrders);
            tabInvoice.Controls.Add(pnlInvoiceHeader);
            tabInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabInvoice.Location = new Point(4, 49);
            tabInvoice.Margin = new Padding(3, 4, 3, 4);
            tabInvoice.Name = "tabInvoice";
            tabInvoice.Padding = new Padding(10, 12, 10, 12);
            tabInvoice.Size = new Size(1430, 999);
            tabInvoice.TabIndex = 0;
            tabInvoice.Text = "LẬP HÓA ĐƠN & TỜ KHAI";
            // 
            // pnlDetails
            // 
            pnlDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDetails.BackColor = Color.FromArgb(252, 252, 252);
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(tlpPreviews);
            pnlDetails.Controls.Add(txtOrderDate);
            pnlDetails.Controls.Add(lblOrderDate);
            pnlDetails.Controls.Add(txtTaxCode);
            pnlDetails.Controls.Add(lblTaxCode);
            pnlDetails.Controls.Add(txtCustomerName);
            pnlDetails.Controls.Add(lblCustomerName);
            pnlDetails.Controls.Add(lblOrderTitle);
            pnlDetails.Location = new Point(402, 82);
            pnlDetails.Margin = new Padding(3, 4, 3, 4);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(10, 12, 10, 12);
            pnlDetails.Size = new Size(1018, 895);
            pnlDetails.TabIndex = 2;
            // 
            // tlpPreviews
            // 
            tlpPreviews.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpPreviews.ColumnCount = 2;
            tlpPreviews.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPreviews.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPreviews.Controls.Add(lblInvoicePreview, 0, 0);
            tlpPreviews.Controls.Add(lblPackingSlip, 1, 0);
            tlpPreviews.Controls.Add(txtInvoicePreview, 0, 1);
            tlpPreviews.Controls.Add(txtPackingSlipPreview, 1, 1);
            tlpPreviews.Controls.Add(btnPrintInvoice, 0, 2);
            tlpPreviews.Controls.Add(btnPrintPackingSlip, 1, 2);
            tlpPreviews.Controls.Add(btnCreateInvoice, 0, 3);
            tlpPreviews.Location = new Point(15, 155);
            tlpPreviews.Name = "tlpPreviews";
            tlpPreviews.RowCount = 4;
            tlpPreviews.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPreviews.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPreviews.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpPreviews.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPreviews.Size = new Size(986, 725);
            tlpPreviews.TabIndex = 14;
            // 
            // lblInvoicePreview
            // 
            lblInvoicePreview.AutoSize = true;
            lblInvoicePreview.Dock = DockStyle.Fill;
            lblInvoicePreview.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInvoicePreview.ForeColor = Color.DarkGreen;
            lblInvoicePreview.Location = new Point(3, 0);
            lblInvoicePreview.Margin = new Padding(3, 0, 3, 5);
            lblInvoicePreview.Name = "lblInvoicePreview";
            lblInvoicePreview.Size = new Size(487, 25);
            lblInvoicePreview.TabIndex = 0;
            lblInvoicePreview.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // lblPackingSlip
            // 
            lblPackingSlip.AutoSize = true;
            lblPackingSlip.Dock = DockStyle.Fill;
            lblPackingSlip.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPackingSlip.ForeColor = Color.Maroon;
            lblPackingSlip.Location = new Point(496, 0);
            lblPackingSlip.Margin = new Padding(3, 0, 3, 5);
            lblPackingSlip.Name = "lblPackingSlip";
            lblPackingSlip.Size = new Size(487, 25);
            lblPackingSlip.TabIndex = 1;
            lblPackingSlip.Text = "TỜ KHAI KIỆN HÀNG ĐÓNG GÓI";
            // 
            // txtInvoicePreview
            // 
            txtInvoicePreview.BackColor = Color.FromArgb(255, 255, 248);
            txtInvoicePreview.BorderStyle = BorderStyle.FixedSingle;
            txtInvoicePreview.Dock = DockStyle.Fill;
            txtInvoicePreview.Font = new Font("Consolas", 10F);
            txtInvoicePreview.ForeColor = Color.FromArgb(20, 20, 20);
            txtInvoicePreview.Location = new Point(3, 33);
            txtInvoicePreview.Margin = new Padding(3, 3, 6, 3);
            txtInvoicePreview.Multiline = true;
            txtInvoicePreview.Name = "txtInvoicePreview";
            txtInvoicePreview.ReadOnly = true;
            txtInvoicePreview.ScrollBars = ScrollBars.Both;
            txtInvoicePreview.Size = new Size(484, 574);
            txtInvoicePreview.TabIndex = 2;
            txtInvoicePreview.WordWrap = false;
            // 
            // txtPackingSlipPreview
            // 
            txtPackingSlipPreview.BackColor = Color.FromArgb(248, 248, 248);
            txtPackingSlipPreview.BorderStyle = BorderStyle.FixedSingle;
            txtPackingSlipPreview.Dock = DockStyle.Fill;
            txtPackingSlipPreview.Font = new Font("Consolas", 10F);
            txtPackingSlipPreview.ForeColor = Color.FromArgb(30, 30, 30);
            txtPackingSlipPreview.Location = new Point(499, 33);
            txtPackingSlipPreview.Margin = new Padding(6, 3, 3, 3);
            txtPackingSlipPreview.Multiline = true;
            txtPackingSlipPreview.Name = "txtPackingSlipPreview";
            txtPackingSlipPreview.ReadOnly = true;
            txtPackingSlipPreview.ScrollBars = ScrollBars.Both;
            txtPackingSlipPreview.Size = new Size(484, 574);
            txtPackingSlipPreview.TabIndex = 3;
            txtPackingSlipPreview.WordWrap = false;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.FromArgb(46, 125, 50);
            btnPrintInvoice.Cursor = Cursors.Hand;
            btnPrintInvoice.Dock = DockStyle.Fill;
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(3, 615);
            btnPrintInvoice.Margin = new Padding(3, 5, 6, 5);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(484, 45);
            btnPrintInvoice.TabIndex = 4;
            btnPrintInvoice.Text = "XUẤT FILE HÓA ĐƠN (.DOCX)";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += BtnPrintInvoice_Click;
            // 
            // btnPrintPackingSlip
            // 
            btnPrintPackingSlip.BackColor = Color.FromArgb(183, 28, 28);
            btnPrintPackingSlip.Cursor = Cursors.Hand;
            btnPrintPackingSlip.Dock = DockStyle.Fill;
            btnPrintPackingSlip.FlatStyle = FlatStyle.Flat;
            btnPrintPackingSlip.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrintPackingSlip.ForeColor = Color.White;
            btnPrintPackingSlip.Location = new Point(499, 615);
            btnPrintPackingSlip.Margin = new Padding(6, 5, 3, 5);
            btnPrintPackingSlip.Name = "btnPrintPackingSlip";
            btnPrintPackingSlip.Size = new Size(484, 45);
            btnPrintPackingSlip.TabIndex = 5;
            btnPrintPackingSlip.Text = "XUẤT FILE TỜ KHAI KIỆN HÀNG (.DOCX)";
            btnPrintPackingSlip.UseVisualStyleBackColor = false;
            btnPrintPackingSlip.Click += BtnPrintPackingSlip_Click;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.FromArgb(13, 49, 119);
            tlpPreviews.SetColumnSpan(btnCreateInvoice, 2);
            btnCreateInvoice.Cursor = Cursors.Hand;
            btnCreateInvoice.Dock = DockStyle.Fill;
            btnCreateInvoice.FlatStyle = FlatStyle.Flat;
            btnCreateInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(3, 670);
            btnCreateInvoice.Margin = new Padding(3, 5, 3, 0);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(980, 55);
            btnCreateInvoice.TabIndex = 6;
            btnCreateInvoice.Text = "HOÀN THÀNH LẬP HÓA ĐƠN & TỜ KHAI";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            btnCreateInvoice.Click += BtnCreateInvoice_Click;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Font = new Font("Segoe UI", 10F);
            txtOrderDate.Location = new Point(145, 105);
            txtOrderDate.Margin = new Padding(3, 4, 3, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(315, 30);
            txtOrderDate.TabIndex = 6;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 9.5F);
            lblOrderDate.Location = new Point(16, 110);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(115, 21);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "Ngày đặt hàng:";
            // 
            // txtTaxCode
            // 
            txtTaxCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTaxCode.Font = new Font("Segoe UI", 10F);
            txtTaxCode.Location = new Point(600, 60);
            txtTaxCode.Margin = new Padding(3, 4, 3, 4);
            txtTaxCode.Name = "txtTaxCode";
            txtTaxCode.ReadOnly = true;
            txtTaxCode.Size = new Size(398, 30);
            txtTaxCode.TabIndex = 4;
            // 
            // lblTaxCode
            // 
            lblTaxCode.AutoSize = true;
            lblTaxCode.Font = new Font("Segoe UI", 9.5F);
            lblTaxCode.Location = new Point(500, 65);
            lblTaxCode.Name = "lblTaxCode";
            lblTaxCode.Size = new Size(90, 21);
            lblTaxCode.TabIndex = 3;
            lblTaxCode.Text = "Mã số thuế:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10F);
            txtCustomerName.Location = new Point(145, 60);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(315, 30);
            txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9.5F);
            lblCustomerName.Location = new Point(16, 65);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(120, 21);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Tên khách hàng:";
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblOrderTitle.ForeColor = Color.FromArgb(13, 49, 119);
            lblOrderTitle.Location = new Point(15, 15);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(289, 30);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Chi tiết đơn hàng hợp lệ: ---";
            // 
            // lstApprovedOrders
            // 
            lstApprovedOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstApprovedOrders.BackColor = Color.FromArgb(250, 252, 255);
            lstApprovedOrders.BorderStyle = BorderStyle.FixedSingle;
            lstApprovedOrders.Font = new Font("Segoe UI", 10.5F);
            lstApprovedOrders.ForeColor = Color.FromArgb(30, 30, 30);
            lstApprovedOrders.FormattingEnabled = true;
            lstApprovedOrders.Location = new Point(10, 82);
            lstApprovedOrders.Margin = new Padding(3, 4, 3, 4);
            lstApprovedOrders.Name = "lstApprovedOrders";
            lstApprovedOrders.Size = new Size(382, 876);
            lstApprovedOrders.TabIndex = 1;
            lstApprovedOrders.SelectedIndexChanged += LstApprovedOrders_SelectedIndexChanged;
            // 
            // pnlInvoiceHeader
            // 
            pnlInvoiceHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInvoiceHeader.BackColor = Color.White;
            pnlInvoiceHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlInvoiceHeader.Controls.Add(flpInvoiceHeaderActions);
            pnlInvoiceHeader.Controls.Add(lblListHeader);
            pnlInvoiceHeader.Location = new Point(10, 12);
            pnlInvoiceHeader.Name = "pnlInvoiceHeader";
            pnlInvoiceHeader.Size = new Size(1410, 60);
            pnlInvoiceHeader.TabIndex = 0;
            // 
            // flpInvoiceHeaderActions
            // 
            flpInvoiceHeaderActions.AutoSize = true;
            flpInvoiceHeaderActions.Controls.Add(btnRefreshInvoice);
            flpInvoiceHeaderActions.Dock = DockStyle.Right;
            flpInvoiceHeaderActions.FlowDirection = FlowDirection.RightToLeft;
            flpInvoiceHeaderActions.Location = new Point(1278, 0);
            flpInvoiceHeaderActions.Name = "flpInvoiceHeaderActions";
            flpInvoiceHeaderActions.Padding = new Padding(0, 9, 10, 0);
            flpInvoiceHeaderActions.Size = new Size(130, 58);
            flpInvoiceHeaderActions.TabIndex = 2;
            // 
            // btnRefreshInvoice
            // 
            btnRefreshInvoice.BackColor = Color.FromArgb(108, 117, 125);
            btnRefreshInvoice.Cursor = Cursors.Hand;
            btnRefreshInvoice.FlatStyle = FlatStyle.Flat;
            btnRefreshInvoice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefreshInvoice.ForeColor = Color.White;
            btnRefreshInvoice.Location = new Point(3, 12);
            btnRefreshInvoice.Name = "btnRefreshInvoice";
            btnRefreshInvoice.Size = new Size(120, 40);
            btnRefreshInvoice.TabIndex = 1;
            btnRefreshInvoice.Text = "TẢI LẠI";
            btnRefreshInvoice.UseVisualStyleBackColor = false;
            btnRefreshInvoice.Click += BtnRefreshInvoice_Click;
            // 
            // lblListHeader
            // 
            lblListHeader.AutoSize = true;
            lblListHeader.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblListHeader.ForeColor = Color.FromArgb(13, 49, 119);
            lblListHeader.Location = new Point(15, 16);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(318, 28);
            lblListHeader.TabIndex = 0;
            lblListHeader.Text = "ĐƠN HÀNG CHỜ LẬP HÓA ĐƠN";
            // 
            // tabRevenue
            // 
            tabRevenue.BackColor = Color.FromArgb(240, 244, 250);
            tabRevenue.Controls.Add(pnlRevenueGrid);
            tabRevenue.Controls.Add(pnlRevenueSummary);
            tabRevenue.Controls.Add(pnlRevenueFilter);
            tabRevenue.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabRevenue.Location = new Point(4, 49);
            tabRevenue.Margin = new Padding(3, 4, 3, 4);
            tabRevenue.Name = "tabRevenue";
            tabRevenue.Padding = new Padding(12, 15, 12, 15);
            tabRevenue.Size = new Size(1430, 999);
            tabRevenue.TabIndex = 1;
            tabRevenue.Text = "QUẢN LÝ DOANH THU";
            // 
            // pnlRevenueGrid
            // 
            pnlRevenueGrid.Controls.Add(dgvRevenue);
            pnlRevenueGrid.Dock = DockStyle.Fill;
            pnlRevenueGrid.Location = new Point(12, 240);
            pnlRevenueGrid.Margin = new Padding(3, 4, 3, 4);
            pnlRevenueGrid.Name = "pnlRevenueGrid";
            pnlRevenueGrid.Size = new Size(1406, 744);
            pnlRevenueGrid.TabIndex = 2;
            // 
            // dgvRevenue
            // 
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.AllowUserToDeleteRows = false;
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.BackgroundColor = Color.White;
            dgvRevenue.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 49, 119);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRevenue.ColumnHeadersHeight = 40;
            dgvRevenue.Columns.AddRange(new DataGridViewColumn[] { colInvoiceId, colOrderId, colCustomerName, colTaxCode, colPaidDate, colTotalAmount, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRevenue.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRevenue.Dock = DockStyle.Fill;
            dgvRevenue.EnableHeadersVisualStyles = false;
            dgvRevenue.Location = new Point(0, 0);
            dgvRevenue.Margin = new Padding(3, 4, 3, 4);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.RowHeadersWidth = 35;
            dgvRevenue.RowTemplate.Height = 32;
            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenue.Size = new Size(1406, 744);
            dgvRevenue.TabIndex = 0;
            // 
            // colInvoiceId
            // 
            colInvoiceId.DataPropertyName = "InvoiceId";
            colInvoiceId.HeaderText = "Mã Hóa Đơn";
            colInvoiceId.MinimumWidth = 100;
            colInvoiceId.Name = "colInvoiceId";
            colInvoiceId.ReadOnly = true;
            // 
            // colOrderId
            // 
            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "Mã Đơn Hàng";
            colOrderId.MinimumWidth = 100;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.DataPropertyName = "CustomerName";
            colCustomerName.HeaderText = "Tên Khách Hàng";
            colCustomerName.MinimumWidth = 180;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colTaxCode
            // 
            colTaxCode.DataPropertyName = "TaxCode";
            colTaxCode.HeaderText = "Mã Số Thuế";
            colTaxCode.MinimumWidth = 120;
            colTaxCode.Name = "colTaxCode";
            colTaxCode.ReadOnly = true;
            // 
            // colPaidDate
            // 
            colPaidDate.DataPropertyName = "PaidDate";
            colPaidDate.HeaderText = "Ngày Thu Tiền";
            colPaidDate.MinimumWidth = 130;
            colPaidDate.Name = "colPaidDate";
            colPaidDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            colTotalAmount.HeaderText = "Tổng Tiền (VNĐ)";
            colTotalAmount.MinimumWidth = 140;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng Thái Giao / Thu Tiền";
            colStatus.MinimumWidth = 160;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlRevenueSummary
            // 
            pnlRevenueSummary.Controls.Add(pnlCardAvg);
            pnlRevenueSummary.Controls.Add(pnlCardCount);
            pnlRevenueSummary.Controls.Add(pnlCardTotal);
            pnlRevenueSummary.Dock = DockStyle.Top;
            pnlRevenueSummary.Location = new Point(12, 102);
            pnlRevenueSummary.Margin = new Padding(3, 4, 3, 4);
            pnlRevenueSummary.Name = "pnlRevenueSummary";
            pnlRevenueSummary.Padding = new Padding(0, 12, 0, 12);
            pnlRevenueSummary.Size = new Size(1406, 138);
            pnlRevenueSummary.TabIndex = 1;
            // 
            // pnlCardAvg
            // 
            pnlCardAvg.BackColor = Color.FromArgb(237, 247, 237);
            pnlCardAvg.BorderStyle = BorderStyle.FixedSingle;
            pnlCardAvg.Controls.Add(lblCardAvgValue);
            pnlCardAvg.Controls.Add(lblCardAvgTitle);
            pnlCardAvg.Location = new Point(950, 12);
            pnlCardAvg.Margin = new Padding(3, 4, 3, 4);
            pnlCardAvg.Name = "pnlCardAvg";
            pnlCardAvg.Size = new Size(440, 112);
            pnlCardAvg.TabIndex = 2;
            // 
            // lblCardAvgValue
            // 
            lblCardAvgValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCardAvgValue.ForeColor = Color.FromArgb(46, 125, 50);
            lblCardAvgValue.Location = new Point(12, 52);
            lblCardAvgValue.Name = "lblCardAvgValue";
            lblCardAvgValue.Size = new Size(414, 48);
            lblCardAvgValue.TabIndex = 1;
            lblCardAvgValue.Text = "0 VNĐ";
            lblCardAvgValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardAvgTitle
            // 
            lblCardAvgTitle.AutoSize = true;
            lblCardAvgTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCardAvgTitle.ForeColor = Color.FromArgb(30, 70, 32);
            lblCardAvgTitle.Location = new Point(12, 15);
            lblCardAvgTitle.Name = "lblCardAvgTitle";
            lblCardAvgTitle.Size = new Size(212, 21);
            lblCardAvgTitle.TabIndex = 0;
            lblCardAvgTitle.Text = "GIÁ TRỊ TRUNG BÌNH/ĐƠN";
            // 
            // pnlCardCount
            // 
            pnlCardCount.BackColor = Color.FromArgb(254, 243, 199);
            pnlCardCount.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCount.Controls.Add(lblCardCountValue);
            pnlCardCount.Controls.Add(lblCardCountTitle);
            pnlCardCount.Location = new Point(475, 12);
            pnlCardCount.Margin = new Padding(3, 4, 3, 4);
            pnlCardCount.Name = "pnlCardCount";
            pnlCardCount.Size = new Size(440, 112);
            pnlCardCount.TabIndex = 1;
            // 
            // lblCardCountValue
            // 
            lblCardCountValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCardCountValue.ForeColor = Color.FromArgb(180, 83, 9);
            lblCardCountValue.Location = new Point(12, 52);
            lblCardCountValue.Name = "lblCardCountValue";
            lblCardCountValue.Size = new Size(414, 48);
            lblCardCountValue.TabIndex = 1;
            lblCardCountValue.Text = "0 Hóa đơn";
            lblCardCountValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardCountTitle
            // 
            lblCardCountTitle.AutoSize = true;
            lblCardCountTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCardCountTitle.ForeColor = Color.FromArgb(120, 53, 15);
            lblCardCountTitle.Location = new Point(12, 15);
            lblCardCountTitle.Name = "lblCardCountTitle";
            lblCardCountTitle.Size = new Size(215, 21);
            lblCardCountTitle.TabIndex = 0;
            lblCardCountTitle.Text = "SỐ HÓA ĐƠN ĐÃ THU TIỀN";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.FromArgb(224, 242, 254);
            pnlCardTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotal.Controls.Add(lblCardTotalValue);
            pnlCardTotal.Controls.Add(lblCardTotalTitle);
            pnlCardTotal.Location = new Point(0, 12);
            pnlCardTotal.Margin = new Padding(3, 4, 3, 4);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(440, 112);
            pnlCardTotal.TabIndex = 0;
            // 
            // lblCardTotalValue
            // 
            lblCardTotalValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCardTotalValue.ForeColor = Color.FromArgb(3, 105, 161);
            lblCardTotalValue.Location = new Point(12, 52);
            lblCardTotalValue.Name = "lblCardTotalValue";
            lblCardTotalValue.Size = new Size(414, 48);
            lblCardTotalValue.TabIndex = 1;
            lblCardTotalValue.Text = "0 VNĐ";
            lblCardTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCardTotalTitle
            // 
            lblCardTotalTitle.AutoSize = true;
            lblCardTotalTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCardTotalTitle.ForeColor = Color.FromArgb(12, 74, 110);
            lblCardTotalTitle.Location = new Point(12, 15);
            lblCardTotalTitle.Name = "lblCardTotalTitle";
            lblCardTotalTitle.Size = new Size(193, 21);
            lblCardTotalTitle.TabIndex = 0;
            lblCardTotalTitle.Text = "TỔNG DOANH THU THU";
            // 
            // pnlRevenueFilter
            // 
            pnlRevenueFilter.BackColor = Color.White;
            pnlRevenueFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlRevenueFilter.Controls.Add(flpRevenueActions);
            pnlRevenueFilter.Controls.Add(txtSearchRevenue);
            pnlRevenueFilter.Controls.Add(lblSearchRevenue);
            pnlRevenueFilter.Controls.Add(dtpToDate);
            pnlRevenueFilter.Controls.Add(lblToDate);
            pnlRevenueFilter.Controls.Add(dtpFromDate);
            pnlRevenueFilter.Controls.Add(lblFromDate);
            pnlRevenueFilter.Dock = DockStyle.Top;
            pnlRevenueFilter.Location = new Point(12, 15);
            pnlRevenueFilter.Margin = new Padding(3, 4, 3, 4);
            pnlRevenueFilter.Name = "pnlRevenueFilter";
            pnlRevenueFilter.Size = new Size(1406, 87);
            pnlRevenueFilter.TabIndex = 0;
            // 
            // flpRevenueActions
            // 
            flpRevenueActions.AutoSize = true;
            flpRevenueActions.Controls.Add(btnRefreshRevenue);
            flpRevenueActions.Controls.Add(btnExportExcel);
            flpRevenueActions.Controls.Add(btnFilterRevenue);
            flpRevenueActions.Dock = DockStyle.Right;
            flpRevenueActions.FlowDirection = FlowDirection.RightToLeft;
            flpRevenueActions.Location = new Point(994, 0);
            flpRevenueActions.Name = "flpRevenueActions";
            flpRevenueActions.Padding = new Padding(0, 20, 10, 0);
            flpRevenueActions.Size = new Size(410, 85);
            flpRevenueActions.TabIndex = 9;
            flpRevenueActions.WrapContents = false;
            // 
            // btnRefreshRevenue
            // 
            btnRefreshRevenue.BackColor = Color.FromArgb(108, 117, 125);
            btnRefreshRevenue.Cursor = Cursors.Hand;
            btnRefreshRevenue.FlatStyle = FlatStyle.Flat;
            btnRefreshRevenue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefreshRevenue.ForeColor = Color.White;
            btnRefreshRevenue.Location = new Point(277, 24);
            btnRefreshRevenue.Margin = new Padding(5, 4, 5, 4);
            btnRefreshRevenue.Name = "btnRefreshRevenue";
            btnRefreshRevenue.Size = new Size(118, 42);
            btnRefreshRevenue.TabIndex = 7;
            btnRefreshRevenue.Text = "TẢI LẠI";
            btnRefreshRevenue.UseVisualStyleBackColor = false;
            btnRefreshRevenue.Click += BtnRefreshRevenue_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(27, 94, 32);
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(134, 24);
            btnExportExcel.Margin = new Padding(5, 4, 5, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(133, 42);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = "XUẤT REPORT";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += BtnExportExcel_Click;
            // 
            // btnFilterRevenue
            // 
            btnFilterRevenue.BackColor = Color.FromArgb(13, 49, 119);
            btnFilterRevenue.Cursor = Cursors.Hand;
            btnFilterRevenue.FlatStyle = FlatStyle.Flat;
            btnFilterRevenue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFilterRevenue.ForeColor = Color.White;
            btnFilterRevenue.Location = new Point(6, 24);
            btnFilterRevenue.Margin = new Padding(5, 4, 5, 4);
            btnFilterRevenue.Name = "btnFilterRevenue";
            btnFilterRevenue.Size = new Size(118, 42);
            btnFilterRevenue.TabIndex = 6;
            btnFilterRevenue.Text = "LỌC DỮ LIỆU";
            btnFilterRevenue.UseVisualStyleBackColor = false;
            btnFilterRevenue.Click += BtnFilterRevenue_Click;
            // 
            // txtSearchRevenue
            // 
            txtSearchRevenue.Font = new Font("Segoe UI", 10F);
            txtSearchRevenue.Location = new Point(680, 28);
            txtSearchRevenue.Margin = new Padding(3, 4, 3, 4);
            txtSearchRevenue.Name = "txtSearchRevenue";
            txtSearchRevenue.Size = new Size(290, 30);
            txtSearchRevenue.TabIndex = 5;
            txtSearchRevenue.TextChanged += TxtSearchRevenue_TextChanged;
            // 
            // lblSearchRevenue
            // 
            lblSearchRevenue.AutoSize = true;
            lblSearchRevenue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearchRevenue.Location = new Point(590, 33);
            lblSearchRevenue.Name = "lblSearchRevenue";
            lblSearchRevenue.Size = new Size(85, 21);
            lblSearchRevenue.TabIndex = 4;
            lblSearchRevenue.Text = "Tìm kiếm:";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Font = new Font("Segoe UI", 10F);
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(395, 28);
            dtpToDate.Margin = new Padding(3, 4, 3, 4);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(160, 30);
            dtpToDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblToDate.Location = new Point(305, 33);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(87, 21);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Font = new Font("Segoe UI", 10F);
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(115, 28);
            dtpFromDate.Margin = new Padding(3, 4, 3, 4);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(160, 30);
            dtpFromDate.TabIndex = 1;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFromDate.Location = new Point(20, 33);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(76, 21);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "Từ ngày:";
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 250);
            ClientSize = new Size(1438, 1052);
            Controls.Add(tabControlAccountant);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountantForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kế Toán LAVITA - Quản Lý Hóa Đơn & Doanh Thu";
            WindowState = FormWindowState.Maximized;
            Load += AccountantForm_Load;
            tabControlAccountant.ResumeLayout(false);
            tabInvoice.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            tlpPreviews.ResumeLayout(false);
            tlpPreviews.PerformLayout();
            pnlInvoiceHeader.ResumeLayout(false);
            pnlInvoiceHeader.PerformLayout();
            flpInvoiceHeaderActions.ResumeLayout(false);
            tabRevenue.ResumeLayout(false);
            pnlRevenueGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            pnlRevenueSummary.ResumeLayout(false);
            pnlCardAvg.ResumeLayout(false);
            pnlCardAvg.PerformLayout();
            pnlCardCount.ResumeLayout(false);
            pnlCardCount.PerformLayout();
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlRevenueFilter.ResumeLayout(false);
            pnlRevenueFilter.PerformLayout();
            flpRevenueActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAccountant;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.TabPage tabRevenue;

        // Invoice Tab Controls
        private System.Windows.Forms.Panel pnlInvoiceHeader;
        private System.Windows.Forms.FlowLayoutPanel flpInvoiceHeaderActions;
        private System.Windows.Forms.Label lblListHeader;
        private System.Windows.Forms.Button btnRefreshInvoice;
        private System.Windows.Forms.ListBox lstApprovedOrders;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TableLayoutPanel tlpPreviews;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblInvoicePreview;
        private System.Windows.Forms.TextBox txtInvoicePreview;
        private System.Windows.Forms.Label lblPackingSlip;
        private System.Windows.Forms.TextBox txtPackingSlipPreview;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnPrintPackingSlip;

        // Revenue Tab Controls
        private System.Windows.Forms.Panel pnlRevenueFilter;
        private System.Windows.Forms.FlowLayoutPanel flpRevenueActions;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblSearchRevenue;
        private System.Windows.Forms.TextBox txtSearchRevenue;
        private System.Windows.Forms.Button btnFilterRevenue;
        private System.Windows.Forms.Button btnRefreshRevenue;
        private System.Windows.Forms.Button btnExportExcel;

        private System.Windows.Forms.Panel pnlRevenueSummary;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblCardTotalTitle;
        private System.Windows.Forms.Label lblCardTotalValue;
        private System.Windows.Forms.Panel pnlCardCount;
        private System.Windows.Forms.Label lblCardCountTitle;
        private System.Windows.Forms.Label lblCardCountValue;
        private System.Windows.Forms.Panel pnlCardAvg;
        private System.Windows.Forms.Label lblCardAvgTitle;
        private System.Windows.Forms.Label lblCardAvgValue;

        private System.Windows.Forms.Panel pnlRevenueGrid;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}