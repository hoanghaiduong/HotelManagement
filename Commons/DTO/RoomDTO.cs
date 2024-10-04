

using HotelManagement.Entities;

namespace HotelManagement.Commons.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int HotelID { get; set; }
        public int RoomTypeID { get; set; }
        public string? Thumbnail { get; set; }
        public List<string>? Images { get; set; }
        public string? Status { get; set; }

        public virtual RoomType RoomType { get; set; } = null!;

        public virtual Hotel Hotel { get; set; } = null!;

        public virtual List<Booking> Bookings { get; set; } = [];
    }
}