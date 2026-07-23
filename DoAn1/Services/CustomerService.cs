using DoAn1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Data;
namespace DoAn1.Clonee.Services
{
    public class CustomerService
    {
        private static AppDbContext db = new AppDbContext();
        public ProcessResult<Customer> SearchCustomer(string IdentityNumber)
        {
            try
            {
                Customer customer = db.Customers.FirstOrDefault(z=>z.IdentityNumber.Equals(IdentityNumber));
                if(customer!=null) return new ProcessResult<Customer> { IsSuccess = true, Message = "Tìm thấy thành công.", Data=customer };
                return new ProcessResult<Customer> { IsSuccess = false, Message = "Không tìm thấy." };
            }
            catch (SqlException)
            {
            return new ProcessResult<Customer> { IsSuccess = false, Message = "Lỗi hệ thống." };
            }
        }
        public ProcessResult<Customer> UpdateCustomer(int id, Customer newCustomer)
        {
            try
            {
                Customer customer = db.Customers.Find(id);
                if (customer != null)
                {
                    customer.IdentityNumber = newCustomer.IdentityNumber;
                    customer.FullName = newCustomer.FullName;
                    customer.Address = newCustomer.Address;
                    customer.City = newCustomer.City;
                    customer.PhoneNumber = newCustomer.PhoneNumber;
                    customer.PostalCode = newCustomer.PostalCode;
                    customer.CreditLimit = newCustomer.CreditLimit;
                    customer.TaxCode = newCustomer.TaxCode;
                    db.SaveChanges();
                    return new ProcessResult<Customer> { IsSuccess = true, Message = "Sửa dữ liệu thành công.", Data=customer };
                }

                return new ProcessResult<Customer> { IsSuccess = false, Message = "Không tìm thấy khách hàng." };
            }
            catch (SqlException)
            {
                return new ProcessResult<Customer> { IsSuccess = false, Message = "Lỗi hệ thống." };
            }
        }
        public ProcessResult<Customer> AddCustomer(Customer newCustomer)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // 1. Tìm tất cả nhân viên có vai trò là Kiểm soát viên (KSV)
                    // LƯU Ý: Thay "Role" hoặc "ChucVu" bằng tên trường phân quyền trong bảng Employee của mày
                    var ksvList = db.Employees
                                    .Where(e => e.Position == "KiemSoatVien" )
                                    .ToList();

                    if (ksvList.Count > 0)
                    {
                        // 2. Bốc ngẫu nhiên 1 ông KSV từ danh sách
                        var random = new Random();
                        var selectedKsv = ksvList[random.Next(ksvList.Count)];

                        // 3. Gán ID của KSV đó vào trường ngoại khóa của Khách hàng mới
                        // LƯU Ý: Thay "EmployeeId" bằng tên cột khóa ngoại KSV trong bảng Customer của mày nhé
                        newCustomer.EmployeeId = selectedKsv.EmployeeId;
                    }
                    else
                    {
                        // Nếu DB chưa có ông KSV nào, ném ra thông báo để đi tạo KSV trước đã
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Không thể thêm khách hàng vì hệ thống chưa có Kiểm soát viên nào để phụ trách!"
                        };
                    }

                    // 4. Thêm vào DB và lưu thay đổi
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();

                    return new ProcessResult<Customer>
                    {
                        IsSuccess = true,
                        Data = newCustomer,
                        Message = $"Thêm khách hàng thành công! Đã tự động phân công KSV phụ trách."
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Customer>
                {
                    IsSuccess = false,
                    Message = "Lỗi khi thêm khách hàng: " + ex.Message
                };
            }
        }

    }
}
