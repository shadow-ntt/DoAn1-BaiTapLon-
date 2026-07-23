using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Data;

namespace DoAn1.Services
{
    public class SupervisorService
    {
        private readonly AppDbContext db;

        public SupervisorService()
        {
            db = new AppDbContext();
        }

        // 1. Lấy danh sách đơn hàng chờ duyệt (Status = "Created")
        public List<Order> GetPendingOrders(int currentEmployeeId)
        {
            return db.Orders
                .Include(o => o.Customer)
                    .ThenInclude(c => c.Employee)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .Where(o => o.Status == "Created" && o.Customer.Employee.EmployeeId == currentEmployeeId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        // 2. LẤY LỊCH SỬ ĐƠN HÀNG ĐÃ KIỂM DUYỆT (Reviewed hoặc Rejected / Cancelled)
        public List<Order> GetReviewedHistoryOrders(int currentEmployeeId, string keyword = "")
        {
            var query = db.Orders
                .Include(o => o.Customer)
                    .ThenInclude(c => c.Employee)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .Where(o => o.Status != "Created" && o.Customer.Employee.EmployeeId == currentEmployeeId);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim().ToLower();
                query = query.Where(o => o.OrderId.ToString().Contains(keyword) ||
                                         o.Customer.FullName.ToLower().Contains(keyword));
            }

            return query.OrderByDescending(o => o.ReviewedDate ?? o.OrderDate).ToList();
        }

        // 3. Phê duyệt đơn hàng
        public ProcessResult<Order> ApproveOrder(int orderId)
        {
            var order = db.Orders
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
                return new ProcessResult<Order> { IsSuccess = false, Message = "Không tìm thấy đơn hàng." };

            foreach (var detail in order.OrderDetails)
            {
                if (detail.Product.OpeningQuantity < detail.Quantity)
                {
                    return new ProcessResult<Order>
                    {
                        IsSuccess = false,
                        Message = $"Đơn hàng không khả thi! Sản phẩm [{detail.Product.ProductName}] thiếu {detail.Quantity - detail.Product.OpeningQuantity} món."
                    };
                }
            }

            foreach (var detail in order.OrderDetails)
            {
                detail.Product.OpeningQuantity -= detail.Quantity;
            }

            order.Status = "Reviewed";
            order.ReviewedDate = DateTime.Now;

            db.SaveChanges();

            return new ProcessResult<Order>
            {
                IsSuccess = true,
                Message = "Xác nhận đơn hàng HỢP LỆ và KHẢ THI! Đã chuyển vào hồ sơ chờ lập hóa đơn.",
                Data = order
            };
        }

        // 4. Từ chối đơn hàng
        public ProcessResult<Order> RejectOrder(int orderId, string reason)
        {
            var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                return new ProcessResult<Order> { IsSuccess = false, Message = "Không tìm thấy đơn hàng." };

            order.Status = "Rejected";
            order.CancelReason = reason;
            order.ReviewedDate = DateTime.Now;

            db.SaveChanges();
            return new ProcessResult<Order> { IsSuccess = true, Message = "Đã gửi trả đơn hàng không hợp lệ về cho khách hàng.", Data = order };
        }
    }
}