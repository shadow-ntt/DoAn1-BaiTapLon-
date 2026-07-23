using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace DoAn1.Models.Tables
{ 
    public class OrderDetail
    {
        // Composite Key sẽ cấu hình bằng Fluent API

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        // Navigation Properties
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
