
using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class Booking :BaseAuditEntity<int>
    {
        public int UserId { get; set; }
        public int RoomID { get; set; }
        public string? RoomNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? CheckInDate { get; set; }=DateTime.Now;
        public DateTime? CheckOutDate { get; set; }=DateTime.Now;
        [JsonIgnore]
        public virtual User User { get; set; } = null!;
        [JsonIgnore]
        public virtual Room Room{ get; set; } =null!;
        [JsonIgnore]
        public virtual List<Payment> Payments{ get; set; }=[];
    }
}