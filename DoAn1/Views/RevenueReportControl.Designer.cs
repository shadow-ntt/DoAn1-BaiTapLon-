namespace DoAn1.Views
{
    partial class RevenueReportControl
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
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.dgvGeneralRevenue = new System.Windows.Forms.DataGridView();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardAvg = new System.Windows.Forms.Panel();
            this.lblCardAvgVal = new System.Windows.Forms.Label();
            this.lblCardAvgTitle = new System.Windows.Forms.Label();
            this.cardCount = new System.Windows.Forms.Panel();
            this.lblCardCountVal = new System.Windows.Forms.Label();
            this.lblCardCountTitle = new System.Windows.Forms.Label();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblCardTotalVal = new System.Windows.Forms.Label();
            this.lblCardTotalTitle = new System.Windows.Forms.Label();
            this.panelGenTop = new System.Windows.Forms.Panel();
            this.btnExportGenExcel = new System.Windows.Forms.Button();
            this.btnFilterGen = new System.Windows.Forms.Button();
            this.txtSearchGen = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgvCustomerRevenue = new System.Windows.Forms.DataGridView();
            this.panelCustTop = new System.Windows.Forms.Panel();
            this.btnExportCustExcel = new System.Windows.Forms.Button();
            this.btnFilterCust = new System.Windows.Forms.Button();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.dtpToDateCust = new System.Windows.Forms.DateTimePicker();
            this.lblToDateCust = new System.Windows.Forms.Label();
            this.dtpFromDateCust = new System.Windows.Forms.DateTimePicker();
            this.lblFromDateCust = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgvProductRevenue = new System.Windows.Forms.DataGridView();
            this.panelProdTop = new System.Windows.Forms.Panel();
            this.btnExportProdExcel = new System.Windows.Forms.Button();
            this.btnFilterProd = new System.Windows.Forms.Button();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.dtpToDateProd = new System.Windows.Forms.DateTimePicker();
            this.lblToDateProd = new System.Windows.Forms.Label();
            this.dtpFromDateProd = new System.Windows.Forms.DateTimePicker();
            this.lblFromDateProd = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralRevenue)).BeginInit();
            this.panelCards.SuspendLayout();
            this.cardAvg.SuspendLayout();
            this.cardCount.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.panelGenTop.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRevenue)).BeginInit();
            this.panelCustTop.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRevenue)).BeginInit();
            this.panelProdTop.SuspendLayout();
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
            this.lblHeader.Text = "BÁO CÁO THỐNG KÊ DOANH THU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabGeneral);
            this.tabControlMain.Controls.Add(this.tabCustomer);
            this.tabControlMain.Controls.Add(this.tabProduct);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.tabControlMain.Location = new System.Drawing.Point(0, 45);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(950, 555);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.dgvGeneralRevenue);
            this.tabGeneral.Controls.Add(this.panelCards);
            this.tabGeneral.Controls.Add(this.panelGenTop);
            this.tabGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(942, 525);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Tổng quan doanh thu";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // dgvGeneralRevenue
            // 
            this.dgvGeneralRevenue.AllowUserToAddRows = false;
            this.dgvGeneralRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeneralRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvGeneralRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeneralRevenue.Location = new System.Drawing.Point(3, 110);
            this.dgvGeneralRevenue.Name = "dgvGeneralRevenue";
            this.dgvGeneralRevenue.ReadOnly = true;
            this.dgvGeneralRevenue.Size = new System.Drawing.Size(936, 412);
            this.dgvGeneralRevenue.TabIndex = 2;
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.White;
            this.panelCards.Controls.Add(this.cardAvg);
            this.panelCards.Controls.Add(this.cardCount);
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(3, 45);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelCards.Size = new System.Drawing.Size(936, 65);
            this.panelCards.TabIndex = 1;
            // 
            // cardAvg
            // 
            this.cardAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.cardAvg.Controls.Add(this.lblCardAvgVal);
            this.cardAvg.Controls.Add(this.lblCardAvgTitle);
            this.cardAvg.Location = new System.Drawing.Point(396, 5);
            this.cardAvg.Name = "cardAvg";
            this.cardAvg.Size = new System.Drawing.Size(200, 53);
            this.cardAvg.TabIndex = 2;
            // 
            // lblCardAvgVal
            // 
            this.lblCardAvgVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardAvgVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardAvgVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardAvgVal.Name = "lblCardAvgVal";
            this.lblCardAvgVal.Size = new System.Drawing.Size(184, 25);
            this.lblCardAvgVal.TabIndex = 1;
            this.lblCardAvgVal.Text = "0 VNĐ";
            // 
            // lblCardAvgTitle
            // 
            this.lblCardAvgTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardAvgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblCardAvgTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardAvgTitle.Name = "lblCardAvgTitle";
            this.lblCardAvgTitle.Size = new System.Drawing.Size(184, 18);
            this.lblCardAvgTitle.TabIndex = 0;
            this.lblCardAvgTitle.Text = "TRUNG BÌNH/ĐƠN";
            // 
            // cardCount
            // 
            this.cardCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.cardCount.Controls.Add(this.lblCardCountVal);
            this.cardCount.Controls.Add(this.lblCardCountTitle);
            this.cardCount.Location = new System.Drawing.Point(218, 5);
            this.cardCount.Name = "cardCount";
            this.cardCount.Size = new System.Drawing.Size(170, 53);
            this.cardCount.TabIndex = 1;
            // 
            // lblCardCountVal
            // 
            this.lblCardCountVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardCountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardCountVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardCountVal.Name = "lblCardCountVal";
            this.lblCardCountVal.Size = new System.Drawing.Size(154, 25);
            this.lblCardCountVal.TabIndex = 1;
            this.lblCardCountVal.Text = "0 Hóa đơn";
            // 
            // lblCardCountTitle
            // 
            this.lblCardCountTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblCardCountTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardCountTitle.Name = "lblCardCountTitle";
            this.lblCardCountTitle.Size = new System.Drawing.Size(154, 18);
            this.lblCardCountTitle.TabIndex = 0;
            this.lblCardCountTitle.Text = "ĐƠN HOÀN THÀNH";
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cardTotal.Controls.Add(this.lblCardTotalVal);
            this.cardTotal.Controls.Add(this.lblCardTotalTitle);
            this.cardTotal.Location = new System.Drawing.Point(10, 5);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(200, 53);
            this.cardTotal.TabIndex = 0;
            // 
            // lblCardTotalVal
            // 
            this.lblCardTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardTotalVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardTotalVal.Name = "lblCardTotalVal";
            this.lblCardTotalVal.Size = new System.Drawing.Size(184, 25);
            this.lblCardTotalVal.TabIndex = 1;
            this.lblCardTotalVal.Text = "0 VNĐ";
            // 
            // lblCardTotalTitle
            // 
            this.lblCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblCardTotalTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardTotalTitle.Name = "lblCardTotalTitle";
            this.lblCardTotalTitle.Size = new System.Drawing.Size(184, 18);
            this.lblCardTotalTitle.TabIndex = 0;
            this.lblCardTotalTitle.Text = "TỔNG DOANH THU";
            // 
            // panelGenTop
            // 
            this.panelGenTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelGenTop.Controls.Add(this.btnExportGenExcel);
            this.panelGenTop.Controls.Add(this.btnFilterGen);
            this.panelGenTop.Controls.Add(this.txtSearchGen);
            this.panelGenTop.Controls.Add(this.dtpToDate);
            this.panelGenTop.Controls.Add(this.lblToDate);
            this.panelGenTop.Controls.Add(this.dtpFromDate);
            this.panelGenTop.Controls.Add(this.lblFromDate);
            this.panelGenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenTop.Location = new System.Drawing.Point(3, 3);
            this.panelGenTop.Name = "panelGenTop";
            this.panelGenTop.Size = new System.Drawing.Size(936, 42);
            this.panelGenTop.TabIndex = 0;
            // 
            // btnExportGenExcel
            // 
            this.btnExportGenExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportGenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportGenExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportGenExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportGenExcel.Location = new System.Drawing.Point(578, 7);
            this.btnExportGenExcel.Name = "btnExportGenExcel";
            this.btnExportGenExcel.Size = new System.Drawing.Size(100, 26);
            this.btnExportGenExcel.TabIndex = 6;
            this.btnExportGenExcel.Text = "📊 Xuất Excel";
            this.btnExportGenExcel.UseVisualStyleBackColor = false;
            // 
            // btnFilterGen
            // 
            this.btnFilterGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterGen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterGen.ForeColor = System.Drawing.Color.White;
            this.btnFilterGen.Location = new System.Drawing.Point(502, 7);
            this.btnFilterGen.Name = "btnFilterGen";
            this.btnFilterGen.Size = new System.Drawing.Size(70, 26);
            this.btnFilterGen.TabIndex = 5;
            this.btnFilterGen.Text = "Lọc";
            this.btnFilterGen.UseVisualStyleBackColor = false;
            // 
            // txtSearchGen
            // 
            this.txtSearchGen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchGen.Location = new System.Drawing.Point(345, 8);
            this.txtSearchGen.Name = "txtSearchGen";
            this.txtSearchGen.PlaceholderText = "Tìm mã đơn, KH...";
            this.txtSearchGen.Size = new System.Drawing.Size(150, 23);
            this.txtSearchGen.TabIndex = 4;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(223, 8);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(115, 23);
            this.dtpToDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDate.Location = new System.Drawing.Point(188, 11);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(35, 22);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Đến:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(65, 8);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(115, 23);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.Location = new System.Drawing.Point(10, 11);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(55, 22);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Từ ngày:";
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.dgvCustomerRevenue);
            this.tabCustomer.Controls.Add(this.panelCustTop);
            this.tabCustomer.Location = new System.Drawing.Point(4, 26);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(942, 525);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Theo Khách Hàng";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerRevenue
            // 
            this.dgvCustomerRevenue.AllowUserToAddRows = false;
            this.dgvCustomerRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerRevenue.Location = new System.Drawing.Point(3, 45);
            this.dgvCustomerRevenue.Name = "dgvCustomerRevenue";
            this.dgvCustomerRevenue.ReadOnly = true;
            this.dgvCustomerRevenue.Size = new System.Drawing.Size(936, 477);
            this.dgvCustomerRevenue.TabIndex = 1;
            // 
            // panelCustTop
            // 
            this.panelCustTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelCustTop.Controls.Add(this.btnExportCustExcel);
            this.panelCustTop.Controls.Add(this.btnFilterCust);
            this.panelCustTop.Controls.Add(this.txtSearchCust);
            this.panelCustTop.Controls.Add(this.dtpToDateCust);
            this.panelCustTop.Controls.Add(this.lblToDateCust);
            this.panelCustTop.Controls.Add(this.dtpFromDateCust);
            this.panelCustTop.Controls.Add(this.lblFromDateCust);
            this.panelCustTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustTop.Location = new System.Drawing.Point(3, 3);
            this.panelCustTop.Name = "panelCustTop";
            this.panelCustTop.Size = new System.Drawing.Size(936, 42);
            this.panelCustTop.TabIndex = 0;
            // 
            // btnExportCustExcel
            // 
            this.btnExportCustExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportCustExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCustExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCustExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportCustExcel.Location = new System.Drawing.Point(578, 7);
            this.btnExportCustExcel.Name = "btnExportCustExcel";
            this.btnExportCustExcel.Size = new System.Drawing.Size(100, 26);
            this.btnExportCustExcel.TabIndex = 6;
            this.btnExportCustExcel.Text = "📊 Xuất Excel";
            this.btnExportCustExcel.UseVisualStyleBackColor = false;
            // 
            // btnFilterCust
            // 
            this.btnFilterCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterCust.ForeColor = System.Drawing.Color.White;
            this.btnFilterCust.Location = new System.Drawing.Point(502, 7);
            this.btnFilterCust.Name = "btnFilterCust";
            this.btnFilterCust.Size = new System.Drawing.Size(70, 26);
            this.btnFilterCust.TabIndex = 5;
            this.btnFilterCust.Text = "Lọc";
            this.btnFilterCust.UseVisualStyleBackColor = false;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCust.Location = new System.Drawing.Point(345, 8);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.PlaceholderText = "Tìm tên KH, MST...";
            this.txtSearchCust.Size = new System.Drawing.Size(150, 23);
            this.txtSearchCust.TabIndex = 4;
            // 
            // dtpToDateCust
            // 
            this.dtpToDateCust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDateCust.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDateCust.Location = new System.Drawing.Point(223, 8);
            this.dtpToDateCust.Name = "dtpToDateCust";
            this.dtpToDateCust.Size = new System.Drawing.Size(115, 23);
            this.dtpToDateCust.TabIndex = 3;
            // 
            // lblToDateCust
            // 
            this.lblToDateCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDateCust.Location = new System.Drawing.Point(188, 11);
            this.lblToDateCust.Name = "lblToDateCust";
            this.lblToDateCust.Size = new System.Drawing.Size(35, 22);
            this.lblToDateCust.TabIndex = 2;
            this.lblToDateCust.Text = "Đến:";
            // 
            // dtpFromDateCust
            // 
            this.dtpFromDateCust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDateCust.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDateCust.Location = new System.Drawing.Point(65, 8);
            this.dtpFromDateCust.Name = "dtpFromDateCust";
            this.dtpFromDateCust.Size = new System.Drawing.Size(115, 23);
            this.dtpFromDateCust.TabIndex = 1;
            // 
            // lblFromDateCust
            // 
            this.lblFromDateCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDateCust.Location = new System.Drawing.Point(10, 11);
            this.lblFromDateCust.Name = "lblFromDateCust";
            this.lblFromDateCust.Size = new System.Drawing.Size(55, 22);
            this.lblFromDateCust.TabIndex = 0;
            this.lblFromDateCust.Text = "Từ ngày:";
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgvProductRevenue);
            this.tabProduct.Controls.Add(this.panelProdTop);
            this.tabProduct.Location = new System.Drawing.Point(4, 26);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(942, 525);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Theo Sản Phẩm";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProductRevenue
            // 
            this.dgvProductRevenue.AllowUserToAddRows = false;
            this.dgvProductRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductRevenue.Location = new System.Drawing.Point(3, 45);
            this.dgvProductRevenue.Name = "dgvProductRevenue";
            this.dgvProductRevenue.ReadOnly = true;
            this.dgvProductRevenue.Size = new System.Drawing.Size(936, 477);
            this.dgvProductRevenue.TabIndex = 1;
            // 
            // panelProdTop
            // 
            this.panelProdTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelProdTop.Controls.Add(this.btnExportProdExcel);
            this.panelProdTop.Controls.Add(this.btnFilterProd);
            this.panelProdTop.Controls.Add(this.txtSearchProd);
            this.panelProdTop.Controls.Add(this.dtpToDateProd);
            this.panelProdTop.Controls.Add(this.lblToDateProd);
            this.panelProdTop.Controls.Add(this.dtpFromDateProd);
            this.panelProdTop.Controls.Add(this.lblFromDateProd);
            this.panelProdTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdTop.Location = new System.Drawing.Point(3, 3);
            this.panelProdTop.Name = "panelProdTop";
            this.panelProdTop.Size = new System.Drawing.Size(936, 42);
            this.panelProdTop.TabIndex = 0;
            // 
            // btnExportProdExcel
            // 
            this.btnExportProdExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportProdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProdExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportProdExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportProdExcel.Location = new System.Drawing.Point(578, 7);
            this.btnExportProdExcel.Name = "btnExportProdExcel";
            this.btnExportProdExcel.Size = new System.Drawing.Size(100, 26);
            this.btnExportProdExcel.TabIndex = 6;
            this.btnExportProdExcel.Text = "📊 Xuất Excel";
            this.btnExportProdExcel.UseVisualStyleBackColor = false;
            // 
            // btnFilterProd
            // 
            this.btnFilterProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterProd.ForeColor = System.Drawing.Color.White;
            this.btnFilterProd.Location = new System.Drawing.Point(502, 7);
            this.btnFilterProd.Name = "btnFilterProd";
            this.btnFilterProd.Size = new System.Drawing.Size(70, 26);
            this.btnFilterProd.TabIndex = 5;
            this.btnFilterProd.Text = "Lọc";
            this.btnFilterProd.UseVisualStyleBackColor = false;
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchProd.Location = new System.Drawing.Point(345, 8);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.PlaceholderText = "Tìm tên SP, loại...";
            this.txtSearchProd.Size = new System.Drawing.Size(150, 23);
            this.txtSearchProd.TabIndex = 4;
            // 
            // dtpToDateProd
            // 
            this.dtpToDateProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDateProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDateProd.Location = new System.Drawing.Point(223, 8);
            this.dtpToDateProd.Name = "dtpToDateProd";
            this.dtpToDateProd.Size = new System.Drawing.Size(115, 23);
            this.dtpToDateProd.TabIndex = 3;
            // 
            // lblToDateProd
            // 
            this.lblToDateProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDateProd.Location = new System.Drawing.Point(188, 11);
            this.lblToDateProd.Name = "lblToDateProd";
            this.lblToDateProd.Size = new System.Drawing.Size(35, 22);
            this.lblToDateProd.TabIndex = 2;
            this.lblToDateProd.Text = "Đến:";
            // 
            // dtpFromDateProd
            // 
            this.dtpFromDateProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDateProd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDateProd.Location = new System.Drawing.Point(65, 8);
            this.dtpFromDateProd.Name = "dtpFromDateProd";
            this.dtpFromDateProd.Size = new System.Drawing.Size(115, 23);
            this.dtpFromDateProd.TabIndex = 1;
            // 
            // lblFromDateProd
            // 
            this.lblFromDateProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDateProd.Location = new System.Drawing.Point(10, 11);
            this.lblFromDateProd.Name = "lblFromDateProd";
            this.lblFromDateProd.Size = new System.Drawing.Size(55, 22);
            this.lblFromDateProd.TabIndex = 0;
            this.lblFromDateProd.Text = "Từ ngày:";
            // 
            // RevenueReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "RevenueReportControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralRevenue)).EndInit();
            this.panelCards.ResumeLayout(false);
            this.cardAvg.ResumeLayout(false);
            this.cardCount.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.panelGenTop.ResumeLayout(false);
            this.panelGenTop.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRevenue)).EndInit();
            this.panelCustTop.ResumeLayout(false);
            this.panelCustTop.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRevenue)).EndInit();
            this.panelProdTop.ResumeLayout(false);
            this.panelProdTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Panel panelGenTop;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtSearchGen;
        private System.Windows.Forms.Button btnFilterGen;
        private System.Windows.Forms.Button btnExportGenExcel;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label lblCardTotalTitle;
        private System.Windows.Forms.Label lblCardTotalVal;
        private System.Windows.Forms.Panel cardCount;
        private System.Windows.Forms.Label lblCardCountTitle;
        private System.Windows.Forms.Label lblCardCountVal;
        private System.Windows.Forms.Panel cardAvg;
        private System.Windows.Forms.Label lblCardAvgTitle;
        private System.Windows.Forms.Label lblCardAvgVal;
        private System.Windows.Forms.DataGridView dgvGeneralRevenue;
        private System.Windows.Forms.Panel panelCustTop;
        private System.Windows.Forms.Label lblFromDateCust;
        private System.Windows.Forms.DateTimePicker dtpFromDateCust;
        private System.Windows.Forms.Label lblToDateCust;
        private System.Windows.Forms.DateTimePicker dtpToDateCust;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Button btnFilterCust;
        private System.Windows.Forms.Button btnExportCustExcel;
        private System.Windows.Forms.DataGridView dgvCustomerRevenue;
        private System.Windows.Forms.Panel panelProdTop;
        private System.Windows.Forms.Label lblFromDateProd;
        private System.Windows.Forms.DateTimePicker dtpFromDateProd;
        private System.Windows.Forms.Label lblToDateProd;
        private System.Windows.Forms.DateTimePicker dtpToDateProd;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.Button btnFilterProd;
        private System.Windows.Forms.Button btnExportProdExcel;
        private System.Windows.Forms.DataGridView dgvProductRevenue;
    }
}
