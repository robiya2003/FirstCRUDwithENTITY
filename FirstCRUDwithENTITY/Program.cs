
using FirstCRUDwithENTITY.Infastructures;
using FirstCRUDwithENTITY.PhoneServise;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FirstCRUDwithENTITY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IPhoneServise, PhoneServise1>();
            builder.Services.AddDbContext<ApplicationDbContext>(
                Options => Options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
            ) ;







            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
