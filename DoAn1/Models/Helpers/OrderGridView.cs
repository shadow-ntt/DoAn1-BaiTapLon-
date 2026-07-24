using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn1.Models.Helpers
{
    public class OrderGridView
    {
            public int ProductId { get; set; } 

            public string ProductName { get; set; } = string.Empty;

            public decimal UnitPrice { get; set; }

            public int Quantity { get; set; }

            public decimal TotalPrice => UnitPrice * Quantity;
}
}
