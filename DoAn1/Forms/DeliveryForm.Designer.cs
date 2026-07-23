namespace DoAn1.Forms
{
    partial class DeliveryForm
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
            splitMain = new SplitContainer();
            tabControlDelivery = new TabControl();
            tabPending = new TabPage();
            lblSearchPending = new Label();
            txtSearchPending = new TextBox();
            btnRefreshPending = new Button();
            lstPendingOrders = new ListBox();
            btnStartDelivery = new Button();
            tabDelivering = new TabPage();
            lblSearchDelivering = new Label();
            txtSearchDelivering = new TextBox();
            btnRefreshDelivering = new Button();
            lstDeliveringOrders = new ListBox();
            btnConfirmSuccess = new Button();
            lblReturnReason = new Label();
            txtReturnReason = new TextBox();
            btnConfirmReturn = new Button();
            tabHistory = new TabPage();
            lblSearchHistory = new Label();
            txtSearchHistory = new TextBox();
            btnRefreshHistory = new Button();
            dgvDeliveryHistory = new DataGridView();
            pnlDetails = new Panel();
            txtHistoryReturnReason = new TextBox();
            lblHistoryReturnReason = new Label();
            txtActualDeliveryDate = new TextBox();
            lblActualDeliveryDate = new Label();
            txtDeliveryStatus = new TextBox();
            lblDeliveryStatus = new Label();
            txtInvoiceDate = new TextBox();
            lblInvoiceDate = new Label();
            txtExpectedDate = new TextBox();
            lblExpectedDate = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblOrderTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tabControlDelivery.SuspendLayout();
            tabPending.SuspendLayout();
            tabDelivering.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveryHistory).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(10, 12);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tabControlDelivery);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlDetails);
            splitMain.Size = new Size(1260, 851);
            splitMain.SplitterDistance = 500;
            splitMain.TabIndex = 0;
            // 
            // tabControlDelivery
            // 
            tabControlDelivery.Controls.Add(tabPending);
            tabControlDelivery.Controls.Add(tabDelivering);
            tabControlDelivery.Controls.Add(tabHistory);
            tabControlDelivery.Dock = DockStyle.Fill;
            tabControlDelivery.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlDelivery.Location = new Point(0, 0);
            tabControlDelivery.Margin = new Padding(3, 4, 3, 4);
            tabControlDelivery.Name = "tabControlDelivery";
            tabControlDelivery.SelectedIndex = 0;
            tabControlDelivery.Size = new Size(500, 851);
            tabControlDelivery.TabIndex = 0;
            // 
            // tabPending
            // 
            tabPending.Controls.Add(lblSearchPending);
            tabPending.Controls.Add(txtSearchPending);
            tabPending.Controls.Add(btnRefreshPending);
            tabPending.Controls.Add(lstPendingOrders);
            tabPending.Controls.Add(btnStartDelivery);
            tabPending.Location = new Point(4, 32);
            tabPending.Margin = new Padding(3, 4, 3, 4);
            tabPending.Name = "tabPending";
            tabPending.Padding = new Padding(10, 12, 10, 12);
            tabPending.Size = new Size(492, 815);
            tabPending.TabIndex = 0;
            tabPending.Text = "Đơn chờ giao";
            tabPending.UseVisualStyleBackColor = true;
            // 
            // lblSearchPending
            // 
            lblSearchPending.AutoSize = true;
            lblSearchPending.Location = new Point(10, 19);
            lblSearchPending.Name = "lblSearchPending";
            lblSearchPending.Size = new Size(88, 25);
            lblSearchPending.TabIndex = 0;
            lblSearchPending.Text = "Tìm kiếm:";
            // 
            // txtSearchPending
            // 
            txtSearchPending.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchPending.Location = new Point(105, 14);
            txtSearchPending.Margin = new Padding(3, 4, 3, 4);
            txtSearchPending.Name = "txtSearchPending";
            txtSearchPending.Size = new Size(260, 31);
            txtSearchPending.TabIndex = 1;
            // 
            // btnRefreshPending
            // 
            btnRefreshPending.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshPending.BackColor = Color.FromArgb(108, 117, 125);
            btnRefreshPending.Cursor = Cursors.Hand;
            btnRefreshPending.FlatStyle = FlatStyle.Flat;
            btnRefreshPending.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshPending.ForeColor = Color.White;
            btnRefreshPending.Location = new Point(375, 12);
            btnRefreshPending.Name = "btnRefreshPending";
            btnRefreshPending.Size = new Size(105, 34);
            btnRefreshPending.TabIndex = 2;
            btnRefreshPending.Text = "TẢI LẠI";
            btnRefreshPending.UseVisualStyleBackColor = false;
            // 
            // lstPendingOrders
            // 
            lstPendingOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstPendingOrders.FormattingEnabled = true;
            lstPendingOrders.Location = new Point(10, 69);
            lstPendingOrders.Margin = new Padding(3, 4, 3, 4);
            lstPendingOrders.Name = "lstPendingOrders";
            lstPendingOrders.Size = new Size(469, 602);
            lstPendingOrders.TabIndex = 3;
            // 
            // btnStartDelivery
            // 
            btnStartDelivery.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartDelivery.BackColor = Color.FromArgb(0, 122, 204);
            btnStartDelivery.FlatStyle = FlatStyle.Flat;
            btnStartDelivery.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStartDelivery.ForeColor = Color.White;
            btnStartDelivery.Location = new Point(10, 729);
            btnStartDelivery.Margin = new Padding(3, 4, 3, 4);
            btnStartDelivery.Name = "btnStartDelivery";
            btnStartDelivery.Size = new Size(469, 62);
            btnStartDelivery.TabIndex = 4;
            btnStartDelivery.Text = "GIAO HÀNG";
            btnStartDelivery.UseVisualStyleBackColor = false;
            // 
            // tabDelivering
            // 
            tabDelivering.Controls.Add(lblSearchDelivering);
            tabDelivering.Controls.Add(txtSearchDelivering);
            tabDelivering.Controls.Add(btnRefreshDelivering);
            tabDelivering.Controls.Add(lstDeliveringOrders);
            tabDelivering.Controls.Add(btnConfirmSuccess);
            tabDelivering.Controls.Add(lblReturnReason);
            tabDelivering.Controls.Add(txtReturnReason);
            tabDelivering.Controls.Add(btnConfirmReturn);
            tabDelivering.Location = new Point(4, 32);
            tabDelivering.Margin = new Padding(3, 4, 3, 4);
            tabDelivering.Name = "tabDelivering";
            tabDelivering.Padding = new Padding(10, 12, 10, 12);
            tabDelivering.Size = new Size(492, 814);
            tabDelivering.TabIndex = 1;
            tabDelivering.Text = "Đang giao";
            tabDelivering.UseVisualStyleBackColor = true;
            // 
            // lblSearchDelivering
            // 
            lblSearchDelivering.AutoSize = true;
            lblSearchDelivering.Location = new Point(10, 19);
            lblSearchDelivering.Name = "lblSearchDelivering";
            lblSearchDelivering.Size = new Size(88, 25);
            lblSearchDelivering.TabIndex = 0;
            lblSearchDelivering.Text = "Tìm kiếm:";
            // 
            // txtSearchDelivering
            // 
            txtSearchDelivering.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchDelivering.Location = new Point(105, 14);
            txtSearchDelivering.Margin = new Padding(3, 4, 3, 4);
            txtSearchDelivering.Name = "txtSearchDelivering";
            txtSearchDelivering.Size = new Size(260, 31);
            txtSearchDelivering.TabIndex = 1;
            // 
            // btnRefreshDelivering
            // 
            btnRefreshDelivering.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshDelivering.BackColor = Color.FromArgb(108, 117, 125);
            btnRefreshDelivering.Cursor = Cursors.Hand;
            btnRefreshDelivering.FlatStyle = FlatStyle.Flat;
            btnRefreshDelivering.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshDelivering.ForeColor = Color.White;
            btnRefreshDelivering.Location = new Point(375, 12);
            btnRefreshDelivering.Name = "btnRefreshDelivering";
            btnRefreshDelivering.Size = new Size(105, 34);
            btnRefreshDelivering.TabIndex = 2;
            btnRefreshDelivering.Text = "TẢI LẠI";
            btnRefreshDelivering.UseVisualStyleBackColor = false;
            // 
            // lstDeliveringOrders
            // 
            lstDeliveringOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstDeliveringOrders.FormattingEnabled = true;
            lstDeliveringOrders.Location = new Point(10, 69);
            lstDeliveringOrders.Margin = new Padding(3, 4, 3, 4);
            lstDeliveringOrders.Name = "lstDeliveringOrders";
            lstDeliveringOrders.Size = new Size(469, 395);
            lstDeliveringOrders.TabIndex = 3;
            // 
            // btnConfirmSuccess
            // 
            btnConfirmSuccess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmSuccess.BackColor = Color.FromArgb(16, 94, 26);
            btnConfirmSuccess.FlatStyle = FlatStyle.Flat;
            btnConfirmSuccess.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnConfirmSuccess.ForeColor = Color.White;
            btnConfirmSuccess.Location = new Point(10, 502);
            btnConfirmSuccess.Margin = new Padding(3, 4, 3, 4);
            btnConfirmSuccess.Name = "btnConfirmSuccess";
            btnConfirmSuccess.Size = new Size(469, 56);
            btnConfirmSuccess.TabIndex = 4;
            btnConfirmSuccess.Text = "XÁC NHẬN GIAO THÀNH CÔNG";
            btnConfirmSuccess.UseVisualStyleBackColor = false;
            // 
            // lblReturnReason
            // 
            lblReturnReason.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblReturnReason.AutoSize = true;
            lblReturnReason.Location = new Point(10, 571);
            lblReturnReason.Name = "lblReturnReason";
            lblReturnReason.Size = new Size(130, 25);
            lblReturnReason.TabIndex = 5;
            lblReturnReason.Text = "Lý do trả hàng:";
            // 
            // txtReturnReason
            // 
            txtReturnReason.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReturnReason.Location = new Point(10, 609);
            txtReturnReason.Margin = new Padding(3, 4, 3, 4);
            txtReturnReason.Multiline = true;
            txtReturnReason.Name = "txtReturnReason";
            txtReturnReason.Size = new Size(469, 105);
            txtReturnReason.TabIndex = 6;
            // 
            // btnConfirmReturn
            // 
            btnConfirmReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmReturn.BackColor = Color.FromArgb(192, 0, 0);
            btnConfirmReturn.FlatStyle = FlatStyle.Flat;
            btnConfirmReturn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnConfirmReturn.ForeColor = Color.White;
            btnConfirmReturn.Location = new Point(10, 728);
            btnConfirmReturn.Margin = new Padding(3, 4, 3, 4);
            btnConfirmReturn.Name = "btnConfirmReturn";
            btnConfirmReturn.Size = new Size(469, 56);
            btnConfirmReturn.TabIndex = 7;
            btnConfirmReturn.Text = "XÁC NHẬN TRẢ HÀNG";
            btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(lblSearchHistory);
            tabHistory.Controls.Add(txtSearchHistory);
            tabHistory.Controls.Add(btnRefreshHistory);
            tabHistory.Controls.Add(dgvDeliveryHistory);
            tabHistory.Location = new Point(4, 32);
            tabHistory.Margin = new Padding(3, 4, 3, 4);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(10, 12, 10, 12);
            tabHistory.Size = new Size(492, 814);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Lịch sử giao hàng";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // lblSearchHistory
            // 
            lblSearchHistory.AutoSize = true;
            lblSearchHistory.Location = new Point(10, 19);
            lblSearchHistory.Name = "lblSearchHistory";
            lblSearchHistory.Size = new Size(88, 25);
            lblSearchHistory.TabIndex = 0;
            lblSearchHistory.Text = "Tìm kiếm:";
            // 
            // txtSearchHistory
            // 
            txtSearchHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchHistory.Location = new Point(105, 14);
            txtSearchHistory.Margin = new Padding(3, 4, 3, 4);
            txtSearchHistory.Name = "txtSearchHistory";
            txtSearchHistory.Size = new Size(260, 31);
            txtSearchHistory.TabIndex = 1;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshHistory.BackColor = Color.FromArgb(108, 117, 125);
            btnRefreshHistory.Cursor = Cursors.Hand;
            btnRefreshHistory.FlatStyle = FlatStyle.Flat;
            btnRefreshHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshHistory.ForeColor = Color.White;
            btnRefreshHistory.Location = new Point(375, 12);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(105, 34);
            btnRefreshHistory.TabIndex = 2;
            btnRefreshHistory.Text = "TẢI LẠI";
            btnRefreshHistory.UseVisualStyleBackColor = false;
            // 
            // dgvDeliveryHistory
            // 
            dgvDeliveryHistory.AllowUserToAddRows = false;
            dgvDeliveryHistory.AllowUserToDeleteRows = false;
            dgvDeliveryHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDeliveryHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeliveryHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveryHistory.Location = new Point(10, 69);
            dgvDeliveryHistory.Margin = new Padding(3, 4, 3, 4);
            dgvDeliveryHistory.Name = "dgvDeliveryHistory";
            dgvDeliveryHistory.ReadOnly = true;
            dgvDeliveryHistory.RowHeadersVisible = false;
            dgvDeliveryHistory.RowHeadersWidth = 51;
            dgvDeliveryHistory.RowTemplate.Height = 28;
            dgvDeliveryHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveryHistory.Size = new Size(469, 721);
            dgvDeliveryHistory.TabIndex = 3;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.FromArgb(253, 253, 253);
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(txtHistoryReturnReason);
            pnlDetails.Controls.Add(lblHistoryReturnReason);
            pnlDetails.Controls.Add(txtActualDeliveryDate);
            pnlDetails.Controls.Add(lblActualDeliveryDate);
            pnlDetails.Controls.Add(txtDeliveryStatus);
            pnlDetails.Controls.Add(lblDeliveryStatus);
            pnlDetails.Controls.Add(txtInvoiceDate);
            pnlDetails.Controls.Add(lblInvoiceDate);
            pnlDetails.Controls.Add(txtExpectedDate);
            pnlDetails.Controls.Add(lblExpectedDate);
            pnlDetails.Controls.Add(txtAddress);
            pnlDetails.Controls.Add(lblAddress);
            pnlDetails.Controls.Add(txtPhone);
            pnlDetails.Controls.Add(lblPhone);
            pnlDetails.Controls.Add(txtCustomerName);
            pnlDetails.Controls.Add(lblCustomerName);
            pnlDetails.Controls.Add(lblOrderTitle);
            pnlDetails.Dock = DockStyle.Fill;
            pnlDetails.Font = new Font("Segoe UI", 10.5F);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Margin = new Padding(3, 4, 3, 4);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Padding = new Padding(20, 25, 20, 25);
            pnlDetails.Size = new Size(756, 851);
            pnlDetails.TabIndex = 0;
            // 
            // txtHistoryReturnReason
            // 
            txtHistoryReturnReason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHistoryReturnReason.Location = new Point(180, 531);
            txtHistoryReturnReason.Margin = new Padding(3, 4, 3, 4);
            txtHistoryReturnReason.Multiline = true;
            txtHistoryReturnReason.Name = "txtHistoryReturnReason";
            txtHistoryReturnReason.ReadOnly = true;
            txtHistoryReturnReason.Size = new Size(545, 275);
            txtHistoryReturnReason.TabIndex = 16;
            // 
            // lblHistoryReturnReason
            // 
            lblHistoryReturnReason.AutoSize = true;
            lblHistoryReturnReason.Location = new Point(20, 538);
            lblHistoryReturnReason.Name = "lblHistoryReturnReason";
            lblHistoryReturnReason.Size = new Size(132, 25);
            lblHistoryReturnReason.TabIndex = 15;
            lblHistoryReturnReason.Text = "Lý do hoàn/trả:";
            // 
            // txtActualDeliveryDate
            // 
            txtActualDeliveryDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtActualDeliveryDate.Location = new Point(180, 469);
            txtActualDeliveryDate.Margin = new Padding(3, 4, 3, 4);
            txtActualDeliveryDate.Name = "txtActualDeliveryDate";
            txtActualDeliveryDate.ReadOnly = true;
            txtActualDeliveryDate.Size = new Size(545, 31);
            txtActualDeliveryDate.TabIndex = 14;
            // 
            // lblActualDeliveryDate
            // 
            lblActualDeliveryDate.AutoSize = true;
            lblActualDeliveryDate.Location = new Point(20, 475);
            lblActualDeliveryDate.Name = "lblActualDeliveryDate";
            lblActualDeliveryDate.Size = new Size(126, 25);
            lblActualDeliveryDate.TabIndex = 13;
            lblActualDeliveryDate.Text = "Ngày giao/trả:";
            // 
            // txtDeliveryStatus
            // 
            txtDeliveryStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDeliveryStatus.Location = new Point(180, 406);
            txtDeliveryStatus.Margin = new Padding(3, 4, 3, 4);
            txtDeliveryStatus.Name = "txtDeliveryStatus";
            txtDeliveryStatus.ReadOnly = true;
            txtDeliveryStatus.Size = new Size(545, 31);
            txtDeliveryStatus.TabIndex = 12;
            // 
            // lblDeliveryStatus
            // 
            lblDeliveryStatus.AutoSize = true;
            lblDeliveryStatus.Location = new Point(20, 412);
            lblDeliveryStatus.Name = "lblDeliveryStatus";
            lblDeliveryStatus.Size = new Size(93, 25);
            lblDeliveryStatus.TabIndex = 11;
            lblDeliveryStatus.Text = "Trạng thái:";
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInvoiceDate.Location = new Point(180, 344);
            txtInvoiceDate.Margin = new Padding(3, 4, 3, 4);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.ReadOnly = true;
            txtInvoiceDate.Size = new Size(545, 31);
            txtInvoiceDate.TabIndex = 10;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(20, 350);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(168, 25);
            lblInvoiceDate.TabIndex = 9;
            lblInvoiceDate.Text = "Ngày lập hóa đơn:";
            // 
            // txtExpectedDate
            // 
            txtExpectedDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExpectedDate.Location = new Point(180, 281);
            txtExpectedDate.Margin = new Padding(3, 4, 3, 4);
            txtExpectedDate.Name = "txtExpectedDate";
            txtExpectedDate.ReadOnly = true;
            txtExpectedDate.Size = new Size(545, 31);
            txtExpectedDate.TabIndex = 8;
            // 
            // lblExpectedDate
            // 
            lblExpectedDate.AutoSize = true;
            lblExpectedDate.Location = new Point(20, 288);
            lblExpectedDate.Name = "lblExpectedDate";
            lblExpectedDate.Size = new Size(162, 25);
            lblExpectedDate.TabIndex = 7;
            lblExpectedDate.Text = "Ngày giao dự kiến:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(180, 219);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(545, 31);
            txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 225);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(154, 25);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ giao hàng:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(180, 156);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(545, 31);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 162);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(121, 25);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Location = new Point(180, 94);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(545, 31);
            txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 100);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(138, 25);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Tên người nhận:";
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrderTitle.ForeColor = Color.FromArgb(16, 94, 26);
            lblOrderTitle.Location = new Point(20, 25);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(422, 32);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Thông tin vận chuyển đơn hàng: ---";
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 248, 243);
            ClientSize = new Size(1280, 875);
            Controls.Add(splitMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeliveryForm";
            Padding = new Padding(10, 12, 10, 12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Giao hàng";
            WindowState = FormWindowState.Maximized;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tabControlDelivery.ResumeLayout(false);
            tabPending.ResumeLayout(false);
            tabPending.PerformLayout();
            tabDelivering.ResumeLayout(false);
            tabDelivering.PerformLayout();
            tabHistory.ResumeLayout(false);
            tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveryHistory).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Main Layout Container
        private System.Windows.Forms.SplitContainer splitMain;

        // Tabs
        private System.Windows.Forms.TabControl tabControlDelivery;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabDelivering;
        private System.Windows.Forms.TabPage tabHistory;

        // Tab Pending Controls
        private System.Windows.Forms.Label lblSearchPending;
        private System.Windows.Forms.TextBox txtSearchPending;
        private System.Windows.Forms.Button btnRefreshPending;
        private System.Windows.Forms.ListBox lstPendingOrders;
        private System.Windows.Forms.Button btnStartDelivery;

        // Tab Delivering Controls
        private System.Windows.Forms.Label lblSearchDelivering;
        private System.Windows.Forms.TextBox txtSearchDelivering;
        private System.Windows.Forms.Button btnRefreshDelivering;
        private System.Windows.Forms.ListBox lstDeliveringOrders;
        private System.Windows.Forms.Button btnConfirmSuccess;
        private System.Windows.Forms.Label lblReturnReason;
        private System.Windows.Forms.TextBox txtReturnReason;
        private System.Windows.Forms.Button btnConfirmReturn;

        // Tab History Controls
        private System.Windows.Forms.Label lblSearchHistory;
        private System.Windows.Forms.TextBox txtSearchHistory;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.DataGridView dgvDeliveryHistory;

        // Shared Panel Controls
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.TextBox txtExpectedDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceDate;

        // Các Control bổ sung thêm cho Lịch sử / Chi tiết đơn
        private System.Windows.Forms.Label lblDeliveryStatus;
        private System.Windows.Forms.TextBox txtDeliveryStatus;
        private System.Windows.Forms.Label lblActualDeliveryDate;
        private System.Windows.Forms.TextBox txtActualDeliveryDate;
        private System.Windows.Forms.Label lblHistoryReturnReason;
        private System.Windows.Forms.TextBox txtHistoryReturnReason;
    }
}