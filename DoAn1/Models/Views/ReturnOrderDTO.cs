using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn1.Models.Views
{
    public class ReturnOrderDTO
    {
        public int OrderId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string ReturnReason { get; set; }
    }
}