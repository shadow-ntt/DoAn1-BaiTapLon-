using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn1.Models.Tables;
using DoAn1.Views;

namespace DoAn1.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly Account _currentAccount;
        private readonly int _currentEmployeeId;
        private readonly string _currentPosition;
        private readonly string _employeeName;

        public DashboardForm(Account account)
        {
            InitializeComponent();
            _currentAccount = account;
            _currentEmployeeId = account.EmployeeId;
            _currentPosition = account.Employee?.Position ?? "Admin";
            _employeeName = account.Employee?.Name ?? "Nhân viên";

            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = $"Xin chào, {_employeeName} (ID: #{_currentEmployeeId})";
            lblRoleBadge.Text = $"CHỨC VỤ: {_currentPosition.ToUpper()}";

            BuildTreeView();
            SelectFirstAuthorizedNode();
        }

        private void BuildTreeView()
        {
            treeViewNav.Nodes.Clear();

            // 1. DANH MỤC
            TreeNode nodeCategory = new TreeNode("📁 DANH MỤC");
            
            TreeNode nodeEmp = CreateNavNode("👥 Nhân viên", "nhan_vien", new[] { "Admin" });
            TreeNode nodeCust = CreateNavNode("👤 Khách hàng", "khach_hang", new[] { "Admin", "GiaoDichVien", "KiemSoatVien" });
            TreeNode nodeProd = CreateNavNode("📦 Sản phẩm", "san_pham", new[] { "Admin", "GiaoDichVien", "KiemSoatVien", "KiemKho" });

            nodeCategory.Nodes.Add(nodeEmp);
            nodeCategory.Nodes.Add(nodeCust);
            nodeCategory.Nodes.Add(nodeProd);

            // 2. NGHIỆP VỤ
            TreeNode nodeBusiness = new TreeNode("💼 NGHIỆP VỤ");

            TreeNode nodeOrder = CreateNavNode("🛒 Đặt hàng", "dat_hang", new[] { "Admin", "GiaoDichVien" });
            TreeNode nodeInspection = CreateNavNode("🔍 Kiểm tra đơn hàng", "kiem_tra_don", new[] { "Admin", "KiemSoatVien" });
            TreeNode nodeInvoice = CreateNavNode("📄 Lập hóa đơn", "lap_hoa_don", new[] { "Admin", "KeToan" });
            
            TreeNode nodeDeliveryParent = CreateNavNode("🚚 Giao hàng", "giao_hang_parent", new[] { "Admin", "GiaoHangVien", "KiemKho" });
            TreeNode nodeDelivPending = CreateNavNode("⏳ Đơn chờ giao", "don_cho_giao", new[] { "Admin", "GiaoHangVien" });
            TreeNode nodeDelivDelivering = CreateNavNode("🚀 Đơn đang giao", "don_dang_giao", new[] { "Admin", "GiaoHangVien" });
            TreeNode nodeDelivHistory = CreateNavNode("📜 Lịch sử giao hàng", "lich_su_giao", new[] { "Admin", "GiaoHangVien" });
            TreeNode nodeReturnApproval = CreateNavNode("🔄 Duyệt đơn trả hàng", "duyet_tra_hang", new[] { "Admin", "KiemKho" });

            nodeDeliveryParent.Nodes.Add(nodeDelivPending);
            nodeDeliveryParent.Nodes.Add(nodeDelivDelivering);
            nodeDeliveryParent.Nodes.Add(nodeDelivHistory);
            nodeDeliveryParent.Nodes.Add(nodeReturnApproval);

            nodeBusiness.Nodes.Add(nodeOrder);
            nodeBusiness.Nodes.Add(nodeInspection);
            nodeBusiness.Nodes.Add(nodeInvoice);
            nodeBusiness.Nodes.Add(nodeDeliveryParent);

            // 3. THỐNG KÊ
            TreeNode nodeStats = new TreeNode("📊 THỐNG KÊ");
            
            TreeNode nodeRevenueParent = CreateNavNode("💰 Doanh thu", "doanh_thu_parent", new[] { "Admin", "KeToan" });
            TreeNode nodeRevCust = CreateNavNode("👤 Thống kê theo khách hàng", "thong_ke_khach", new[] { "Admin", "KeToan" });
            TreeNode nodeRevProd = CreateNavNode("📦 Thống kê theo sản phẩm", "thong_ke_san_pham", new[] { "Admin", "KeToan" });

            nodeRevenueParent.Nodes.Add(nodeRevCust);
            nodeRevenueParent.Nodes.Add(nodeRevProd);

            nodeStats.Nodes.Add(nodeRevenueParent);

            // 4. HỆ THỐNG
            TreeNode nodeSystem = new TreeNode("⚙ HỆ THỐNG");
            TreeNode nodeLogout = CreateNavNode("🚪 Đăng xuất", "dang_xuat", new[] { "Admin", "GiaoDichVien", "KiemSoatVien", "KeToan", "GiaoHangVien", "KiemKho" });
            nodeSystem.Nodes.Add(nodeLogout);

            // Add all categories to tree
            treeViewNav.Nodes.Add(nodeCategory);
            treeViewNav.Nodes.Add(nodeBusiness);
            treeViewNav.Nodes.Add(nodeStats);
            treeViewNav.Nodes.Add(nodeSystem);

            treeViewNav.ExpandAll();
            treeViewNav.AfterSelect += TreeViewNav_AfterSelect;
        }

        private TreeNode CreateNavNode(string text, string key, string[] allowedPositions)
        {
            TreeNode node = new TreeNode(text);
            bool isAuth = (_currentPosition == "Admin" || Array.Exists(allowedPositions, p => p.Equals(_currentPosition, StringComparison.OrdinalIgnoreCase)));

            node.Tag = new NavNodeTag
            {
                Key = key,
                IsAuthorized = isAuth,
                AllowedPositions = allowedPositions
            };

            if (!isAuth)
            {
                node.ForeColor = Color.FromArgb(148, 163, 184); // Dimmed slate color for disabled nodes
                node.Text += " (Không đủ quyền)";
            }

            return node;
        }

        private void SelectFirstAuthorizedNode()
        {
            foreach (TreeNode parentNode in treeViewNav.Nodes)
            {
                foreach (TreeNode childNode in parentNode.Nodes)
                {
                    if (childNode.Tag is NavNodeTag tag && tag.IsAuthorized)
                    {
                        treeViewNav.SelectedNode = childNode;
                        return;
                    }
                    else if (childNode.Nodes.Count > 0)
                    {
                        foreach (TreeNode grandChild in childNode.Nodes)
                        {
                            if (grandChild.Tag is NavNodeTag gcTag && gcTag.IsAuthorized)
                            {
                                treeViewNav.SelectedNode = grandChild;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void TreeViewNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag is not NavNodeTag tag) return;

            if (tag.Key == "dang_xuat")
            {
                HandleLogout();
                return;
            }

            if (!tag.IsAuthorized)
            {
                DisplayView(new AccessDeniedControl());
                return;
            }

            switch (tag.Key)
            {
                case "nhan_vien":
                    DisplayView(new EmployeeManagementControl());
                    break;

                case "khach_hang":
                    DisplayView(new CustomerManagementControl());
                    break;

                case "san_pham":
                    DisplayView(new ProductManagementControl(_currentPosition, defaultTabIndex: 0));
                    break;

                case "dat_hang":
                    DisplayView(new OrderCreationControl());
                    break;

                case "kiem_tra_don":
                    DisplayView(new OrderInspectionControl(_currentEmployeeId, _currentPosition == "Admin"));
                    break;

                case "lap_hoa_don":
                    DisplayView(new InvoiceBillingControl());
                    break;

                case "giao_hang_parent":
                case "don_cho_giao":
                    DisplayView(new DeliveryManagementControl(_currentEmployeeId, defaultTabIndex: 0));
                    break;

                case "don_dang_giao":
                    DisplayView(new DeliveryManagementControl(_currentEmployeeId, defaultTabIndex: 1));
                    break;

                case "lich_su_giao":
                    DisplayView(new DeliveryManagementControl(_currentEmployeeId, defaultTabIndex: 2));
                    break;

                case "duyet_tra_hang":
                    DisplayView(new ProductManagementControl(_currentPosition, defaultTabIndex: 1));
                    break;

                case "doanh_thu_parent":
                    DisplayView(new RevenueReportControl(defaultTabIndex: 0));
                    break;

                case "thong_ke_khach":
                    DisplayView(new RevenueReportControl(defaultTabIndex: 1));
                    break;

                case "thong_ke_san_pham":
                    DisplayView(new RevenueReportControl(defaultTabIndex: 2));
                    break;
            }
        }

        private void DisplayView(Control viewControl)
        {
            panelContent.Controls.Clear();
            viewControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(viewControl);
        }

        private void HandleLogout()
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                MainForm loginForm = new MainForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
