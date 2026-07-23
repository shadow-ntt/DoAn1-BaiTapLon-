using DoAn1.Models.Tables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DoAn1.Models.Tables
{
    public class Delivery
    {
        [Key]
        public int DeliveryId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime AssignedDate { get; set; }

        public DateTime? DeliveredDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [StringLength(500)]
        public string? ReturnReason { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;

        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; } = null!;
    }
}