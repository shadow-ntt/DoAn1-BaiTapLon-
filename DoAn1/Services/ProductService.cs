using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAn1.Services
{
    public class ProductService
    {
        // 1. Lấy danh sách sản phẩm (Tìm kiếm)
        public ProcessResult<List<Product>> GetAllProducts(string keyword = "")
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var query = db.Products.AsNoTracking().AsQueryable();

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query = query.Where(p => p.ProductName.Contains(keyword) || p.Type.Contains(keyword) || p.ProductId.ToString().Equals(keyword) );
                    }
                    return new ProcessResult<List<Product>> { IsSuccess = true, Data = query.ToList() };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Product>> { IsSuccess = false, Message = "Lỗi hệ thống: " + ex.Message };
            }
        }

        // 2. Nhập hàng mới (Không cần truyền Id vì DB tự tăng)
        public ProcessResult<Product> AddProduct(Product newProduct)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Products.Add(newProduct);
                    db.SaveChanges();
                    return new ProcessResult<Product> { IsSuccess = true, Message = "Nhập sản phẩm mới thành công!", Data = newProduct };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Product> { IsSuccess = false, Message = "Lỗi nhập hàng: " + ex.Message };
            }
        }

        // 3. Sửa thông tin hàng hóa chuẩn chỉ (Không sửa ID)
        public ProcessResult<Product> UpdateProduct(int id, Product updatedData)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var product = db.Products.FirstOrDefault(p => p.ProductId == id);
                    if (product == null)
                        return new ProcessResult<Product> { IsSuccess = false, Message = "Không tìm thấy sản phẩm cần sửa." };

                    // Chỉ sửa các trường thông tin, giữ nguyên PK
                    product.ProductName = updatedData.ProductName;
                    product.Description = updatedData.Description;
                    product.Type = updatedData.Type;
                    product.UnitPrice = updatedData.UnitPrice;
                    product.OpeningQuantity = updatedData.OpeningQuantity;

                    db.SaveChanges();
                    return new ProcessResult<Product> { IsSuccess = true, Message = "Cập nhật thông tin sản phẩm thành công!", Data = product };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Product> { IsSuccess = false, Message = "Lỗi cập nhật: " + ex.Message };
            }
        }

        // 4. Xóa hàng an toàn (Check ràng buộc lịch sử đơn hàng)
        public ProcessResult<bool> DeleteProduct(int id)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // KIỂM TRA RÀNG BUỘC: Nếu đã nằm trong chi tiết đơn hàng thì CẤM XÓA
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
                        return new ProcessResult<bool> { IsSuccess = false, Message = "Sản phẩm không tồn tại hoặc đã bị xóa trước đó." };

                    db.Products.Remove(product);
                    db.SaveChanges();
                    return new ProcessResult<bool> { IsSuccess = true, Message = "Đã xóa sản phẩm khỏi kho thành công!", Data = true };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool> { IsSuccess = false, Message = "Lỗi khi xóa: " + ex.Message };
            }
        }
    }
}