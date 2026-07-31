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
                // 1. Tìm khách hàng cần sửa
                Customer customer = db.Customers.Find(id);
                if (customer == null)
                {
                    return new ProcessResult<Customer> { IsSuccess = false, Message = "Không tìm thấy khách hàng." };
                }

                // 2. Kiểm tra trùng CCCD với khách hàng KHIẾN BỞI ID khác
                bool isIdentityNumberExists = db.Customers.Any(c => c.IdentityNumber == newCustomer.IdentityNumber && c.CustomerId != id);

                if (isIdentityNumberExists)
                {
                    return new ProcessResult<Customer>
                    {
                        IsSuccess = false,
                        Message = "Số CCCD/CMND đã tồn tại trong hệ thống."
                    };
                }

                // 3. Cập nhật thông tin
                customer.IdentityNumber = newCustomer.IdentityNumber;
                customer.FullName = newCustomer.FullName;
                customer.Address = newCustomer.Address;
                customer.City = newCustomer.City;
                customer.PhoneNumber = newCustomer.PhoneNumber;
                customer.PostalCode = newCustomer.PostalCode;
                customer.CreditLimit = newCustomer.CreditLimit;
                customer.TaxCode = newCustomer.TaxCode;

                db.SaveChanges();
                return new ProcessResult<Customer>
                {
                    IsSuccess = true,
                    Message = "Sửa dữ liệu thành công.",
                    Data = customer
                };
            }
            catch (SqlException)
            {
                return new ProcessResult<Customer> { IsSuccess = false, Message = "Lỗi hệ thống database." };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Customer> { IsSuccess = false, Message = "Lỗi hệ thống: " + ex.Message };
            }
        }
        public ProcessResult<Customer> AddCustomer(Customer newCustomer)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // 0. Bắt sự kiện trùng CCCD (IdentityNumber) hoặc Số điện thoại (PhoneNumber)
                    bool isIdentityExist = db.Customers.Any(c => c.IdentityNumber == newCustomer.IdentityNumber);
                    if (isIdentityExist)
                    {
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Số CCCD/CMND này đã tồn tại trong hệ thống!"
                        };
                    }

                    bool isPhoneExist = db.Customers.Any(c => c.PhoneNumber == newCustomer.PhoneNumber);
                    if (isPhoneExist)
                    {
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Số điện thoại này đã tồn tại trong hệ thống!"
                        };
                    }

                    // 1. Tìm tất cả nhân viên có vai trò là Kiểm soát viên (KSV)
                    var ksvList = db.Employees
                                    .Where(e => e.Position == "KiemSoatVien")
                                    .ToList();

                    if (ksvList.Count > 0)
                    {
                        // 2. Bốc ngẫu nhiên 1 ông KSV từ danh sách
                        var random = new Random();
                        var selectedKsv = ksvList[random.Next(ksvList.Count)];

                        // 3. Gán ID của KSV đó vào trường ngoại khóa của Khách hàng mới
                        newCustomer.EmployeeId = selectedKsv.EmployeeId;
                    }
                    else
                    {
                        // Nếu DB chưa có ông KSV nào
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
                        Message = "Thêm khách hàng thành công! Đã tự động phân công KSV phụ trách."
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Customer>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

    }
}
