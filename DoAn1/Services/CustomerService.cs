using DoAn1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;
using DoAn1.Data;

namespace DoAn1.Clonee.Services
{
    public class CustomerService
    {
        private static AppDbContext db = new AppDbContext();

        public ProcessResult<List<Customer>> GetAllCustomers(string keyword = "")
        {
            try
            {
                using (var localDb = new AppDbContext())
                {
                    var query = localDb.Customers
                        .Include(c => c.Employee)
                        .AsQueryable();

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        keyword = keyword.Trim().ToLower();
                        query = query.Where(c => c.FullName.ToLower().Contains(keyword) ||
                                                 c.IdentityNumber.Contains(keyword) ||
                                                 c.PhoneNumber.Contains(keyword) ||
                                                 c.City.ToLower().Contains(keyword));
                    }

                    var list = query.OrderByDescending(c => c.CustomerId).ToList();

                    return new ProcessResult<List<Customer>>
                    {
                        IsSuccess = true,
                        Message = "Lấy danh sách khách hàng thành công.",
                        Data = list
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Customer>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<List<Employee>> GetSupervisors()
        {
            try
            {
                using (var localDb = new AppDbContext())
                {
                    var ksvList = localDb.Employees
                        .OrderBy(e => e.EmployeeId)
                        .ToList();

                    return new ProcessResult<List<Employee>>
                    {
                        IsSuccess = true,
                        Message = "Lấy danh sách nhân viên phụ trách thành công.",
                        Data = ksvList
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Employee>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<Customer> SearchCustomer(string IdentityNumber)
        {
            try
            {
                using (var localDb = new AppDbContext())
                {
                    Customer customer = localDb.Customers.Include(c => c.Employee).FirstOrDefault(z => z.IdentityNumber.Equals(IdentityNumber));
                    if (customer != null) return new ProcessResult<Customer> { IsSuccess = true, Message = "Tìm thấy thành công.", Data = customer };
                    return new ProcessResult<Customer> { IsSuccess = false, Message = "Không tìm thấy khách hàng với CCCD/CMND này." };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<Customer> { IsSuccess = false, Message = "Lỗi hệ thống: " + ex.Message };
            }
        }

        public ProcessResult<Customer> UpdateCustomer(int id, Customer newCustomer)
        {
            try
            {
                using (var localDb = new AppDbContext())
                {
                    Customer customer = localDb.Customers.Find(id);
                    if (customer == null)
                    {
                        return new ProcessResult<Customer> { IsSuccess = false, Message = "Không tìm thấy khách hàng." };
                    }

                    bool isIdentityNumberExists = localDb.Customers.Any(c => c.IdentityNumber == newCustomer.IdentityNumber && c.CustomerId != id);
                    if (isIdentityNumberExists)
                    {
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Số CCCD/CMND đã tồn tại trong hệ thống."
                        };
                    }

                    customer.IdentityNumber = newCustomer.IdentityNumber;
                    customer.FullName = newCustomer.FullName;
                    customer.Address = newCustomer.Address;
                    customer.City = newCustomer.City;
                    customer.PhoneNumber = newCustomer.PhoneNumber;
                    customer.PostalCode = newCustomer.PostalCode;
                    customer.CreditLimit = newCustomer.CreditLimit;
                    customer.TaxCode = newCustomer.TaxCode;

                    if (newCustomer.EmployeeId > 0)
                    {
                        customer.EmployeeId = newCustomer.EmployeeId;
                    }

                    localDb.SaveChanges();
                    return new ProcessResult<Customer>
                    {
                        IsSuccess = true,
                        Message = "Sửa dữ liệu khách hàng thành công.",
                        Data = customer
                    };
                }
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
                using (var localDb = new AppDbContext())
                {
                    bool isIdentityExist = localDb.Customers.Any(c => c.IdentityNumber == newCustomer.IdentityNumber);
                    if (isIdentityExist)
                    {
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Số CCCD/CMND này đã tồn tại trong hệ thống!"
                        };
                    }

                    bool isPhoneExist = localDb.Customers.Any(c => c.PhoneNumber == newCustomer.PhoneNumber);
                    if (isPhoneExist)
                    {
                        return new ProcessResult<Customer>
                        {
                            IsSuccess = false,
                            Message = "Số điện thoại này đã tồn tại trong hệ thống!"
                        };
                    }

                    if (newCustomer.EmployeeId <= 0)
                    {
                        var ksvList = localDb.Employees
                                        .Where(e => e.Position == "KiemSoatVien" || e.DepartmentId == "KSV")
                                        .ToList();

                        if (ksvList.Count > 0)
                        {
                            var random = new Random();
                            var selectedKsv = ksvList[random.Next(ksvList.Count)];
                            newCustomer.EmployeeId = selectedKsv.EmployeeId;
                        }
                        else
                        {
                            return new ProcessResult<Customer>
                            {
                                IsSuccess = false,
                                Message = "Vui lòng chọn Kiểm soát viên phụ trách!"
                            };
                        }
                    }

                    localDb.Customers.Add(newCustomer);
                    localDb.SaveChanges();

                    return new ProcessResult<Customer>
                    {
                        IsSuccess = true,
                        Data = newCustomer,
                        Message = "Thêm khách hàng mới thành công!"
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

        public ProcessResult<bool> DeleteCustomer(int customerId)
        {
            try
            {
                using (var localDb = new AppDbContext())
                {
                    var customer = localDb.Customers.FirstOrDefault(c => c.CustomerId == customerId);
                    if (customer == null)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không tìm thấy khách hàng!"
                        };
                    }

                    bool hasOrders = localDb.Orders.Any(o => o.CustomerId == customerId);
                    if (hasOrders)
                    {
                        return new ProcessResult<bool>
                        {
                            IsSuccess = false,
                            Message = "Không thể xóa khách hàng này vì đã có đơn đặt hàng liên quan!"
                        };
                    }

                    localDb.Customers.Remove(customer);
                    localDb.SaveChanges();

                    return new ProcessResult<bool>
                    {
                        IsSuccess = true,
                        Message = "Đã xóa khách hàng thành công!",
                        Data = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new ProcessResult<bool>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }
    }
}
