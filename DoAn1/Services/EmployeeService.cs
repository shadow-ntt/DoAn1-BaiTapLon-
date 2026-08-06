using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DoAn1.Data;
using DoAn1.Models.Results;
using DoAn1.Models.Tables;

namespace DoAn1.Services
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Position { get; set; } = string.Empty;
        public string DepartmentId { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class EmployeeService
    {
        private readonly AppDbContext db;

        public EmployeeService()
        {
            db = new AppDbContext();
        }

        public ProcessResult<List<EmployeeDTO>> GetAllEmployees(string keyword = "")
        {
            try
            {
                var query = db.Employees
                    .Include(e => e.Department)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    keyword = keyword.Trim().ToLower();
                    query = query.Where(e => e.Name.ToLower().Contains(keyword) ||
                                             e.Position.ToLower().Contains(keyword) ||
                                             (e.Department != null && e.Department.DepartmentName.ToLower().Contains(keyword)));
                }

                var employees = query.ToList();
                var accounts = db.Accounts.ToList();

                var list = employees.Select(e =>
                {
                    var acc = accounts.FirstOrDefault(a => a.EmployeeId == e.EmployeeId);
                    return new EmployeeDTO
                    {
                        EmployeeId = e.EmployeeId,
                        Name = e.Name,
                        Salary = e.Salary,
                        Position = e.Position,
                        DepartmentId = e.DepartmentId,
                        DepartmentName = e.Department?.DepartmentName ?? e.DepartmentId,
                        Username = acc?.Acc ?? string.Empty,
                        Password = acc?.Pass ?? string.Empty
                    };
                }).ToList();

                return new ProcessResult<List<EmployeeDTO>>
                {
                    IsSuccess = true,
                    Message = "Lấy danh sách nhân viên thành công.",
                    Data = list
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<EmployeeDTO>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<List<Department>> GetDepartments()
        {
            try
            {
                var list = db.Departments.ToList();
                return new ProcessResult<List<Department>>
                {
                    IsSuccess = true,
                    Message = "Lấy danh sách phòng ban thành công.",
                    Data = list
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<List<Department>>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<Employee> AddEmployee(Employee newEmp, string username, string password)
        {
            try
            {
                username = username.Trim();
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return new ProcessResult<Employee>
                    {
                        IsSuccess = false,
                        Message = "Tài khoản và mật khẩu không được để trống!"
                    };
                }

                bool accExist = db.Accounts.Any(a => a.Acc.ToLower() == username.ToLower());
                if (accExist)
                {
                    return new ProcessResult<Employee>
                    {
                        IsSuccess = false,
                        Message = "Tên tài khoản này đã được sử dụng!"
                    };
                }

                db.Employees.Add(newEmp);
                db.SaveChanges();

                var account = new Account
                {
                    Acc = username,
                    Pass = password,
                    EmployeeId = newEmp.EmployeeId
                };
                db.Accounts.Add(account);
                db.SaveChanges();

                return new ProcessResult<Employee>
                {
                    IsSuccess = true,
                    Message = "Thêm nhân viên và tạo tài khoản thành công!",
                    Data = newEmp
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Employee>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<Employee> UpdateEmployee(int employeeId, Employee updatedData, string username, string password)
        {
            try
            {
                var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
                if (emp == null)
                {
                    return new ProcessResult<Employee>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy nhân viên!"
                    };
                }

                username = username.Trim();
                bool accExist = db.Accounts.Any(a => a.Acc.ToLower() == username.ToLower() && a.EmployeeId != employeeId);
                if (accExist)
                {
                    return new ProcessResult<Employee>
                    {
                        IsSuccess = false,
                        Message = "Tên tài khoản này đã tồn tại ở nhân viên khác!"
                    };
                }

                emp.Name = updatedData.Name;
                emp.Salary = updatedData.Salary;
                emp.Position = updatedData.Position;
                emp.DepartmentId = updatedData.DepartmentId;

                var acc = db.Accounts.FirstOrDefault(a => a.EmployeeId == employeeId);
                if (acc != null)
                {
                    acc.Acc = username;
                    acc.Pass = password;
                }
                else if (!string.IsNullOrWhiteSpace(username))
                {
                    db.Accounts.Add(new Account
                    {
                        Acc = username,
                        Pass = password,
                        EmployeeId = employeeId
                    });
                }

                db.SaveChanges();

                return new ProcessResult<Employee>
                {
                    IsSuccess = true,
                    Message = "Cập nhật thông tin nhân viên thành công!",
                    Data = emp
                };
            }
            catch (Exception ex)
            {
                return new ProcessResult<Employee>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống: " + ex.Message
                };
            }
        }

        public ProcessResult<bool> DeleteEmployee(int employeeId)
        {
            try
            {
                var emp = db.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
                if (emp == null)
                {
                    return new ProcessResult<bool>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy nhân viên!"
                    };
                }

                bool hasCustomers = db.Customers.Any(c => c.EmployeeId == employeeId);
                if (hasCustomers)
                {
                    return new ProcessResult<bool>
                    {
                        IsSuccess = false,
                        Message = "Không thể xóa nhân viên này vì đang quản lý dữ liệu khách hàng!"
                    };
                }

                bool hasDeliveries = db.Deliveries.Any(d => d.EmployeeId == employeeId);
                if (hasDeliveries)
                {
                    return new ProcessResult<bool>
                    {
                        IsSuccess = false,
                        Message = "Không thể xóa nhân viên này vì có đơn giao hàng liên quan!"
                    };
                }

                var accounts = db.Accounts.Where(a => a.EmployeeId == employeeId).ToList();
                if (accounts.Any())
                {
                    db.Accounts.RemoveRange(accounts);
                }

                db.Employees.Remove(emp);
                db.SaveChanges();

                return new ProcessResult<bool>
                {
                    IsSuccess = true,
                    Message = "Đã xóa nhân viên thành công!",
                    Data = true
                };
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
