using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Entities
{
    public abstract class BaseAuditEntity<Tkey>
    {
        [Key]
        public Tkey Id { get; set;}
        public DateTime CreatedAt { get; set;} =DateTime.Now;
        public DateTime UpdatedAt { get; set;} =DateTime.Now;
    }
}