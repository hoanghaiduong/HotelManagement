

using HotelManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Data.configs
{
    public class BookingConfigurations : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            // builder
            // .HasOne(b => b.User)
            // .WithMany(u => u.Bookings)
            // .HasForeignKey(b => b.UserId)
            // .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete for this relationship
        }
    }
}