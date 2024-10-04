
namespace HotelManagement.Commons.Extensions
{
    public static class UseSwagger
    {
        public static WebApplication UseSwaggers(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}