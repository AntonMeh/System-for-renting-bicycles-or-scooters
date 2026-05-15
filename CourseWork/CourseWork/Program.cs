
using CourseWork.Data;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    npgsql => npgsql.UseNetTopologySuite()));

            builder.Services.AddScoped<RentalService>();

            builder.Services.AddControllers();
            builder.Services.AddRazorPages();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthorization();

            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
