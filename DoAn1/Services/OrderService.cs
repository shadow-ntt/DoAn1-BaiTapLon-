using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Models.Helpers;
using DoAn1.Data;

namespace DoAn1.Clonee.Services
{
    public class OrderService
    {
        // Khởi tạo DbContext riêng cho mỗi instance của Service để tránh lỗi bất đồng bộ và leak bộ nhớ
        private readonly AppDbContext db;

        public OrderService()
        {
            db = new AppDbContext();
        }

        public ProcessResult<Product> getProduct(int productId)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(z => z.ProductId == productId);
                if (product == null)
                    return new ProcessResult<Product>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm." };

                return new ProcessResult<Product>() { IsSuccess = true, Message = "Lấy sản phẩm thành công.", Data = product };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Product>() { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<Order> AddOrder(int customerId, int employeeId, DateTime expectedDeliveryDate)
        {
            try
            {
                Order order = new Order
                {
                    OrderDate = DateTime.Now,
                    Status = "Created",
                    CustomerId = customerId,
                    ExpectedDeliveryDate = expectedDeliveryDate
                };
                db.Orders.Add(order);
                db.SaveChanges();

                return new ProcessResult<Order> { IsSuccess = true, Message = "Thêm đơn đặt hàng thành công", Data = order };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Order> { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<List<Product>> getAllProductInOrder(int orderId)
        {
            try
            {
                Order order = db.Orders.FirstOrDefault(z => z.OrderId == orderId);
                if (order == null)
                    return new ProcessResult<List<Product>>() { IsSuccess = false, Message = "Không tìm thấy đơn đặt hàng." };

                List<Product> products = db.OrderDetails
                    .Where(z => z.OrderId == orderId)
                    .Select(z => z.Product)
                    .ToList();

                return new ProcessResult<List<Product>>() { IsSuccess = true, Message = "Lấy danh sách sản phẩm đã đặt thành công", Data = products };
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Product>>() { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<OrderGridView> AddProduct(int orderId, int productId, int quantity)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(z => z.ProductId == productId);
                if (product == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm." };

                Order order = db.Orders.FirstOrDefault(z => z.OrderId == orderId);
                if (order == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy đơn đặt hàng." };

                // Nếu sản phẩm đã có sẵn trong chi tiết đơn hàng, ta nên cộng dồn số lượng thay vì thêm dòng mới
                OrderDetail existingDetail = db.OrderDetails.FirstOrDefault(z => z.ProductId == productId && z.OrderId == orderId);
                if (existingDetail != null)
                {
                    existingDetail.Quantity += quantity;
                }
                else
                {
                    OrderDetail orderDetail = new OrderDetail() { OrderId = orderId, ProductId = productId, Quantity = quantity, UnitPrice = product.UnitPrice };
                    db.OrderDetails.Add(orderDetail);
                }

                db.SaveChanges();
                return new ProcessResult<OrderGridView>() { IsSuccess = true, Message = "Thêm sản phẩm vào đơn hàng thành công." };
            }
            catch (Exception ex)
            {
                return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<OrderGridView> DeleteProduct(int orderId, int productId)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(z => z.ProductId == productId);
                if (product == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm." };

                Order order = db.Orders.FirstOrDefault(z => z.OrderId == orderId);
                if (order == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy đơn đặt hàng." };

                OrderDetail orderDetailDelete = db.OrderDetails.FirstOrDefault(z => z.ProductId == productId && z.OrderId == orderId);

                if (orderDetailDelete == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm trong đơn đặt hàng này." };

                db.OrderDetails.Remove(orderDetailDelete);
                db.SaveChanges();
                return new ProcessResult<OrderGridView>() { IsSuccess = true, Message = "Xóa sản phẩm khỏi đơn hàng thành công." };
            }
            catch (Exception ex)
            {
                return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<OrderGridView> UpdateOrder(int orderId, int productId, int quantity)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(z => z.ProductId == productId);
                if (product == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm." };

                Order order = db.Orders.FirstOrDefault(z => z.OrderId == orderId);
                if (order == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy đơn đặt hàng." };

                OrderDetail orderDetail = db.OrderDetails.FirstOrDefault(z => z.ProductId == productId && z.OrderId == orderId);

                if (orderDetail == null)
                    return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = "Không tìm thấy sản phẩm trong đơn đặt hàng cần cập nhật." };

                orderDetail.Quantity = quantity;
                db.SaveChanges();
                return new ProcessResult<OrderGridView>() { IsSuccess = true, Message = "Cập nhật số lượng sản phẩm thành công." };
            }
            catch (Exception ex)
            {
                return new ProcessResult<OrderGridView>() { IsSuccess = false, Message = $"Lỗi hệ thống." };
            }
        }

        public ProcessResult<decimal> SumOrder(int orderId)
        {
            try
            {
                Order order = db.Orders.FirstOrDefault(z => z.OrderId == orderId);
                if (order == null)
                    return new ProcessResult<decimal>() { IsSuccess = false, Message = "Không tìm thấy đơn đặt hàng.", Data = 0 };

                decimal sum = db.OrderDetails.Where(x => x.OrderId == orderId).Sum(x => x.Quantity * x.UnitPrice);
                return new ProcessResult<decimal>() { IsSuccess = true, Message = "Tính tổng thành công", Data = sum };
            }
            catch (Exception ex)
            {
                return new ProcessResult<decimal>() { IsSuccess = false, Message = $"Lỗi hệ thống.", Data = 0 };
            }
        }
    }
}