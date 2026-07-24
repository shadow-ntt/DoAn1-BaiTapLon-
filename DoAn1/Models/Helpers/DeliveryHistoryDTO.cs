using System;
using System.Collections.Generic;
using System.Text;
using DoAn1.Models.Tables;
namespace DoAn1.Models.Helpers
{
    public class DeliveryHistoryDTO
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string StatusText { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ReturnReason { get; set; }
        public Order OrderObj { get; set; } // Lưu gốc đối tượng Order để UI dùng
    }

    public static class OrderStatusHelper
    {
        public static string GetText(string status)
        {
            return status switch
            {
                "Created"=>"Đã được tạo",
                "ReadyDelivery" => "Chờ giao",
                "Delivering" => "Đang giao",
                "Completed" => "Giao thành công",
                "Rejected"=>"Đã bị từ chối",
                "Returning" => "Yêu cầu trả hàng (Chờ kho duyệt)",
                "Returned" => "Đã nhập kho trả",
                _ => status ?? "Chưa xác định"
            };
        }
    }
}
