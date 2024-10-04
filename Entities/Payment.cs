
using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class Payment : BaseAuditEntity<int>
    {
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public string PaymentMethod { get; set; }
        [JsonIgnore]
        public virtual Booking Booking { get; set; } =null!;
    }
}