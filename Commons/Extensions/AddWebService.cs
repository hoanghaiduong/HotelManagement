

namespace HotelManagement.Commons.Extensions
{
    public static class AddWebService
    {
        public static IServiceCollection AddWebServices(this IServiceCollection service)
        {

//ADD AUTHENTICATION

            service.AddAuthorization();
            service.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            // ADD SWAGGER EXPLORE
            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();

            return service;
        }
    }
}