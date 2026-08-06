using System;
using System.Linq;
using DoAn1.Data;
using DoAn1.Models.Tables;

namespace DoAn1.Utils
{
    public class DepartmentSeeder
    {
        public static void SeedDepartment(string departmentName)
        {
            using (var db = new AppDbContext())
            {
                var existing = db.Departments.FirstOrDefault(d => d.DepartmentName == departmentName);
                if (existing != null)
                {
                    Console.WriteLine($"Phòng ban '{departmentName}' đã tồn tại trong CSDL với mã: {existing.DepartmentId}");
                    return;
                }

                int maxNum = 0;
                var allDeptIds = db.Departments.Select(d => d.DepartmentId).ToList();
                foreach (var id in allDeptIds)
                {
                    if (!string.IsNullOrEmpty(id) && id.StartsWith("PB") && int.TryParse(id.Substring(2), out int n))
                    {
                        if (n > maxNum) maxNum = n;
                    }
                }
                string newDeptId = $"PB{(maxNum + 1):D2}";

                var newDept = new Department
                {
                    DepartmentId = newDeptId,
                    DepartmentName = departmentName
                };

                db.Departments.Add(newDept);
                db.SaveChanges();
                Console.WriteLine($"Đã thêm mới phòng ban thành công: Mã = [{newDeptId}], Tên = [{departmentName}]");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("=== BẮT ĐẦU SEED DỮ LIỆU BẢNG DEPARTMENT ===");
            SeedDepartment("Quản lý");
            Console.WriteLine("=== HOÀN TẤT SEED DỮ LIỆU ===");
        }
    }
}
