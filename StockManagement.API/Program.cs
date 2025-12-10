using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManagement.DAL;
using StockManagement.DAL.Entities;
using System.Threading.Tasks;

namespace StockManagement.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var keepAliveConnection = new SqliteConnection("Data Source=:memory:;Cache=Shared");
            keepAliveConnection.Open();

            
            builder.Services.AddDbContext<StockDbContext>(options =>
            {
                options.UseSqlite(keepAliveConnection);
            });
            builder.Services.AddTransient<DataSeeder>();


            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            //Data seeding
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<StockDbContext>();

                db.Database.EnsureCreated();

                var dataSeeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
                await dataSeeder.SeedDataAsync();
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
