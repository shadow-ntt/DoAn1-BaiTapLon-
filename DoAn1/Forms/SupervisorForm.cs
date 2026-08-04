using DoAn1.Models.Tables;
using DoAn1.Models.Helpers;
using DoAn1.Services;

namespace DoAn1.Forms
{
    public partial class SupervisorForm : Form
    {
        private readonly int _currentEmployeeId;
        private readonly SupervisorService _supervisorService;
        private List<Order> _currentHistoryList;

        public SupervisorForm(int currentEmployeeId = 1)
        {
            InitializeComponent();
            _currentEmployeeId = currentEmployeeId;
            _supervisorService = new SupervisorService();
            _currentHistoryList = new List<Order>();

            this.WindowState = FormWindowState.Maximized;
        }

        private void supervisorForm_Load(object sender, EventArgs e)
        {
            RefreshPendingOrders(showNotification: false);
        }

        #region --- TAB 1: KIỂM DUYỆT ĐƠN HÀNG ---

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnRefresh.Text = "Đang tải...";

            await Task.Delay(200);

            RefreshPendingOrders(showNotification: true);

            btnRefresh.Text = "Làm mới";
            btnRefresh.Enabled = true;
        }

        private void RefreshPendingOrders(bool showNotification = false)
        {
            lstOrders.Items.Clear();

            // Gọi Service lấy ProcessResult chứa danh sách đơn chờ duyệt từ DB
            var result = _supervisorService.GetPendingOrders(_currentEmployeeId);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearPendingDetails();
                return;
            }

            List<Order> pendingOrders = result.Data ?? new List<Order>();

            foreach (var order in pendingOrders)
            {
                lstOrders.Items.Add(order);
            }

            if (lstOrders.Items.Count > 0)
            {
                lstOrders.SelectedIndex = 0;
            }
            else
            {
                ClearPendingDetails();
            }

