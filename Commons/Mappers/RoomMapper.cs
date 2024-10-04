

using HotelManagement.Commons.DTO;
using HotelManagement.Entities;

namespace HotelManagement.Commons.Mappers
{
    public static class RoomMapper
    {
        public static RoomDTO ToRoomDTO(this Room room){
            return new RoomDTO{
                Id = room.Id,
                HotelID=room.HotelID,
                RoomTypeID=room.RoomTypeID,
                Thumbnail=room.Thumbnail,
                Images = room.Images,
                Status = room.Status,
                RoomType = room.RoomType,
                Hotel=room.Hotel,
                Bookings = room.Bookings
            };
        }
    }
}