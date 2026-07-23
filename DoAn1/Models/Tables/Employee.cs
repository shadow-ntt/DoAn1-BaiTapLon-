using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace DoAn1.Models.Tables
{

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Position { get; set; } = string.Empty;
        [Required]
        public string DepartmentId { get; set; } 

        public Department Department { get; set; } = null!;

        public  ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    }
}
