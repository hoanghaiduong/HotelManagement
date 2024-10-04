using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Commons.DTO;
using HotelManagement.Commons.DTO.Create;
using HotelManagement.Commons.Mappers;
using HotelManagement.Data;
using HotelManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IResult> CreateRoom([FromBody] CreateRoomDTO dto)
        {
            try
            {
                var hotel = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == dto.HotelID);
                if (hotel == null)
                {
                    return Results.NotFound(new { Message = "Hotel Not Found" });
                }
                var roomType = await _context.RoomTypes.FirstOrDefaultAsync(x => x.Id == dto.RoomTypeID);
                if (roomType == null)
                {
                    return Results.NotFound(new { Message = "roomType Not Found" });
                }
                var newRoom = new Room
                {
                    HotelID = hotel.Id,
                    RoomTypeID = roomType.Id,
                    Thumbnail = dto.Thumbnail,
                    Images = dto.Images,
                    Status = dto.Status,
                    Hotel = hotel,
                    RoomType = roomType,
                };
                var saved = await _context.Rooms.AddAsync(newRoom);
                await _context.SaveChangesAsync();
                return Results.Ok(new
                {
                    newRoom
                });
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IResult> GetRoomAsync([FromQuery] int id)
        {
            try
            {
                var room = await _context.Rooms.Include(r => r.RoomType).Include(r => r.Hotel).Include(r => r.Bookings).FirstOrDefaultAsync(x => x.Id == id);

                if (room == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(new
                {
                    data = room.ToRoomDTO()
                });
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}