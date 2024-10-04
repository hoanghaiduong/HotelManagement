
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Commons.Extensions;
namespace HotelManagement;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<ApplicationDbContext>(ops=>ops.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        // Add services to the container.
        builder.Services.AddWebServices();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseSwaggers();
        app.Run();
    }
}
