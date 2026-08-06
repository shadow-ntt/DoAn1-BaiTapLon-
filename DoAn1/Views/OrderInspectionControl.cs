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
    public class OrderDisplayItem
    {
        public Order OrderData { get; set; }
        public string DisplayText { get; set; }

        public override string ToString() => DisplayText;
    }

    public partial class OrderInspectionControl : UserControl
    {
        private readonly SupervisorService _supervisorService;
        private readonly int _currentEmployeeId;
        private readonly bool _isAdmin;
        private Order _selectedOrder;

        public OrderInspectionControl() : this(1, false)
        {
        }

        public OrderInspectionControl(int employeeId = 1, bool isAdmin = false)
        {
            _supervisorService = new SupervisorService();
            _currentEmployeeId = employeeId;
            _isAdmin = isAdmin;

            InitializeComponent();
            LoadPendingOrders();
        }

        private void TxtSearchPending_TextChanged(object sender, EventArgs e) => LoadPendingOrders();

        private void BtnRefreshPending_Click(object sender, EventArgs e)
        {
            txtSearchPending.Clear();
            LoadPendingOrders();
        }

        private void LoadPendingOrders()
        {
            string keyword = txtSearchPending?.Text.Trim() ?? "";
            lstPendingOrders.DataSource = null;
            lstPendingOrders.Items.Clear();

            var res = _supervisorService.GetPendingOrders(_currentEmployeeId, _isAdmin);
            if (res.IsSuccess && res.Data != null)
            {
                var filtered = res.Data.Where(o =>
                    string.IsNullOrEmpty(keyword) ||
                    o.OrderId.ToString().Contains(keyword) ||
                    (o.Customer != null && o.Customer.FullName.ToLower().Contains(keyword.ToLower()))
                ).ToList();

                var displayList = filtered.Select(o => new OrderDisplayItem
                {
                    OrderData = o,
                    DisplayText = $"#{o.OrderId} — {o.Customer?.FullName ?? "Khách lẻ"} ({o.OrderDate:dd/MM/yyyy})"
                }).ToList();

                lstPendingOrders.DataSource = displayList;
                lstPendingOrders.DisplayMember = "DisplayText";

                if (displayList.Count > 0)
                {
                    lstPendingOrders.SelectedIndex = 0;
                }
                else
                {
                    ClearPendingDetails();
                }
            }
            else
            {
                MessageBox.Show(res.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearPendingDetails();
            }
        }

        private void LstPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPendingOrders.SelectedItem is OrderDisplayItem item)
            {
                _selectedOrder = item.OrderData;
                LoadOrderDetails(_selectedOrder);
            }
        }

        private void LoadOrderDetails(Order order)
        {
            if (order == null) return;

            string custName = order.Customer?.FullName ?? "Khách lẻ";
            lblOrderTitle.Text = $"Chi tiết kiểm tra đơn hàng: #{order.OrderId}";
            lblCustomerInfo.Text = $"Khách hàng: {custName} | Ngày đặt: {order.OrderDate:dd/MM/yyyy HH:mm}";

            decimal totalAmount = order.OrderDetails?.Sum(d => d.Quantity * (d.UnitPrice > 0 ? d.UnitPrice : (d.Product?.UnitPrice ?? 0))) ?? 0;
            decimal creditLimit = order.Customer?.CreditLimit ?? 0;

            bool isCreditExceeded = (creditLimit > 0 && totalAmount > creditLimit);

            if (isCreditExceeded)
            {
                lblCreditWarning.ForeColor = Color.Red;
                lblCreditWarning.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                lblCreditWarning.Text = $"⚠ CẢNH BÁO TÍN DỤNG: Đơn hàng ({totalAmount:N0} đ) VƯỢT HẠN MỨC TÍN DỤNG ({creditLimit:N0} đ)!";
            }
            else
            {
                lblCreditWarning.ForeColor = Color.FromArgb(16, 185, 129);
                lblCreditWarning.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                lblCreditWarning.Text = $"✔ TÍN DỤNG HỢP LỆ: Giá trị đơn ({totalAmount:N0} đ) nằm trong hạn mức ({creditLimit:N0} đ).";
            }

            dgvStock.Rows.Clear();
            if (order.OrderDetails != null)
            {
                foreach (var detail in order.OrderDetails)
                {
                    string prodName = detail.Product?.ProductName ?? $"Sản phẩm #{detail.ProductId}";
                    int orderQty = detail.Quantity;
                    int stockQty = detail.Product?.OpeningQuantity ?? 0;
                    string status = stockQty >= orderQty 
                        ? "✔ Đủ hàng" 
                        : $"⚠ Thiếu {orderQty - stockQty} món";

                    int rowIndex = dgvStock.Rows.Add(prodName, orderQty, stockQty, status);
                    if (stockQty < orderQty)
                    {
                        dgvStock.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.Red;
                        dgvStock.Rows[rowIndex].Cells["Status"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    }
                    else
                    {
                        dgvStock.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.FromArgb(16, 185, 129);
                    }
                }
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần duyệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận PHÊ DUYỆT đơn hàng #{_selectedOrder.OrderId}?", "Xác nhận duyệt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _supervisorService.ApproveOrder(_selectedOrder.OrderId);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess) LoadPendingOrders();
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần từ chối!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = txtRejectNotes.Text.Trim();
            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Vui lòng nhập lý do từ chối!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRejectNotes.Focus();
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận TỪ CHỐI đơn hàng #{_selectedOrder.OrderId}?", "Xác nhận từ chối", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var res = _supervisorService.RejectOrder(_selectedOrder.OrderId, reason);
                MessageBox.Show(res.Message, res.IsSuccess ? "Thành công" : "Lỗi", MessageBoxButtons.OK, res.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (res.IsSuccess)
                {
                    txtRejectNotes.Clear();
                    LoadPendingOrders();
                }
            }
        }

        private void ClearPendingDetails()
        {
            _selectedOrder = null;
            lblOrderTitle.Text = "Chi tiết kiểm tra đơn hàng: ---";
            lblCustomerInfo.Text = "Chọn đơn hàng bên trái để xem thông tin.";
            lblCreditWarning.Text = "";
            dgvStock.Rows.Clear();
        }
    }
}
