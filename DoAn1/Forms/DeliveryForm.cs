using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DoAn1.Models.Tables;
using DoAn1.Services;

namespace DoAn1.Forms
{
    public partial class DeliveryForm : Form
    {
        private readonly DeliveryService _deliveryService;
        private readonly int _currentEmployeeId; // ID nhân viên đăng nhập hiện tại

        private List<Order> _pendingOrders;
        private List<Delivery> _deliveringOrders;
        private Order _selectedOrder;

        public DeliveryForm(int currentEmployeeId = -1) // Mặc định ID = -1 nếu chưa truyền từ Login
        {
            InitializeComponent();
            _deliveryService = new DeliveryService();
            _currentEmployeeId = currentEmployeeId;
            InitEvents();
        }

        private void InitEvents()
        {
            this.Load += DeliveryForm_Load;

            // Bắt sự kiện khi chuyển Tab
            tabControlDelivery.SelectedIndexChanged += TabControlDelivery_SelectedIndexChanged;

            // Events cho Tab 1: Đơn chờ giao
            txtSearchPending.TextChanged += (s, e) => LoadPendingOrders();
            btnRefreshPending.Click += BtnRefreshPending_Click;
            lstPendingOrders.SelectedIndexChanged += LstPendingOrders_SelectedIndexChanged;
            btnStartDelivery.Click += BtnStartDelivery_Click;

            // Events cho Tab 2: Đơn đang giao
            txtSearchDelivering.TextChanged += (s, e) => LoadDeliveringOrders();
            btnRefreshDelivering.Click += BtnRefreshDelivering_Click;
            lstDeliveringOrders.SelectedIndexChanged += LstDeliveringOrders_SelectedIndexChanged;
            btnConfirmSuccess.Click += BtnConfirmSuccess_Click;
            btnConfirmReturn.Click += BtnConfirmReturn_Click;

            // Events cho Tab 3: Lịch sử giao hàng
            txtSearchHistory.TextChanged += (s, e) => LoadDeliveryHistory();
            btnRefreshHistory.Click += BtnRefreshHistory_Click;
            dgvDeliveryHistory.SelectionChanged += DgvDeliveryHistory_SelectionChanged;
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void TabControlDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearForm();
            switch (tabControlDelivery.SelectedIndex)
            {
                case 0:
                    LoadPendingOrders();
                    break;
                case 1:
                    LoadDeliveringOrders();
                    break;
                case 2:
                    LoadDeliveryHistory();
                    break;
            }
        }

        #region --- TAB 1: ĐƠN CHỜ GIAO ---

