using Microsoft.EntityFrameworkCore;
using server.Repositories;
using server.Repositories.Interfaces;
using server.Repositories.Persistence;

namespace server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=EmpDB")
            );

            var app = builder.Build();

            app.UseRouting();
            app.MapControllers();

            app.Run();
        }
    }
}
