using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn1.Models.Views
{
    public class RevenueReportDTO
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string TaxCode { get; set; } = string.Empty;
        public DateTime PaidDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
