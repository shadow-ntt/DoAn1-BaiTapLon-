namespace DoAn1.Forms
{
    partial class DashboardForm
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
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblRoleBadge = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewNav = new System.Windows.Forms.TreeView();
            this.panelNavHeader = new System.Windows.Forms.Panel();
            this.lblNavHeader = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelNavHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelTopBar.Controls.Add(this.lblRoleBadge);
            this.panelTopBar.Controls.Add(this.lblUserInfo);
            this.panelTopBar.Controls.Add(this.lblAppName);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1200, 60);
            this.panelTopBar.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = false;
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblAppName.Size = new System.Drawing.Size(350, 60);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "LAVITA ORDER SYSTEM";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoleBadge
            // 
            this.lblRoleBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblRoleBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRoleBadge.ForeColor = System.Drawing.Color.White;
            this.lblRoleBadge.Location = new System.Drawing.Point(360, 15);
            this.lblRoleBadge.Name = "lblRoleBadge";
            this.lblRoleBadge.Size = new System.Drawing.Size(160, 30);
            this.lblRoleBadge.TabIndex = 1;
            this.lblRoleBadge.Text = "CHỨC VỤ: ADMIN";
            this.lblRoleBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblUserInfo.Location = new System.Drawing.Point(800, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblUserInfo.Size = new System.Drawing.Size(400, 60);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "Xin chào, Nguyễn Văn A";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 60);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewNav);
            this.splitContainerMain.Panel1.Controls.Add(this.panelNavHeader);
            this.splitContainerMain.Panel1MinSize = 250;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelContent);
            this.splitContainerMain.Size = new System.Drawing.Size(1200, 690);
            this.splitContainerMain.SplitterDistance = 280;
            this.splitContainerMain.TabIndex = 1;
            // 
            // panelNavHeader
            // 
            this.panelNavHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelNavHeader.Controls.Add(this.lblNavHeader);
            this.panelNavHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavHeader.Location = new System.Drawing.Point(0, 0);
            this.panelNavHeader.Name = "panelNavHeader";
            this.panelNavHeader.Size = new System.Drawing.Size(280, 40);
            this.panelNavHeader.TabIndex = 0;
            // 
            // lblNavHeader
            // 
            this.lblNavHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNavHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lblNavHeader.Location = new System.Drawing.Point(0, 0);
            this.lblNavHeader.Name = "lblNavHeader";
            this.lblNavHeader.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblNavHeader.Size = new System.Drawing.Size(280, 40);
            this.lblNavHeader.TabIndex = 0;
            this.lblNavHeader.Text = "MENU CHỨC NĂNG";
            this.lblNavHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeViewNav
            // 
            this.treeViewNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.treeViewNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNav.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.treeViewNav.ForeColor = System.Drawing.Color.White;
            this.treeViewNav.ItemHeight = 32;
            this.treeViewNav.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.treeViewNav.Location = new System.Drawing.Point(0, 40);
            this.treeViewNav.Name = "treeViewNav";
            this.treeViewNav.Size = new System.Drawing.Size(280, 650);
            this.treeViewNav.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(916, 690);
            this.panelContent.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelTopBar);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Đặt hàng LAVITA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTopBar.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelNavHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblRoleBadge;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelNavHeader;
        private System.Windows.Forms.Label lblNavHeader;
        private System.Windows.Forms.TreeView treeViewNav;
        private System.Windows.Forms.Panel panelContent;
    }
}
