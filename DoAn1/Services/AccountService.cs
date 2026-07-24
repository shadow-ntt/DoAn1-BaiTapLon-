using DoAn1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DoAn1.Models.Results;
using DoAn1.Data;
namespace DoAn1.Clonee.Services
{
    public class AccountService
    {
        private static AppDbContext db = new AppDbContext();
        public ProcessResult<Account> Login(string acc, string pass)
        {
            try
            {
                Account account = db.Accounts.Include(z => z.Employee).FirstOrDefault(z => z.Acc.Equals(acc) && z.Pass.Equals(pass));
                if (account == null)
                {
                    return new ProcessResult<Account>
                    {
                        IsSuccess = false,
                        Message = "Tài khoản hoặc mật khẩu không đúng.",
                    };
                }
                else
                {
                    return new ProcessResult<Account>
                    {
                        IsSuccess = true,
                        Message = "Đăng nhập thành công.",
                        Data = account
                    };
                }
            }
            catch (Exception ex) {
                return new ProcessResult<Account>
                {
                    IsSuccess = false,
                    Message = "Lỗi hệ thống!"
                };
            }
        }
    }
}
