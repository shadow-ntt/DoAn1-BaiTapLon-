using System;
using System.Collections.Generic;
using System.Linq;
using DoAn1.Data;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Models.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DoAn1.Services
{
    public class ProductService
    {
        #region TAB 1: Inventory Management (Quản lý tồn kho)

        #region 1.1 Read Operations

        public ProcessResult<List<Product>> GetAllProducts(string keyword = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.Products.AsNoTracking().AsQueryable();

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        keyword = keyword.Trim();
                        query = query.Where(p => p.ProductName.Contains(keyword)
                                              || p.Type.Contains(keyword)
                                              || p.ProductId.ToString().Equals(keyword));
                    }

                    return new ProcessResult<List<Product>>
                    {
                        IsSuccess = true,
                        Data = query.ToList()
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Product>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }

        #endregion

        #region 1.2 Write Operations (CRUD)

        public ProcessResult<Product> AddProduct(Product newProduct)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Products.Add(newProduct);
                    db.SaveChanges();

                    return new ProcessResult<Product>
                    {
                        IsSuccess = true,
                        Message = "Nhập sản phẩm mới thành công!",
                        Data = newProduct
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Product>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống"
                };
            }
        }

        public ProcessResult<Product> UpdateProduct(int id, Product updatedData)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var product = db.Products.FirstOrDefault(p => p.ProductId == id);
                    if (product == null)
                    {
                        return new ProcessResult<Product>
                        {
                            IsSuccess = false,
                            Message = "Không tìm thấy sản phẩm cần sửa."
                        };
                    }

                    product.ProductName = updatedData.ProductName;
                    product.Description = updatedData.Description;
                    product.Type = updatedData.Type;
                    product.UnitPrice = updatedData.UnitPrice;
                    product.OpeningQuantity = updatedData.OpeningQuantity;

                    db.SaveChanges();

                    return new ProcessResult<Product>
                    {
                        IsSuccess = true,
                        Message = "Cập nhật thông tin sản phẩm thành công!",
                        Data = product
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Product>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }

        public ProcessResult<bool> DeleteProduct(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    bool hasOrder = db.OrderDetails.Any(od => od.ProductId == id);
                    if (hasOrder)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không được xóa! Mặt hàng này đã tồn tại trong lịch sử đơn hàng của khách.",
                            Data = false
                        };
                    }

                    var product = db.Products.FirstOrDefault(p => p.ProductId == id);
                    if (product == null)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Sản phẩm không tồn tại hoặc đã bị xóa trước đó."
                        };
                    }

                    db.Products.Remove(product);
                    db.SaveChanges();

                    return new ProcessResult<bool>
                    {
                        IsSuccess = true,
                        Message = "Đã xóa sản phẩm khỏi kho thành công!",
                        Data = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }

        #endregion

        #endregion

        #region TAB 2: Return Order Approval (Duyệt đơn trả hàng)

        #region 2.1 Read Operations

        public ProcessResult<List<ReturnOrderDTO>> GetReturnOrders(string keyword = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.Orders.AsNoTracking()
                        .Where(o => o.Status == "Returning");

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        keyword = keyword.Trim().ToLower();
                        query = query.Where(o =>
                            o.OrderId.ToString().Contains(keyword) ||
                            (o.Customer != null && o.Customer.FullName.ToLower().Contains(keyword)) ||
                            (o.Invoice != null && o.Invoice.InvoiceId.ToString().Contains(keyword)));
                    }

                    // Dùng trực tiếp o.Delivery (số ít)
                    var list = query.Select(o => new ReturnOrderDTO
                    {
                        OrderId = o.OrderId,
                        CustomerName = o.Customer != null ? o.Customer.FullName : "Khách vô danh",
                        OrderDate = o.OrderDate,
                        InvoiceDate = o.Invoice != null ? o.Invoice.InvoiceDate : (DateTime?)null, 
                        Status = OrderStatusHelper.GetText(o.Status),
                        // EF Core tự dịch o.Delivery.ReturnReason ra LEFT JOIN SQL COALESCE
                        ReturnReason = o.Delivery.ReturnReason
                                       ?? o.CancelReason
                                       ?? "Không ghi rõ lý do"
                    })
                    .OrderByDescending(r => r.OrderId)
                    .ToList();

                    return new ProcessResult<List<ReturnOrderDTO>>
                    {
                        IsSuccess = true,
                        Data = list
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<ReturnOrderDTO>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }

        public ProcessResult<List<ReturnOrderDetailDTO>> GetReturnOrderDetails(int orderId)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var details = db.OrderDetails.AsNoTracking()
                        .Where(od => od.OrderId == orderId)
                        .Select(od => new ReturnOrderDetailDTO
                        {
                            ProductId = od.ProductId,
                            ProductName = od.Product != null ? od.Product.ProductName : "N/A",
                            Quantity = od.Quantity,
                            UnitPrice = od.UnitPrice
                        })
                        .ToList();

                    return new ProcessResult<List<ReturnOrderDetailDTO>>
                    {
                        IsSuccess = true,
                        Data = details
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<ReturnOrderDetailDTO>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống."
                };
            }
        }

        #endregion

        #region 2.2 Transaction Operations

        public ProcessResult<bool> ApproveReturnOrder(int orderId)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var order = db.Orders
                            .Include(o => o.OrderDetails)
                                .ThenInclude(od => od.Product)
                            .FirstOrDefault(o => o.OrderId == orderId);

                        if (order == null)
                        {
                            return new ProcessResult<bool>
                            {
                                IsSuccess = false,
                                Message = "Không tìm thấy đơn hàng!"
                            };
                        }

                        if (order.Status != "Returning")
                        {
                            return new ProcessResult<bool>
                            {
                                IsSuccess = false,
                                Message = $"Đơn hàng đang ở trạng thái [{order.Status}], không thể duyệt trả hàng!"
                            };
                        }

                        // Cập nhật tồn kho qua Navigation Property
                        foreach (var detail in order.OrderDetails)
                        {
                            if (detail.Product != null)
                            {
                                detail.Product.OpeningQuantity += detail.Quantity;
                            }
                        }

                        order.Status = "Returned";

                        db.SaveChanges();
                        transaction.Commit();

                        return new ProcessResult<bool>
                        {
                            IsSuccess = true,
                            Message = $"Đã duyệt trả hàng thành công cho Đơn #{orderId}. Số lượng đã được cộng lại vào kho!",
                            Data = true
                        };
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Lỗi hệ thống."
                        };
                    }
                }
            }
        }

        #endregion

        #endregion
    }
}