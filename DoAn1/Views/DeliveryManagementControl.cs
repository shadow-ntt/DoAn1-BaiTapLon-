using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAn1.Models.Helpers;
using DoAn1.Models.Tables;
using DoAn1.Services;

namespace DoAn1.Views
{
    public partial class DeliveryManagementControl : UserControl
    {
        private readonly DeliveryService _deliveryService;
        private readonly int _currentEmployeeId;
        private readonly int _viewMode;

        private List<Order> _pendingOrders;
        private List<Delivery> _deliveringOrders;
        private Order _selectedOrder;

        public DeliveryManagementControl() : this(-1, 0)
        {
        }

        public DeliveryManagementControl(int employeeId = -1, int defaultTabIndex = 0)
        {
            _deliveryService = new DeliveryService();
            _currentEmployeeId = employeeId;
            _viewMode = defaultTabIndex;

            InitializeComponent();

            RegisterEvents();

            if (defaultTabIndex >= 0 && defaultTabIndex < tabControlMain.TabCount)
            {
                tabControlMain.SelectedIndex = defaultTabIndex;
            }

            LoadInitialData();
        }

        private void RegisterEvents()
        {
            txtSearchPending.TextChanged += TxtSearchPending_TextChanged;
            btnRefreshPending.Click += BtnRefreshPending_Click;
            lstPendingOrders.SelectedIndexChanged += LstPendingOrders_SelectedIndexChanged;
            btnStartDelivery.Click += BtnStartDelivery_Click;

            txtSearchDelivering.TextChanged += TxtSearchDelivering_TextChanged;
            btnRefreshDelivering.Click += BtnRefreshDelivering_Click;
            lstDeliveringOrders.SelectedIndexChanged += LstDeliveringOrders_SelectedIndexChanged;
            btnConfirmSuccess.Click += BtnConfirmSuccess_Click;
            btnConfirmReturn.Click += BtnConfirmReturn_Click;

            txtSearchHistory.TextChanged += TxtSearchHistory_TextChanged;
            btnRefreshHistory.Click += BtnRefreshHistory_Click;
            dgvHistory.SelectionChanged += DgvHistory_SelectionChanged;

            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0: LoadPendingOrders(); break;
                case 1: LoadDeliveringOrders(); break;
                case 2: LoadDeliveryHistory(); break;
            }
        }