        private void BtnRefreshPending_Click(object sender, EventArgs e)
        {
            txtSearchPending.Clear();
            LoadPendingOrders();
            MessageBox.Show("Đã tải lại danh sách đơn hàng chờ giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadPendingOrders()
        {
            try
            {
                string keyword = txtSearchPending.Text.Trim();
                _pendingOrders = _deliveryService.GetPendingOrders(keyword);
                lstPendingOrders.DataSource = null;

                if (_pendingOrders != null && _pendingOrders.Count > 0)
                {
                    var displayList = _pendingOrders.Select(o => new {
                        OrderData = o,
                        DisplayText = $"[ORD-{o.OrderId}] — Khách: {(o.Customer != null ? o.Customer.FullName : "Khách lẻ")}"
                    }).ToList();

                    lstPendingOrders.DataSource = displayList;
                    lstPendingOrders.DisplayMember = "DisplayText";
                    lstPendingOrders.ValueMember = "OrderData";
                }
                else
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp danh sách chờ giao: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendingOrders.SelectedItem == null)
            {
                ClearForm();
                return;
            }

            dynamic selectedItem = lstPendingOrders.SelectedItem;
            _selectedOrder = selectedItem.OrderData as Order;
            DisplayOrderDetails(_selectedOrder, "Chờ giao");
        }

        private void BtnStartDelivery_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận nhận đơn hàng ORD-{_selectedOrder.OrderId} để bắt đầu đi giao?",
                "Xác nhận giao hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = _deliveryService.StartDelivery(_selectedOrder.OrderId, _currentEmployeeId);
                if (success)
                {
                    MessageBox.Show("Đã nhận đơn thành công! Đơn hàng đã được chuyển sang danh sách Đang giao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingOrders();
                }
                else
                {
                    MessageBox.Show("Không thể nhận đơn hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region --- TAB 2: ĐƠN ĐANG GIAO ---

        private void BtnRefreshDelivering_Click(object sender, EventArgs e)
        {
            txtSearchDelivering.Clear();
            LoadDeliveringOrders();
            MessageBox.Show("Đã tải lại danh sách đơn hàng đang giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDeliveringOrders()
        {
            try
            {
                string keyword = txtSearchDelivering.Text.Trim();
                _deliveringOrders = _deliveryService.GetDeliveringOrders(_currentEmployeeId, keyword);
                lstDeliveringOrders.DataSource = null;

                if (_deliveringOrders != null && _deliveringOrders.Count > 0)
                {
                    var displayList = _deliveringOrders.Select(d => new {
                        DeliveryData = d,
                        DisplayText = $"[ORD-{d.OrderId}] — Khách: {(d.Order.Customer != null ? d.Order.Customer.FullName : "Khách lẻ")}"
                    }).ToList();

                    lstDeliveringOrders.DataSource = displayList;
                    lstDeliveringOrders.DisplayMember = "DisplayText";
                    lstDeliveringOrders.ValueMember = "DeliveryData";
                }
                else
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp danh sách đang giao: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstDeliveringOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDeliveringOrders.SelectedItem == null)
            {
                ClearForm();
                return;
            }

            dynamic selectedItem = lstDeliveringOrders.SelectedItem;
            Delivery delivery = selectedItem.DeliveryData as Delivery;
            _selectedOrder = delivery?.Order;
            DisplayOrderDetails(_selectedOrder, "Đang giao");
        }

        private void BtnConfirmSuccess_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng đang giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận đơn hàng ORD-{_selectedOrder.OrderId} đã giao thành công & thu tiền?",
                "Xác nhận hoàn thành",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = _deliveryService.ConfirmDeliverySuccess(_selectedOrder.OrderId);
                if (success)
                {
                    MessageBox.Show("Đã xác nhận giao hàng thành công và ghi nhận doanh thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDeliveringOrders();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xác nhận hoàn thành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnConfirmReturn_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng bị trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = txtReturnReason.Text.Trim();
            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Vui lòng nhập lý do trả hàng trước khi xác nhận!", "Yêu cầu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReturnReason.Focus();
                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận đơn hàng ORD-{_selectedOrder.OrderId} bị trả lại với lý do: '{reason}'?",
                "Xác nhận trả hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool success = _deliveryService.ConfirmDeliveryReturn(_selectedOrder.OrderId, reason);
                if (success)
                {
                    MessageBox.Show("Đã cập nhật trạng thái đơn hàng bị trả về hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnReason.Clear();
                    LoadDeliveringOrders();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xác nhận trả hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region --- TAB 3: LỊCH SỬ GIAO HÀNG ---

        private void BtnRefreshHistory_Click(object sender, EventArgs e)
        {
            txtSearchHistory.Clear();
            LoadDeliveryHistory();
            MessageBox.Show("Đã tải lại danh sách lịch sử giao hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDeliveryHistory()
        {
            try
            {
                string keyword = txtSearchHistory.Text.Trim();
                var historyList = _deliveryService.GetDeliveryHistory(_currentEmployeeId, keyword);
                dgvDeliveryHistory.DataSource = historyList;

                // Ẩn cột OrderObj khỏi DataGridView nhưng vẫn lưu đối tượng để dùng
                if (dgvDeliveryHistory.Columns["OrderObj"] != null)
                {
                    dgvDeliveryHistory.Columns["OrderObj"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp lịch sử giao hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện xảy ra khi click chọn 1 dòng trong DataGridView Lịch sử giao hàng
        private void DgvDeliveryHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeliveryHistory.CurrentRow == null || dgvDeliveryHistory.CurrentRow.DataBoundItem == null)
            {
                ClearForm();
                return;
            }

            dynamic selectedItem = dgvDeliveryHistory.CurrentRow.DataBoundItem;
            _selectedOrder = selectedItem.OrderObj as Order;

            // Lấy thêm dữ liệu hiển thị trên Grid đẩy sang Panel chi tiết
            string status = selectedItem.Trạng_Thái;
            DateTime? deliveryDate = selectedItem.Ngày_Giao;
            string returnReason = selectedItem.Lý_Do_Trả;

            DisplayOrderDetails(_selectedOrder, status, deliveryDate, returnReason);
        }

        #endregion

        #region --- THÔNG TIN CHI TIẾT (SHARED PANEL) ---

        private void DisplayOrderDetails(Order order, string statusText = "", DateTime? deliveryDate = null, string returnReason = "")
        {
            if (order == null)
            {
                ClearForm();
                return;
            }

            lblOrderTitle.Text = $"Thông tin vận chuyển đơn hàng: ORD-{order.OrderId}";
            txtCustomerName.Text = order.Customer?.FullName ?? "Khách lẻ";
            txtPhone.Text = order.Customer?.PhoneNumber ?? "Chưa có SĐT";
            txtAddress.Text = order.Customer?.Address ?? "Chưa có địa chỉ";
            txtExpectedDate.Text = order.ExpectedDeliveryDate.ToString("dd/MM/yyyy");
            txtInvoiceId.Text = order.Invoice != null ? $"INV-{order.Invoice.InvoiceId}" : "Chưa có";

            // Hiển thị các thông tin nâng cao cho Panel chi tiết
            txtDeliveryStatus.Text = !string.IsNullOrEmpty(statusText) ? statusText : GetOrderStatusText(order.Status);
            txtActualDeliveryDate.Text = deliveryDate.HasValue ? deliveryDate.Value.ToString("dd/MM/yyyy HH:mm") : "---";
            txtHistoryReturnReason.Text = !string.IsNullOrEmpty(returnReason) ? returnReason : (order.CancelReason ?? "Không có");
        }

        private string GetOrderStatusText(string status)
        {
            switch (status)
            {
                case "ReadyDelivery": return "Chờ giao";
                case "Delivering": return "Đang giao";
                case "Completed": return "Giao thành công";
                case "Returned": return "Trả hàng";
                default: return status ?? "Chưa xác định";
            }
        }

        private void ClearForm()
        {
            _selectedOrder = null;
            lblOrderTitle.Text = "Thông tin vận chuyển đơn hàng: ---";
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtExpectedDate.Clear();
            txtInvoiceId.Clear();

            // Clear thêm các field mới
            txtDeliveryStatus.Clear();
            txtActualDeliveryDate.Clear();
            txtHistoryReturnReason.Clear();
        }

        #endregion
    }
}