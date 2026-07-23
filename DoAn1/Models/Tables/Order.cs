using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DoAn1.Models.Tables
{

    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime? ReviewedDate {  get; set; }
        public string ?CancelReason {  get; set; }
        [Required]
        public DateTime ExpectedDeliveryDate { get; set; }

        [Required]
        public string Status { get; set; } = "Created";

        // Foreign Key
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }


        // Navigation Properties
        public Customer Customer { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public Invoice? Invoice { get; set; }

        public  Delivery? Delivery { get; set; }
    }
}
