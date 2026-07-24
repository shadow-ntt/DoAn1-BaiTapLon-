using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Data;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Models.Helpers;

namespace DoAn1.Services
{
    public class DeliveryService
    {
        // 1. LẤY DANH SÁCH ĐƠN CHỜ GIAO
        public ProcessResult<List<Order>> GetPendingOrders(string keyword = "")
        {
            try
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

                    var list = query.OrderBy(o => o.ExpectedDeliveryDate).ToList();

                    return new ProcessResult<List<Order>>
                    {
                        IsSuccess = true,
                        Message = "Lấy danh sách đơn chờ giao thành công.",
                        Data = list
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Order>>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }

        // 2. BẮT ĐẦU GIAO HÀNG
        public ProcessResult<bool> StartDelivery(int orderId, int employeeId)
        {
            try
            {
                using (var db = new AppDbContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                    if (order == null)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không tìm thấy đơn hàng."
                        };
                    }

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

                    return new ProcessResult<bool>
                    {
                        IsSuccess = true,
                        Message = "Bắt đầu giao hàng thành công.",
                        Data = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }

        // 3. LẤY DANH SÁCH ĐƠN ĐANG GIAO CỦA NHÂN VIÊN
        public ProcessResult<List<Delivery>> GetDeliveringOrders(int employeeId, string keyword = "")
        {
            try
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

                    var list = query.OrderByDescending(d => d.AssignedDate).ToList();

                    return new ProcessResult<List<Delivery>>
                    {
                        IsSuccess = true,
                        Message = "Lấy danh sách đơn đang giao thành công.",
                        Data = list
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Delivery>>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }

        // 4. XÁC NHẬN GIAO HÀNG THÀNH CÔNG
        public ProcessResult<bool> ConfirmDeliverySuccess(int orderId)
        {
            try
            {
                using (var db = new AppDbContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                    var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.DeliveredDate == null);

                    if (order == null || delivery == null)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không tìm thấy thông tin đơn hàng hoặc thông tin giao hàng."
                        };
                    }

                    order.Status = "Completed";
                    delivery.DeliveredDate = DateTime.Now;

                    db.SaveChanges();
                    transaction.Commit();

                    return new ProcessResult<bool>
                    {
                        IsSuccess = true,
                        Message = "Xác nhận giao hàng thành công.",
                        Data = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }

        // 5. XÁC NHẬN YÊU CẦU TRẢ HÀNG
        public ProcessResult<bool> ConfirmDeliveryReturn(int orderId, string returnReason)
        {
            try
            {
                using (var db = new AppDbContext())
                using (var transaction = db.Database.BeginTransaction())
                {
                    var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                    var delivery = db.Deliveries.FirstOrDefault(d => d.OrderId == orderId && d.ReturnDate == null);

                    if (order == null || delivery == null)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không tìm thấy thông tin đơn hàng hoặc thông tin giao hàng."
                        };
                    }

                    order.Status = "Returning";
                    order.CancelReason = returnReason;

                    delivery.ReturnDate = DateTime.Now;
                    delivery.ReturnReason = returnReason;

                    db.SaveChanges();
                    transaction.Commit();

                    return new ProcessResult<bool>
                    {
                        IsSuccess = true,
                        Message = "Xác nhận yêu cầu trả hàng thành công.",
                        Data = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }

        // 6. LẤY LỊCH SỬ GIAO HÀNG
        public ProcessResult<List<DeliveryHistoryDTO>> GetDeliveryHistory(int employeeId, string keyword = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.Deliveries.AsNoTracking()
                        .Include(d => d.Order)
                            .ThenInclude(o => o.Customer)
                        .Include(d => d.Order)
                            .ThenInclude(o => o.Invoice)
                        .Where(d => (employeeId <= 0 || d.EmployeeId == employeeId) && (d.DeliveredDate != null || d.ReturnDate != null));

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        keyword = keyword.Trim().ToLower();
                        query = query.Where(d =>
                            d.OrderId.ToString().Contains(keyword) ||
                            (d.Order.Customer != null && d.Order.Customer.FullName.ToLower().Contains(keyword)));
                    }

                    var rawList = query.OrderByDescending(d => d.DeliveredDate ?? d.ReturnDate).ToList();

                    var listDto = rawList.Select(d => new DeliveryHistoryDTO
                    {
                        OrderId = d.OrderId,
                        CustomerName = d.Order.Customer?.FullName ?? "Khách lẻ",
                        StatusText = OrderStatusHelper.GetText(d.Order.Status),
                        DeliveryDate = d.DeliveredDate ?? d.ReturnDate,
                        ReturnReason = d.ReturnReason ?? "",
                        OrderObj = d.Order
                    }).ToList();

                    return new ProcessResult<List<DeliveryHistoryDTO>>
                    {
                        IsSuccess = true,
                        Message = "Lấy lịch sử giao hàng thành công.",
                        Data = listDto
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<DeliveryHistoryDTO>>
                {
                    IsSuccess = false,
                    Message = $"Lỗi hệ thống."
                };
            }
        }
    }
}