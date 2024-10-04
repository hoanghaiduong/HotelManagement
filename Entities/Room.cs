

using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class Room : BaseAuditEntity<int>
    {
        public int HotelID { get; set; }
        public int RoomTypeID { get; set; }
        public string? Thumbnail { get; set; }
        public List<string>? Images { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public virtual RoomType RoomType { get; set; } = null!;
        [JsonIgnore]
        public virtual Hotel Hotel { get; set; } = null!;
        [JsonIgnore]
        public virtual List<Booking> Bookings{ get; set; }=[];
    }
}