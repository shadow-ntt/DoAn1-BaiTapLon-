using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DoAn1.Models.Tables
{

    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;
    }
}