            if (showNotification)
            {
                MessageBox.Show($"Đã cập nhật danh sách! Có {pendingOrders.Count} đơn hàng chờ duyệt.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem is Order selectedOrder)
            {
                LoadOrderDetails(selectedOrder);
            }
        }

        private void LoadOrderDetails(Order order)
        {
            if (order == null) return;

            string custName = order.Customer?.FullName ?? "Không rõ KH";
            lblOrderTitle.Text = $"Chi tiết đơn hàng: #{order.OrderId}";
            lblCustomerInfo.Text = $"Khách hàng: {custName} | Ngày đặt: {order.OrderDate:dd/MM/yyyy HH:mm}";

            // 1. XỬ LÝ CẢNH BÁO VƯỢT TÍN DỤNG (MÀU ĐỎ)
            decimal totalAmount = order.OrderDetails?.Sum(d => d.Quantity * (d.UnitPrice > 0 ? d.UnitPrice : (d.Product?.UnitPrice ?? 0))) ?? 0;
            decimal creditLimit = order.Customer?.CreditLimit ?? 0;

            bool isCreditExceeded = totalAmount > creditLimit && creditLimit > 0;

            if (isCreditExceeded)
            {
                lblCreditPlaceholder.ForeColor = Color.Red;
                lblCreditPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lblCreditPlaceholder.Text = $"• Khách hàng: {custName}\n\n" +
                                            $"• CẢNH BÁO: VƯỢT HẠN MỨC TÍN DỤNG!\n" +
                                            $"• Hạn mức: {creditLimit:N0} đ | Đơn: {totalAmount:N0} đ\n\n" +
                                            $"• Trạng thái đơn:  {OrderStatusHelper.GetText(order.Status)}";
            }
            else
            {
                lblCreditPlaceholder.ForeColor = Color.FromArgb(30, 41, 59);
                lblCreditPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                lblCreditPlaceholder.Text = $"• Khách hàng: {custName}\n\n" +
                                            $"• Hạn mức tín dụng: An toàn ({creditLimit:N0} đ)\n\n" +
                                            $"• Trạng thái đơn: {OrderStatusHelper.GetText(order.Status)}";
            }

            // 2. XỬ LÝ CẢNH BÁO THIẾU HÀNG TỒN KHO (MÀU ĐỎ)
            dgvInventory.Rows.Clear();
            if (order.OrderDetails != null)
            {
                foreach (var detail in order.OrderDetails)
                {
                    string prodName = detail.Product?.ProductName ?? "Sản phẩm không xác định";
                    int orderQty = detail.Quantity;
                    int stockQty = detail.Product?.OpeningQuantity ?? 0;

                    bool isShortage = stockQty < orderQty;
                    string stockStatus = isShortage
                        ? $"Thiếu {orderQty - stockQty}"
                        : "Đủ hàng";

                    int rowIndex = dgvInventory.Rows.Add(prodName, orderQty, stockQty, stockStatus);

                    if (isShortage)
                    {
                        dgvInventory.Rows[rowIndex].Cells[3].Style.ForeColor = Color.Red;
                        dgvInventory.Rows[rowIndex].Cells[3].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    }
                }
            }
        }

        private void ClearPendingDetails()
        {
            lblOrderTitle.Text = "Chi tiết đơn hàng: ---";
            lblCustomerInfo.Text = "Khách hàng: ---";
            lblCreditPlaceholder.Text = string.Empty;
            dgvInventory.Rows.Clear();
            txtNotes.Clear();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem is Order selectedOrder)
            {
                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn DUYỆT đơn hàng [#{selectedOrder.OrderId}]?",
                    "Xác nhận duyệt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _supervisorService.ApproveOrder(selectedOrder.OrderId);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshPendingOrders(showNotification: false);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Không thể duyệt đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem is Order selectedOrder)
            {
                string reason = txtNotes.Text.Trim();
                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("Vui lòng nhập lý do từ chối / trả lại đơn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNotes.Focus();
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn TỪ CHỐI đơn hàng [#{selectedOrder.OrderId}]?",
                    "Xác nhận từ chối", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _supervisorService.RejectOrder(selectedOrder.OrderId, reason);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNotes.Clear();
                        RefreshPendingOrders(showNotification: false);
                    }
                    else
                    {
                        MessageBox.Show(result.Message, "Lỗi xử lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lstOrders_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstOrders.Items.Count) return;

            e.DrawBackground();

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            if (lstOrders.Items[e.Index] is Order order)
            {
                Color backColor = isSelected ? Color.FromArgb(238, 242, 255) : Color.White;
                using (Brush b = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(b, e.Bounds);
                }

                using (Pen p = new Pen(Color.FromArgb(226, 232, 240)))
                {
                    e.Graphics.DrawLine(p, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
                }

                using (Font fontTitle = new Font("Segoe UI", 10.5F, FontStyle.Bold))
                using (Font fontSub = new Font("Segoe UI", 9.5F, FontStyle.Regular))
                using (Font fontDate = new Font("Segoe UI", 9.0F, FontStyle.Regular))
                {
                    using (Brush titleBrush = isSelected ? new SolidBrush(Color.FromArgb(79, 70, 229)) : new SolidBrush(Color.FromArgb(15, 23, 42)))
                    using (Brush subTextBrush = new SolidBrush(Color.FromArgb(51, 65, 85)))
                    using (Brush dateBrush = new SolidBrush(Color.FromArgb(100, 116, 139)))
                    {
                        string custName = order.Customer?.FullName ?? "Không rõ KH";

                        e.Graphics.DrawString($"Đơn hàng #{order.OrderId}", fontTitle, titleBrush, e.Bounds.X + 10, e.Bounds.Y + 6);
                        e.Graphics.DrawString($"KH: {custName}", fontSub, subTextBrush, e.Bounds.X + 10, e.Bounds.Y + 28);
                        e.Graphics.DrawString(order.OrderDate.ToString("dd/MM/yyyy HH:mm"), fontDate, dateBrush, e.Bounds.X + 10, e.Bounds.Y + 50);
                    }
                }
            }

            e.DrawFocusRectangle();
        }

        #endregion

        #region --- TAB 2: LỊCH SỬ KIỂM DUYỆT ---

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabHistory)
            {
                LoadHistoryList(showNotification: false);
            }
        }

        private async void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            btnRefreshHistory.Enabled = false;
            btnRefreshHistory.Text = "Đang tải...";

            await Task.Delay(200);

            LoadHistoryList(showNotification: true);

            btnRefreshHistory.Text = "Làm mới";
            btnRefreshHistory.Enabled = true;
        }

        private void LoadHistoryList(bool showNotification = false)
        {
            dgvHistoryList.Rows.Clear();

            string keyword = txtSearch.Text.Trim();

            // Gọi Service lấy ProcessResult chứa Lịch sử đơn hàng
            var result = _supervisorService.GetReviewedHistoryOrders(_currentEmployeeId, keyword);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _currentHistoryList = new List<Order>();
                return;
            }

            _currentHistoryList = result.Data ?? new List<Order>();

            foreach (var order in _currentHistoryList)
            {
                string custName = order.Customer?.FullName ?? "N/A";
                string reviewDate = order.ReviewedDate?.ToString("dd/MM/yyyy HH:mm") ?? order.OrderDate.ToString("dd/MM/yyyy HH:mm");

                string statusText = OrderStatusHelper.GetText(order.Status);

                dgvHistoryList.Rows.Add(order.OrderId, custName, reviewDate, statusText);
            }

            if (showNotification)
            {
                MessageBox.Show($"Đã cập nhật lịch sử! Tải được {_currentHistoryList.Count} bản ghi.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadHistoryList(showNotification: false);
        }

        private void dgvHistoryList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistoryList.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvHistoryList.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _currentHistoryList.Count)
                {
                    var order = _currentHistoryList[selectedIndex];

                    string custName = order.Customer?.FullName ?? "N/A";
                    string statusText = OrderStatusHelper.GetText(order.Status);

                    lblHistoryCustomerDetails.Text = $"• Mã đơn hàng: #{order.OrderId}\n\n" +
                                                     $"• Khách hàng: {custName}\n\n" +
                                                     $"• Trạng thái kiểm duyệt: {statusText}\n\n" +
                                                     $"• Ngày xử lý: {order.ReviewedDate?.ToString("dd/MM/yyyy HH:mm") ?? "N/A"}";

                    txtHistoryReason.Text = string.IsNullOrEmpty(order.CancelReason)
                        ? "Đã phê duyệt (không có ghi chú lý do từ chối)."
                        : order.CancelReason;

                    dgvHistoryProducts.Rows.Clear();
                    if (order.OrderDetails != null)
                    {
                        foreach (var detail in order.OrderDetails)
                        {
                            string prodName = detail.Product?.ProductName ?? "Sản phẩm không xác định";
                            int qty = detail.Quantity;

                            decimal price = detail.UnitPrice > 0 ? detail.UnitPrice : (detail.Product?.UnitPrice ?? 0);
                            decimal total = price * qty;

                            dgvHistoryProducts.Rows.Add(
                                prodName,
                                qty,
                                price.ToString("N0") + " đ",
                                total.ToString("N0") + " đ"
                            );
                        }
                    }
                }
            }
        }

        #endregion
    }
}