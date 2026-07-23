using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Models.Tables;
using DoAn1.Data;

namespace DoAn1.Services
{
    public class DeliveryService
    {
        // 1. LẤY DANH SÁCH ĐƠN CHỜ GIAO (Có hỗ trợ tìm kiếm)
        // Điều kiện: Đơn có Status = "ReadyDelivery" (hoặc đã có Hóa đơn nhưng chưa được giao)
        public List<Order> GetPendingOrders(string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.Invoice)
                    .Where(o => o.Status == "ReadyDelivery" || (o.Invoice != null && o.Status == "Reviewed"));

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.ToLower();
                    query = query.Where(o =>
                        o.OrderId.ToString().Contains(keyword) ||
                        (o.Customer != null && o.Customer.FullName.ToLower().Contains(keyword)) ||
                        (o.Customer != null && o.Customer.PhoneNumber.Contains(keyword)));
                }

                return query.OrderBy(o => o.ExpectedDeliveryDate).ToList();
            }
        }

        // 2. BẮT ĐẦU GIAO HÀNG (Nút "Giao hàng" ở Tab 1)
        public bool StartDelivery(int orderId, int employeeId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                        if (order == null) return false;

                        // Cập nhật trạng thái đơn hàng sang Delivering
                        order.Status = "Delivering";

                        // Tạo bản ghi vận chuyển trong bảng Delivery
                        var delivery = new Delivery
                        {
                            OrderId = orderId,
                            EmployeeId = employeeId,
                            AssignedDate = DateTime.Now
                        };
                        db.Deliveries.Add(delivery);

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // 3. LẤY DANH SÁCH ĐƠN ĐANG GIAO CỦA NHÂN VIÊN (Có hỗ trợ tìm kiếm)
        public List<Delivery> GetDeliveringOrders(int employeeId, string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Deliveries
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Customer)
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Invoice)
                    .Where(d => d.EmployeeId == employeeId && d.Order.Status == "Delivering");

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.ToLower();
                    query = query.Where(d =>
                        d.OrderId.ToString().Contains(keyword) ||
                        (d.Order.Customer != null && d.Order.Customer.FullName.ToLower().Contains(keyword)) ||
                        (d.Order.Customer != null && d.Order.Customer.PhoneNumber.Contains(keyword)));
                }

                return query.OrderByDescending(d => d.AssignedDate).ToList();
            }
        }

        // 4. XÁC NHẬN GIAO HÀNG THÀNH CÔNG (Nút ở Tab 2)
        public bool ConfirmDeliverySuccess(int orderId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders
                            .Include(o => o.Invoice)
                            .FirstOrDefault(o => o.OrderId == orderId);

                        var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.DeliveredDate == null);

                        if (order == null || delivery == null) return false;

                        // Cập nhật trạng thái Đơn hàng & Delivery
                        order.Status = "Completed";
                        delivery.DeliveredDate = DateTime.Now;

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // 5. XÁC NHẬN TRẢ HÀNG (Nút ở Tab 2)
        public bool ConfirmDeliveryReturn(int orderId, string returnReason)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Thêm Include(o => o.OrderDetails) để lấy thông tin các sản phẩm trong đơn
                        var order = db.Orders
                            .Include(o => o.OrderDetails)
                            .FirstOrDefault(o => o.OrderId == orderId);

                        var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.ReturnDate == null);

                        if (order == null || delivery == null) return false;

                        // Cập nhật trạng thái đơn hàng bị trả
                        order.Status = "Returned";
                        order.CancelReason = returnReason;

                        // Cập nhật thông tin trả hàng trong Delivery
                        delivery.ReturnDate = DateTime.Now;
                        delivery.ReturnReason = returnReason;

                        // HOÀN SỐ LƯỢNG HÀNG VÀO KHO (TĂNG OPENINGQUANTITY)
                        foreach (var detail in order.OrderDetails)
                        {
                            var product = db.Products.FirstOrDefault(p => p.ProductId == detail.ProductId);
                            if (product != null)
                            {
                                product.OpeningQuantity += detail.Quantity;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // 6. LẤY LỊCH SỬ GIAO HÀNG CỦA NHÂN VIÊN (Có hỗ trợ tìm kiếm)
        public List<dynamic> GetDeliveryHistory(int employeeId, string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Deliveries
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Customer)
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Invoice)
                    .Where(d => d.EmployeeId == employeeId && (d.DeliveredDate != null || d.ReturnDate != null));

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.ToLower();
                    query = query.Where(d =>
                        d.OrderId.ToString().Contains(keyword) ||
                        (d.Order.Customer != null && d.Order.Customer.FullName.ToLower().Contains(keyword)));
                }

                return query.Select(d => new
                {
                    Mã_Đơn = d.OrderId,
                    Khách_Hàng = d.Order.Customer != null ? d.Order.Customer.FullName : "Khách lẻ",
                    Trạng_Thái = d.DeliveredDate != null ? "Giao thành công" : "Trả hàng",
                    Ngày_Giao = d.DeliveredDate ?? d.ReturnDate,
                    Lý_Do_Trả = d.ReturnReason ?? "",
                    OrderObj = d.Order // Lưu đối tượng Order để đổ data lên panel
                })
                .OrderByDescending(d => d.Ngày_Giao)
                .ToList<dynamic>();
            }
        }
    }
}