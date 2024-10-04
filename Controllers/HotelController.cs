
using HotelManagement.Commons.DTO;
using HotelManagement.Data;
using HotelManagement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IResult> CreateHotel([FromBody] CreateHotelDTO dto)
        {
            try
            {
                var newHotel = new Hotel
                {
                    Name = dto.Name,
                    Address = dto.Address,
                    Phone = dto.Phone,
                    Email = dto.Email,
                    Thumbnail = dto.Thumbnail,
                    Images = [],
                    Stars = dto.Stars,
                };
                var saved = await _context.Hotels.AddAsync(newHotel);
                await _context.SaveChangesAsync();
                return Results.Ok(new
                {
                    newHotel
                });
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}