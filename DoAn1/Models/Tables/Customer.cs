using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoAn1.Models.Tables
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string IdentityNumber { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string TaxCode { get; set; } = string.Empty;

        [Required]
        public decimal CreditLimit { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // Navigation Property
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
