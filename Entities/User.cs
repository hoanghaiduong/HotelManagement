using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class User : BaseAuditEntity<int>
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Avatar { get; set; }
        public DateTime? DateOfBirth { get; set; } = DateTime.Now;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public DateTime? HireDate { get; set; } = DateTime.Now;
        public decimal Salary { get; set; }
        [JsonIgnore]
        public virtual Hotel Hotel { get; set; } = null!;
        [JsonIgnore]
        public virtual List<UserRoles> UserRoles { get; set; } = [];
        [JsonIgnore]
        public virtual List<Booking> Bookings { get; set; } = [];
    }
}