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
            this.lblHeader.Text = "BÁO CÁO THỐNG KÊ DOANH THU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RevenueReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Name = "RevenueReportControl";
            this.Size = new System.Drawing.Size(950, 600);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void BuildGeneralView()
        {
            this.panelGenTop = new System.Windows.Forms.Panel();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchGen = new System.Windows.Forms.TextBox();
            this.btnFilterGen = new System.Windows.Forms.Button();
            this.btnExportGenExcel = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblCardTotalTitle = new System.Windows.Forms.Label();
            this.lblCardTotalVal = new System.Windows.Forms.Label();
            this.cardCount = new System.Windows.Forms.Panel();
            this.lblCardCountTitle = new System.Windows.Forms.Label();
            this.lblCardCountVal = new System.Windows.Forms.Label();
            this.cardAvg = new System.Windows.Forms.Panel();
            this.lblCardAvgTitle = new System.Windows.Forms.Label();
            this.lblCardAvgVal = new System.Windows.Forms.Label();
            this.dgvGeneralRevenue = new System.Windows.Forms.DataGridView();

            this.panelGenTop.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardCount.SuspendLayout();
            this.cardAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralRevenue)).BeginInit();

            this.panelGenTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelGenTop.Controls.Add(this.lblFromDate);
            this.panelGenTop.Controls.Add(this.dtpFromDate);
            this.panelGenTop.Controls.Add(this.lblToDate);
            this.panelGenTop.Controls.Add(this.dtpToDate);
            this.panelGenTop.Controls.Add(this.txtSearchGen);
            this.panelGenTop.Controls.Add(this.btnFilterGen);
            this.panelGenTop.Controls.Add(this.btnExportGenExcel);
            this.panelGenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenTop.Location = new System.Drawing.Point(0, 45);
            this.panelGenTop.Name = "panelGenTop";
            this.panelGenTop.Size = new System.Drawing.Size(950, 42);

            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromDate.Location = new System.Drawing.Point(10, 11);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(55, 22);
            this.lblFromDate.Text = "Từ ngày:";

            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(65, 8);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(115, 23);

            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToDate.Location = new System.Drawing.Point(188, 11);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(35, 22);
            this.lblToDate.Text = "Đến:";

            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(223, 8);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(115, 23);

            this.txtSearchGen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchGen.Location = new System.Drawing.Point(345, 8);
            this.txtSearchGen.Name = "txtSearchGen";
            this.txtSearchGen.PlaceholderText = "Tìm mã đơn, KH...";
            this.txtSearchGen.Size = new System.Drawing.Size(150, 23);

            this.btnFilterGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterGen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterGen.ForeColor = System.Drawing.Color.White;
            this.btnFilterGen.Location = new System.Drawing.Point(502, 7);
            this.btnFilterGen.Name = "btnFilterGen";
            this.btnFilterGen.Size = new System.Drawing.Size(70, 26);
            this.btnFilterGen.Text = "Lọc";
            this.btnFilterGen.Click += new System.EventHandler(this.BtnFilterGen_Click);

            this.btnExportGenExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportGenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportGenExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportGenExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportGenExcel.Location = new System.Drawing.Point(578, 7);
            this.btnExportGenExcel.Name = "btnExportGenExcel";
            this.btnExportGenExcel.Size = new System.Drawing.Size(100, 26);
            this.btnExportGenExcel.Text = "📊 Xuất Excel";
            this.btnExportGenExcel.Click += new System.EventHandler(this.BtnExportGenExcel_Click);

            this.panelCards.BackColor = System.Drawing.Color.White;
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Controls.Add(this.cardCount);
            this.panelCards.Controls.Add(this.cardAvg);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(0, 87);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelCards.Size = new System.Drawing.Size(950, 65);

            this.cardTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.cardTotal.Controls.Add(this.lblCardTotalTitle);
            this.cardTotal.Controls.Add(this.lblCardTotalVal);
            this.cardTotal.Location = new System.Drawing.Point(10, 5);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(200, 53);

            this.lblCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblCardTotalTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardTotalTitle.Name = "lblCardTotalTitle";
            this.lblCardTotalTitle.Size = new System.Drawing.Size(184, 18);
            this.lblCardTotalTitle.Text = "TỔNG DOANH THU";

            this.lblCardTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardTotalVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardTotalVal.Name = "lblCardTotalVal";
            this.lblCardTotalVal.Size = new System.Drawing.Size(184, 25);
            this.lblCardTotalVal.Text = "0 VNĐ";

            this.cardCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.cardCount.Controls.Add(this.lblCardCountTitle);
            this.cardCount.Controls.Add(this.lblCardCountVal);
            this.cardCount.Location = new System.Drawing.Point(218, 5);
            this.cardCount.Name = "cardCount";
            this.cardCount.Size = new System.Drawing.Size(170, 53);

            this.lblCardCountTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblCardCountTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardCountTitle.Name = "lblCardCountTitle";
            this.lblCardCountTitle.Size = new System.Drawing.Size(154, 18);
            this.lblCardCountTitle.Text = "ĐƠN HOÀN THÀNH";

            this.lblCardCountVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardCountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardCountVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardCountVal.Name = "lblCardCountVal";
            this.lblCardCountVal.Size = new System.Drawing.Size(154, 25);
            this.lblCardCountVal.Text = "0 Hóa đơn";

            this.cardAvg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.cardAvg.Controls.Add(this.lblCardAvgTitle);
            this.cardAvg.Controls.Add(this.lblCardAvgVal);
            this.cardAvg.Location = new System.Drawing.Point(396, 5);
            this.cardAvg.Name = "cardAvg";
            this.cardAvg.Size = new System.Drawing.Size(200, 53);

            this.lblCardAvgTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardAvgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblCardAvgTitle.Location = new System.Drawing.Point(8, 4);
            this.lblCardAvgTitle.Name = "lblCardAvgTitle";
            this.lblCardAvgTitle.Size = new System.Drawing.Size(184, 18);
            this.lblCardAvgTitle.Text = "TRUNG BÌNH/ĐƠN";

            this.lblCardAvgVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCardAvgVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardAvgVal.Location = new System.Drawing.Point(8, 22);
            this.lblCardAvgVal.Name = "lblCardAvgVal";
            this.lblCardAvgVal.Size = new System.Drawing.Size(184, 25);
            this.lblCardAvgVal.Text = "0 VNĐ";

            this.dgvGeneralRevenue.AllowUserToAddRows = false;
            this.dgvGeneralRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeneralRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvGeneralRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeneralRevenue.Location = new System.Drawing.Point(0, 152);
            this.dgvGeneralRevenue.Name = "dgvGeneralRevenue";
            this.dgvGeneralRevenue.ReadOnly = true;
            this.dgvGeneralRevenue.Size = new System.Drawing.Size(950, 448);

            this.Controls.Add(this.dgvGeneralRevenue);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelGenTop);
            this.panelHeader.SendToBack();
            this.panelGenTop.SendToBack();
            this.panelCards.SendToBack();

            this.panelGenTop.ResumeLayout(false);
            this.panelGenTop.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardCount.ResumeLayout(false);
            this.cardAvg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneralRevenue)).EndInit();
        }

        private void BuildCustomerView()
        {
            this.panelCustTop = new System.Windows.Forms.Panel();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.btnFilterCust = new System.Windows.Forms.Button();
            this.btnExportCustExcel = new System.Windows.Forms.Button();
            this.dgvCustomerRevenue = new System.Windows.Forms.DataGridView();

            this.panelCustTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRevenue)).BeginInit();

            this.panelCustTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelCustTop.Controls.Add(this.txtSearchCust);
            this.panelCustTop.Controls.Add(this.btnFilterCust);
            this.panelCustTop.Controls.Add(this.btnExportCustExcel);
            this.panelCustTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustTop.Location = new System.Drawing.Point(0, 45);
            this.panelCustTop.Name = "panelCustTop";
            this.panelCustTop.Size = new System.Drawing.Size(950, 42);

            this.txtSearchCust.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchCust.Location = new System.Drawing.Point(10, 8);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.PlaceholderText = "Tìm tên khách hàng, MST...";
            this.txtSearchCust.Size = new System.Drawing.Size(250, 27);

            this.btnFilterCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterCust.ForeColor = System.Drawing.Color.White;
            this.btnFilterCust.Location = new System.Drawing.Point(270, 7);
            this.btnFilterCust.Name = "btnFilterCust";
            this.btnFilterCust.Size = new System.Drawing.Size(85, 28);
            this.btnFilterCust.Text = "Lọc KH";
            this.btnFilterCust.Click += new System.EventHandler(this.BtnFilterCust_Click);

            this.btnExportCustExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportCustExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCustExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCustExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportCustExcel.Location = new System.Drawing.Point(365, 7);
            this.btnExportCustExcel.Name = "btnExportCustExcel";
            this.btnExportCustExcel.Size = new System.Drawing.Size(110, 28);
            this.btnExportCustExcel.Text = "📊 Xuất Excel";
            this.btnExportCustExcel.Click += new System.EventHandler(this.BtnExportCustExcel_Click);

            this.dgvCustomerRevenue.AllowUserToAddRows = false;
            this.dgvCustomerRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerRevenue.Location = new System.Drawing.Point(0, 87);
            this.dgvCustomerRevenue.Name = "dgvCustomerRevenue";
            this.dgvCustomerRevenue.ReadOnly = true;
            this.dgvCustomerRevenue.Size = new System.Drawing.Size(950, 513);

            this.Controls.Add(this.dgvCustomerRevenue);
            this.Controls.Add(this.panelCustTop);
            this.panelHeader.SendToBack();
            this.panelCustTop.SendToBack();

            this.panelCustTop.ResumeLayout(false);
            this.panelCustTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRevenue)).EndInit();
        }

        private void BuildProductView()
        {
            this.panelProdTop = new System.Windows.Forms.Panel();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.btnFilterProd = new System.Windows.Forms.Button();
            this.btnExportProdExcel = new System.Windows.Forms.Button();
            this.dgvProductRevenue = new System.Windows.Forms.DataGridView();

            this.panelProdTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRevenue)).BeginInit();

            this.panelProdTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelProdTop.Controls.Add(this.txtSearchProd);
            this.panelProdTop.Controls.Add(this.btnFilterProd);
            this.panelProdTop.Controls.Add(this.btnExportProdExcel);
            this.panelProdTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdTop.Location = new System.Drawing.Point(0, 45);
            this.panelProdTop.Name = "panelProdTop";
            this.panelProdTop.Size = new System.Drawing.Size(950, 42);

            this.txtSearchProd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchProd.Location = new System.Drawing.Point(10, 8);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.PlaceholderText = "Tìm tên sản phẩm, loại...";
            this.txtSearchProd.Size = new System.Drawing.Size(250, 27);

            this.btnFilterProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnFilterProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterProd.ForeColor = System.Drawing.Color.White;
            this.btnFilterProd.Location = new System.Drawing.Point(270, 7);
            this.btnFilterProd.Name = "btnFilterProd";
            this.btnFilterProd.Size = new System.Drawing.Size(85, 28);
            this.btnFilterProd.Text = "Lọc SP";
            this.btnFilterProd.Click += new System.EventHandler(this.BtnFilterProd_Click);

            this.btnExportProdExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnExportProdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProdExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportProdExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportProdExcel.Location = new System.Drawing.Point(365, 7);
            this.btnExportProdExcel.Name = "btnExportProdExcel";
            this.btnExportProdExcel.Size = new System.Drawing.Size(110, 28);
            this.btnExportProdExcel.Text = "📊 Xuất Excel";
            this.btnExportProdExcel.Click += new System.EventHandler(this.BtnExportProdExcel_Click);

            this.dgvProductRevenue.AllowUserToAddRows = false;
            this.dgvProductRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductRevenue.Location = new System.Drawing.Point(0, 87);
            this.dgvProductRevenue.Name = "dgvProductRevenue";
            this.dgvProductRevenue.ReadOnly = true;
            this.dgvProductRevenue.Size = new System.Drawing.Size(950, 513);

            this.Controls.Add(this.dgvProductRevenue);
            this.Controls.Add(this.panelProdTop);
            this.panelHeader.SendToBack();
            this.panelProdTop.SendToBack();

            this.panelProdTop.ResumeLayout(false);
            this.panelProdTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRevenue)).EndInit();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
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
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Button btnFilterCust;
        private System.Windows.Forms.Button btnExportCustExcel;
        private System.Windows.Forms.DataGridView dgvCustomerRevenue;
        private System.Windows.Forms.Panel panelProdTop;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.Button btnFilterProd;
        private System.Windows.Forms.Button btnExportProdExcel;
        private System.Windows.Forms.DataGridView dgvProductRevenue;
    }
}
