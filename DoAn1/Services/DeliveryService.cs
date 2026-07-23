using DoAn1.Data;
using DoAn1.Models.Tables;
using DoAn1.Models.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAn1.Services
{
    public class DeliveryService
    {
        // 1. LẤY DANH SÁCH ĐƠN CHỜ GIAO
        public List<Order> GetPendingOrders(string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Orders.AsNoTracking()
                    .Include(o => o.Customer)
                    .Include(o => o.Invoice)
                    .Where(o => o.Status == "ReadyDelivery" || (o.Invoice != null && o.Status == "Reviewed"));

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.Trim().ToLower();
                    query = query.Where(o =>
                        o.OrderId.ToString().Contains(keyword) ||
                        (o.Customer != null && o.Customer.FullName.ToLower().Contains(keyword)) ||
                        (o.Customer != null && o.Customer.PhoneNumber.Contains(keyword)));
                }

                return query.OrderBy(o => o.ExpectedDeliveryDate).ToList();
            }
        }

        // 2. BẮT ĐẦU GIAO HÀNG
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

                        order.Status = "Delivering";

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

        // 3. LẤY DANH SÁCH ĐƠN ĐANG GIAO CỦA NHÂN VIÊN
        public List<Delivery> GetDeliveringOrders(int employeeId, string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Deliveries.AsNoTracking()
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Customer)
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Invoice)
                    .Where(d => d.EmployeeId == employeeId && d.Order.Status == "Delivering");

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.Trim().ToLower();
                    query = query.Where(d =>
                        d.OrderId.ToString().Contains(keyword) ||
                        (d.Order.Customer != null && d.Order.Customer.FullName.ToLower().Contains(keyword)) ||
                        (d.Order.Customer != null && d.Order.Customer.PhoneNumber.Contains(keyword)));
                }

                return query.OrderByDescending(d => d.AssignedDate).ToList();
            }
        }

        // 4. XÁC NHẬN GIAO HÀNG THÀNH CÔNG
        public bool ConfirmDeliverySuccess(int orderId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                        var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.DeliveredDate == null);

                        if (order == null || delivery == null) return false;

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

        // 5. XÁC NHẬN YÊU CẦU TRẢ HÀNG
        public bool ConfirmDeliveryReturn(int orderId, string returnReason)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                        var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.ReturnDate == null);

                        if (order == null || delivery == null) return false;

                        order.Status = "Returning";
                        order.CancelReason = returnReason;

                        delivery.ReturnDate = DateTime.Now;
                        delivery.ReturnReason = returnReason;

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

        // 6. LẤY LỊCH SỬ GIAO HÀNG (Sử dụng DTO & Helper)
        // 6. LẤY LỊCH SỬ GIAO HÀNG (Đã sửa lỗi thiếu Invoice)
        public List<DeliveryHistoryDTO> GetDeliveryHistory(int employeeId, string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Deliveries.AsNoTracking()
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Customer)
                    .Include(d => d.Order)
                        .ThenInclude(o => o.Invoice) // 🟢 BỔ SUNG: Include Invoice để lấy dữ liệu hóa đơn
                    .Where(d => (employeeId <= 0 || d.EmployeeId == employeeId) && (d.DeliveredDate != null || d.ReturnDate != null));

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.Trim().ToLower();
                    query = query.Where(d =>
                        d.OrderId.ToString().Contains(keyword) ||
                        (d.Order.Customer != null && d.Order.Customer.FullName.ToLower().Contains(keyword)));
                }

                var rawList = query.OrderByDescending(d => d.DeliveredDate ?? d.ReturnDate).ToList();

                // Map sang DTO an toàn
                return rawList.Select(d => new DeliveryHistoryDTO
                {
                    OrderId = d.OrderId,
                    CustomerName = d.Order.Customer?.FullName ?? "Khách lẻ",
                    StatusText = OrderStatusHelper.GetText(d.Order.Status),
                    DeliveryDate = d.DeliveredDate ?? d.ReturnDate,
                    ReturnReason = d.ReturnReason ?? "",
                    OrderObj = d.Order
                }).ToList();
            }
        }
    }
}