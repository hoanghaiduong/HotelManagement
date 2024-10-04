

using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class Hotel :BaseAuditEntity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Thumbnail { get; set; }
        public List<string>? Images { get; set; }
        public int Stars { get; set; } = 0;
        public DateTime? CheckInTime { get; set; } = DateTime.Now;
        public DateTime? CheckOutTime { get; set; } = DateTime.Now;
        [JsonIgnore]
        public virtual List<Room> Rooms { get; set; } = [];
        [JsonIgnore]
        public virtual List<User> Users{ get; set; } = [];
    }
}