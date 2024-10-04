

using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class RoomType : BaseAuditEntity<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public decimal? PricePerNight { get; set; }
        public int Capacity { get; set; }
        [JsonIgnore]
        public virtual List<Room> Rooms { get; set; } = [];
    }
}