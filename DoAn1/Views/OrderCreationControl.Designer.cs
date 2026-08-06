namespace DoAn1.Views
{
    partial class OrderCreationControl
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
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.gbItemInput = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.btnDeleteCartItem = new System.Windows.Forms.Button();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panelCartBottom = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbItemInput.SuspendLayout();
            this.gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panelCartBottom.SuspendLayout();
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
            this.lblHeader.Text = "TẠO ĐƠN ĐẶT HÀNG MỚI (GIAO DỊCH VIÊN)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 45);
            this.splitMain.Name = "splitMain";
            this.splitMain.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.gbItemInput);
            this.splitMain.Panel1.Controls.Add(this.gbCustomer);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.gbCart);
            this.splitMain.Size = new System.Drawing.Size(950, 555);
            this.splitMain.SplitterDistance = 250;
            this.splitMain.TabIndex = 1;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblIdentity);
            this.gbCustomer.Controls.Add(this.txtIdentity);
            this.gbCustomer.Controls.Add(this.btnSearchCustomer);
            this.gbCustomer.Controls.Add(this.lblCustInfo);
            this.gbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbCustomer.Location = new System.Drawing.Point(0, 0);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(8);
            this.gbCustomer.Size = new System.Drawing.Size(250, 150);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "1. Thông Tin Khách Hàng";
            // 
            // lblIdentity
            // 
            this.lblIdentity.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblIdentity.Location = new System.Drawing.Point(8, 25);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(80, 22);
            this.lblIdentity.TabIndex = 0;
            this.lblIdentity.Text = "CMND/CCCD:";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtIdentity.Location = new System.Drawing.Point(90, 22);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(90, 23);
            this.txtIdentity.TabIndex = 1;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(185, 21);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(50, 25);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Tìm";
            this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCustInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCustInfo.Location = new System.Drawing.Point(8, 52);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(230, 90);
            this.lblCustInfo.TabIndex = 3;
            this.lblCustInfo.Text = "Chưa chọn KH. Vui lòng nhập CMND/CCCD.";
            // 
            // gbItemInput
            // 
            this.gbItemInput.Controls.Add(this.lblProductId);
            this.gbItemInput.Controls.Add(this.txtProductId);
            this.gbItemInput.Controls.Add(this.lblQty);
            this.gbItemInput.Controls.Add(this.txtQty);
            this.gbItemInput.Controls.Add(this.lblDeliveryDate);
            this.gbItemInput.Controls.Add(this.dtpDelivery);
            this.gbItemInput.Controls.Add(this.btnAddToCart);
            this.gbItemInput.Controls.Add(this.btnUpdateCart);
            this.gbItemInput.Controls.Add(this.btnDeleteCartItem);
            this.gbItemInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbItemInput.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbItemInput.Location = new System.Drawing.Point(0, 150);
            this.gbItemInput.Name = "gbItemInput";
            this.gbItemInput.Padding = new System.Windows.Forms.Padding(8);
            this.gbItemInput.Size = new System.Drawing.Size(250, 405);
            this.gbItemInput.TabIndex = 1;
            this.gbItemInput.TabStop = false;
            this.gbItemInput.Text = "2. Chọn Hàng Hóa";
            // 
            // lblProductId
            // 
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProductId.Location = new System.Drawing.Point(8, 25);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(75, 22);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Mã SP:";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtProductId.Location = new System.Drawing.Point(85, 22);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(150, 23);
            this.txtProductId.TabIndex = 1;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblQty.Location = new System.Drawing.Point(8, 55);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(75, 22);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Số Lượng:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtQty.Location = new System.Drawing.Point(85, 52);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(150, 23);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "1";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryDate.Location = new System.Drawing.Point(8, 85);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(75, 22);
            this.lblDeliveryDate.TabIndex = 4;
            this.lblDeliveryDate.Text = "Ngày Giao:";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelivery.Location = new System.Drawing.Point(85, 82);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(150, 23);
            this.dtpDelivery.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(8, 120);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(70, 28);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "+ Giỏ";
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnUpdateCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCart.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCart.Location = new System.Drawing.Point(83, 120);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(70, 28);
            this.btnUpdateCart.TabIndex = 7;
            this.btnUpdateCart.Text = "Sửa";
            this.btnUpdateCart.Click += new System.EventHandler(this.BtnUpdateCart_Click);
            // 
            // btnDeleteCartItem
            // 
            this.btnDeleteCartItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteCartItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCartItem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCartItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCartItem.Location = new System.Drawing.Point(158, 120);
            this.btnDeleteCartItem.Name = "btnDeleteCartItem";
            this.btnDeleteCartItem.Size = new System.Drawing.Size(77, 28);
            this.btnDeleteCartItem.TabIndex = 8;
            this.btnDeleteCartItem.Text = "Xóa SP";
            this.btnDeleteCartItem.Click += new System.EventHandler(this.BtnDeleteCartItem_Click);
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.dgvCart);
            this.gbCart.Controls.Add(this.panelCartBottom);
            this.gbCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbCart.Location = new System.Drawing.Point(0, 0);
            this.gbCart.Name = "gbCart";
            this.gbCart.Padding = new System.Windows.Forms.Padding(10);
            this.gbCart.Size = new System.Drawing.Size(696, 555);
            this.gbCart.TabIndex = 0;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "3. Danh Sách Sản Phẩm Trong Giỏ Đặt Hàng";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(10, 28);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(676, 462);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.SelectionChanged += new System.EventHandler(this.DgvCart_SelectionChanged);
            // 
            // panelCartBottom
            // 
            this.panelCartBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelCartBottom.Controls.Add(this.lblTotalMoney);
            this.panelCartBottom.Controls.Add(this.btnSubmitOrder);
            this.panelCartBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCartBottom.Location = new System.Drawing.Point(10, 490);
            this.panelCartBottom.Name = "panelCartBottom";
            this.panelCartBottom.Padding = new System.Windows.Forms.Padding(10);
            this.panelCartBottom.Size = new System.Drawing.Size(676, 55);
            this.panelCartBottom.TabIndex = 1;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(10, 10);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(300, 35);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng tiền: 0 VNĐ";
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSubmitOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(446, 10);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(220, 35);
            this.btnSubmitOrder.TabIndex = 1;
            this.btnSubmitOrder.Text = "LƯU & GỬI ĐƠN ĐẶT HÀNG";
            this.btnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);
            // 
            // OrderCreationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "OrderCreationControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbItemInput.ResumeLayout(false);
            this.gbItemInput.PerformLayout();
            this.gbCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panelCartBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.GroupBox gbItemInput;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnUpdateCart;
        private System.Windows.Forms.Button btnDeleteCartItem;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panelCartBottom;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Button btnSubmitOrder;
    }
}
