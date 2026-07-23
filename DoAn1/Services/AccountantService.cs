using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Models.Tables;
using DoAn1.Models.Views;
using DoAn1.Data;
namespace DoAn1.Services
{
    public class AccountantService
    {
        // 1. Lấy các đơn đặt hàng hợp lệ (Status = "Reviewed") chờ lập hóa đơn
        public List<Order> GetApprovedOrders()
        {
            using (var db = new AppDbContext())
            {
                return db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                    .Where(o => o.Status.Trim() == "Reviewed")
                    .OrderBy(o => o.OrderDate)
                    .ToList();
            }
        }

        // 2. Lập hóa đơn và chuyển trạng thái đơn hàng sang "ReadyDelivery"
        public bool ProcessInvoiceAndPackingSlip(int orderId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                        if (order == null || order.Status != "Reviewed") return false;

                        // 1. Lưu hóa đơn vào hồ sơ
                        var invoice = new Invoice
                        {
                            OrderId = order.OrderId,
                            InvoiceDate = DateTime.Now
                        };
                        db.Invoices.Add(invoice);

                        // 2. Chuyển trạng thái sang Sẵn sàng giao hàng
                        order.Status = "ReadyDelivery";

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // 3. LẤY VÀ LỌC DỮ LIỆU DOANH THU (CHỈ LẤY CÁC ĐƠN HOÀN THÀNH / CHUYỂN TIỀN XONG - Completed)
        public List<RevenueReportDTO> GetRevenueReport(DateTime? fromDate = null, DateTime? toDate = null, string keyword = "")
        {
            using (var db = new AppDbContext())
            {
                // Chỉ lọc các hóa đơn thuộc đơn hàng đã hoàn tất (Status = "Completed")
                var query = db.Invoices
                    .Include(i => i.Order)
                        .ThenInclude(o => o.Customer)
                    .Include(i => i.Order)
                        .ThenInclude(o => o.OrderDetails)
                    .Include(i => i.Order)
                        .ThenInclude(o => o.Delivery)
                    .Where(i => i.Order.Status.Trim() == "Completed")
                    .AsQueryable();

                // Lọc theo khoảng thời gian giao hàng thành công (DeliveredDate) hoặc ngày lập hóa đơn
                if (fromDate.HasValue)
                {
                    DateTime start = fromDate.Value.Date;
                    query = query.Where(i => (i.Order.Delivery != null && i.Order.Delivery.DeliveredDate.HasValue)
                        ? i.Order.Delivery.DeliveredDate.Value >= start
                        : i.InvoiceDate >= start);
                }

                if (toDate.HasValue)
                {
                    DateTime end = toDate.Value.Date.AddDays(1).AddTicks(-1);
                    query = query.Where(i => (i.Order.Delivery != null && i.Order.Delivery.DeliveredDate.HasValue)
                        ? i.Order.Delivery.DeliveredDate.Value <= end
                        : i.InvoiceDate <= end);
                }

                // Lọc theo từ khóa (Mã hóa đơn, Mã đơn hàng, Tên khách hàng, MST)
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    string key = keyword.Trim().ToLower();
                    query = query.Where(i =>
                        i.InvoiceId.ToString().Contains(key) ||
                        i.OrderId.ToString().Contains(key) ||
                        (i.Order.Customer != null && i.Order.Customer.FullName.ToLower().Contains(key)) ||
                        (i.Order.Customer != null && i.Order.Customer.TaxCode.ToLower().Contains(key))
                    );
                }

                // Projection sang DTO để hiển thị lên DataGridView
                var result = query
                    .OrderByDescending(i => i.Order.Delivery != null && i.Order.Delivery.DeliveredDate.HasValue
                        ? i.Order.Delivery.DeliveredDate.Value
                        : i.InvoiceDate)
                    .Select(i => new RevenueReportDTO
                    {
                        InvoiceId = i.InvoiceId,
                        OrderId = i.OrderId,
                        CustomerName = i.Order.Customer != null ? i.Order.Customer.FullName : "Khách hàng vãng lai",
                        TaxCode = i.Order.Customer != null ? i.Order.Customer.TaxCode : "N/A",
                        PaidDate = i.Order.Delivery != null && i.Order.Delivery.DeliveredDate.HasValue
                            ? i.Order.Delivery.DeliveredDate.Value
                            : i.InvoiceDate,
                        TotalAmount = i.Order.OrderDetails.Sum(od => od.Quantity * od.UnitPrice),
                        Status = i.Order.Status
                    })
                    .ToList();

                return result;
            }
        }
    }
}