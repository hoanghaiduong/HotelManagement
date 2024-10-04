
using HotelManagement.Commons.DTO;
using HotelManagement.Data;
using HotelManagement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RoomTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IResult> CreateRoomType([FromBody] CreateRoomTypeDTO dto)
        {
            try
            {
                var newRoomType = new RoomType
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    PricePerNight = dto.PricePerNight,
                    Capacity = dto.Capacity,
                };
                var saved = await _context.RoomTypes.AddAsync(newRoomType);
                await _context.SaveChangesAsync();
                return Results.Ok(new {
                    newRoomType
                });
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}