using System;
using System.Collections.Generic;
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

        // 1. LẤY DANH SÁCH ĐƠN HÀNG CHỜ DUYỆT (Status = "Created")
        public ProcessResult<List<Order>> GetPendingOrders(int currentEmployeeId, bool isAdmin = false)
        {
            try
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                        .ThenInclude(c => c.Employee)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                    .Where(o => o.Status == "Created");

                if (!isAdmin)
                {
                    query = query.Where(o => o.Customer.Employee.EmployeeId == currentEmployeeId);
                }

                var list = query.OrderByDescending(o => o.OrderDate).ToList();

                return new ProcessResult<List<Order>>
                {
                    IsSuccess = true,
                    Message = "Lấy danh sách đơn hàng chờ duyệt thành công.",
                    Data = list
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Order>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        // 2. LẤY LỊCH SỬ ĐƠN HÀNG ĐÃ KIỂM DUYỆT (Reviewed hoặc Rejected / Cancelled)
        public ProcessResult<List<Order>> GetReviewedHistoryOrders(int currentEmployeeId, string keyword = "", bool isAdmin = false)
        {
            try
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                        .ThenInclude(c => c.Employee)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                    .Where(o => o.Status != "Created");

                if (!isAdmin)
                {
                    query = query.Where(o => o.Customer.Employee.EmployeeId == currentEmployeeId);
                }

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.Trim().ToLower();
                    query = query.Where(o => o.OrderId.ToString().Contains(keyword) ||
                                             o.Customer.FullName.ToLower().Contains(keyword));
                }

                var list = query.OrderByDescending(o => o.ReviewedDate ?? o.OrderDate).ToList();

                return new ProcessResult<List<Order>>
                {
                    IsSuccess = true,
                    Message = "Lấy lịch sử đơn hàng đã kiểm duyệt thành công.",
                    Data = list
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Order>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        // 3. PHÊ DUYỆT ĐƠN HÀNG
        public ProcessResult<Order> ApproveOrder(int orderId, bool forceApprove = false)
        {
            try
            {
                var order = db.Orders
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                    .FirstOrDefault(o => o.OrderId == orderId);

                if (order == null)
                {
                    return new ProcessResult<Order>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy đơn hàng."
                    };
                }

                if (!forceApprove)
                {
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
                }

                foreach (var detail in order.OrderDetails)
                {
                    detail.Product.OpeningQuantity = Math.Max(0, detail.Product.OpeningQuantity - detail.Quantity);
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
            catch (Exception ex)
            {
                return new ProcessResult<Order>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        // 4. TỪ CHỐI ĐƠN HÀNG
        public ProcessResult<Order> RejectOrder(int orderId, string reason)
        {
            try
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order == null)
                {
                    return new ProcessResult<Order>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy đơn hàng."
                    };
                }

                order.Status = "Rejected";
                order.CancelReason = reason;
                order.ReviewedDate = DateTime.Now;

                db.SaveChanges();

                return new ProcessResult<Order>
                {
                    IsSuccess = true,
                    Message = "Đã gửi trả đơn hàng không hợp lệ về cho khách hàng.",
                    Data = order
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Order>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }
    }
}