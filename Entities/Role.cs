

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelManagement.Entities
{
    public class Role : BaseAuditEntity<int>
    {

        public string Name { get; set; }
        public string? Description { get; set; } = null!;
        [JsonIgnore]
        public virtual List<UserRoles> UserRoles { get; set; } = [];
    }
}