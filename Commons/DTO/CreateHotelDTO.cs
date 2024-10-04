

namespace HotelManagement.Commons.DTO
{
    public class CreateHotelDTO
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
    }
}