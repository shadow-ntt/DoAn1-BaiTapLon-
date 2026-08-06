using System;
using System.Collections.Generic;
using System.Text;
using DoAn1.Models.Tables;
namespace DoAn1.Models.Helpers
{
    public class OrderDisplayItem
    {
        public Order OrderData { get; set; }
        public string DisplayText { get; set; }

        public override string ToString() => DisplayText;
    }
}