        private void LoadInitialData()
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0: LoadPendingOrders(); break;
                case 1: LoadDeliveringOrders(); break;
                case 2: LoadDeliveryHistory(); break;
            }
        }

        private void TxtSearchPending_TextChanged(object sender, EventArgs e) => LoadPendingOrders();

        private void BtnRefreshPending_Click(object sender, EventArgs e)
        {
            txtSearchPending.Clear();
            LoadPendingOrders();
        }

        private void TxtSearchDelivering_TextChanged(object sender, EventArgs e) => LoadDeliveringOrders();

        private void BtnRefreshDelivering_Click(object sender, EventArgs e)
        {
            txtSearchDelivering.Clear();
            LoadDeliveringOrders();
        }

        private void TxtSearchHistory_TextChanged(object sender, EventArgs e) => LoadDeliveryHistory();

        private void BtnRefreshHistory_Click(object sender, EventArgs e)
        {
            txtSearchHistory.Clear();
            LoadDeliveryHistory();
        }

        private void LoadPendingOrders()
        {
            string keyword = txtSearchPending?.Text.Trim() ?? "";
            var res = _deliveryService.GetPendingOrders(keyword);
            if (lstPendingOrders != null) lstPendingOrders.DataSource = null;

            if (res.IsSuccess && res.Data != null && res.Data.Count > 0)
            {
                _pendingOrders = res.Data;
                var displayList = _pendingOrders.Select(o => new
                {
                    OrderData = o,
                    DisplayText = $"#{o.OrderId} — Khách: {o.Customer?.FullName ?? "Khách lẻ"}"
                }).ToList();

                if (lstPendingOrders != null)
                {
                    lstPendingOrders.DataSource = displayList;
                    lstPendingOrders.DisplayMember = "DisplayText";
                    lstPendingOrders.ValueMember = "OrderData";
                }
            }
            else
            {
                if (lblPendingTitle != null) lblPendingTitle.Text = "Thông tin vận chuyển đơn hàng: ---";
                if (lblPendingCustInfo != null) lblPendingCustInfo.Text = "Không có đơn hàng nào chờ giao.";
                _selectedOrder = null;
            }
        }

        private void LstPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendingOrders?.SelectedItem != null)
            {
                dynamic item = lstPendingOrders.SelectedItem;
                _selectedOrder = item.OrderData as Order;
                DisplayOrderInfo(_selectedOrder, lblPendingTitle, lblPendingCustInfo);
            }
        }

        private void BtnStartDelivery_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận nhận đơn hàng #{_selectedOrder.OrderId} để bắt đầu giao?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _deliveryService.StartDelivery(_selectedOrder.OrderId, _currentEmployeeId);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess) LoadPendingOrders();
            }
        }

        private void LoadDeliveringOrders()
        {
            string keyword = txtSearchDelivering?.Text.Trim() ?? "";
            var res = _deliveryService.GetDeliveringOrders(_currentEmployeeId, keyword);
            if (lstDeliveringOrders != null) lstDeliveringOrders.DataSource = null;

            if (res.IsSuccess && res.Data != null && res.Data.Count > 0)
            {
                _deliveringOrders = res.Data;
                var displayList = _deliveringOrders.Select(d => new
                {
                    DeliveryData = d,
                    DisplayText = $"#{d.OrderId} — Khách: {d.Order?.Customer?.FullName ?? "Khách lẻ"}"
                }).ToList();

                if (lstDeliveringOrders != null)
                {
                    lstDeliveringOrders.DataSource = displayList;
                    lstDeliveringOrders.DisplayMember = "DisplayText";
                    lstDeliveringOrders.ValueMember = "DeliveryData";
                }
            }
            else
            {
                if (lblDeliveringTitle != null) lblDeliveringTitle.Text = "Thông tin đơn đang giao: ---";
                if (lblDeliveringCustInfo != null) lblDeliveringCustInfo.Text = "Không có đơn hàng nào đang giao.";
                _selectedOrder = null;
            }
        }

        private void LstDeliveringOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDeliveringOrders?.SelectedItem != null)
            {
                dynamic item = lstDeliveringOrders.SelectedItem;
                Delivery del = item.DeliveryData as Delivery;
                _selectedOrder = del?.Order;
                DisplayOrderInfo(_selectedOrder, lblDeliveringTitle, lblDeliveringCustInfo);
            }
        }

        private void BtnConfirmSuccess_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận đơn hàng #{_selectedOrder.OrderId} đã giao thành công và đã thu tiền vào quỹ?", "Xác nhận hoàn thành", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _deliveryService.ConfirmDeliverySuccess(_selectedOrder.OrderId);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess) LoadDeliveringOrders();
            }
        }

        private void BtnConfirmReturn_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = txtReturnReason.Text.Trim();
            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Vui lòng nhập lý do trả hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReturnReason.Focus();
                return;
            }

            var res = _deliveryService.ConfirmDeliveryReturn(_selectedOrder.OrderId, reason);
            MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.IsSuccess)
            {
                txtReturnReason.Clear();
                LoadDeliveringOrders();
            }
        }

        private void LoadDeliveryHistory()
        {
            string keyword = txtSearchHistory?.Text.Trim() ?? "";
            var res = _deliveryService.GetDeliveryHistory(_currentEmployeeId, keyword);

            if (res.IsSuccess && res.Data != null && dgvHistory != null)
            {
                dgvHistory.DataSource = res.Data;
                if (dgvHistory.Columns["OrderObj"] != null) dgvHistory.Columns["OrderObj"].Visible = false;
                if (dgvHistory.Columns["OrderId"] != null) dgvHistory.Columns["OrderId"].HeaderText = "Mã Đơn";
                if (dgvHistory.Columns["CustomerName"] != null) dgvHistory.Columns["CustomerName"].HeaderText = "Khách Hàng";
                if (dgvHistory.Columns["StatusText"] != null) dgvHistory.Columns["StatusText"].HeaderText = "Trạng Thái";
                if (dgvHistory.Columns["DeliveryDate"] != null) dgvHistory.Columns["DeliveryDate"].HeaderText = "Ngày Giao";
                if (dgvHistory.Columns["ReturnReason"] != null) dgvHistory.Columns["ReturnReason"].HeaderText = "Lý Do Trả";
            }
        }

        private void DgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistory?.CurrentRow?.DataBoundItem is DeliveryHistoryDTO historyItem)
            {
                string phone = historyItem.OrderObj?.Customer?.PhoneNumber ?? "Chưa có";
                string address = historyItem.OrderObj?.Customer?.Address ?? "Chưa có";
                if (lblHistoryTitle != null) lblHistoryTitle.Text = $"Chi tiết lịch sử đơn hàng: #{historyItem.OrderId}";
                if (lblHistoryDetails != null)
                {
                    lblHistoryDetails.Text = $"• Khách hàng: {historyItem.CustomerName}\n" +
                                             $"• Số điện thoại: {phone}\n" +
                                             $"• Địa chỉ: {address}\n" +
                                             $"• Trạng thái: {historyItem.StatusText}\n" +
                                             $"• Ngày giao: {historyItem.DeliveryDate?.ToString("dd/MM/yyyy HH:mm") ?? "---"}\n" +
                                             $"• Lý do trả: {historyItem.ReturnReason ?? "Không có"}";
                }
            }
        }

        private void DisplayOrderInfo(Order order, Label lblTitle, Label lblDetails)
        {
            if (order == null) return;
            if (lblTitle != null) lblTitle.Text = $"Thông tin vận chuyển đơn hàng: #{order.OrderId}";
            if (lblDetails != null)
            {
                lblDetails.Text = $"• Khách hàng: {order.Customer?.FullName ?? "Khách lẻ"}\n" +
                                  $"• SĐT: {order.Customer?.PhoneNumber ?? "Chưa có"}\n" +
                                  $"• Địa chỉ: {order.Customer?.Address ?? "Chưa có"}\n" +
                                  $"• Ngày giao dự kiến: {order.ExpectedDeliveryDate:dd/MM/yyyy}\n" +
                                  $"• Trạng thái đơn: {OrderStatusHelper.GetText(order.Status)}";
            }
        }
    }
}
