
using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class UserRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; } = null!;
        [JsonIgnore]
        public virtual Role Role { get; set; } = null!;
    }
}