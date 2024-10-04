

using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Commons.DTO.Create
{
    public record CreateRoomDTO
    {
        [Required]
        public int HotelID { get; set; }
        [Required]
        public int RoomTypeID { get; set; }
        public string? Thumbnail { get; set; }
        public List<string>? Images { get; set; }
        public string? Status { get; set; }
    }
}