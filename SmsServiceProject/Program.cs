using Microsoft.EntityFrameworkCore;
using SmsServiceProject.Business.Contracts;
using SmsServiceProject.Business.Services;
using SmsServiceProject.Business.Vendors;
using SmsServiceProject.Data.Repositories;
using SmsServiceProject.Domain;

namespace SmsServiceProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<SmsMessageDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ISmsService, SmsService>();

            builder.Services.AddScoped<ISmsRepository, SmsRepository>();

            builder.Services.AddScoped<GreekVendorStrategy>();
            builder.Services.AddScoped<CypriotVendorStrategy>();
            builder.Services.AddScoped<RestOfWorldVendorStrategy>();
            builder.Services.AddScoped<VendorStrategyFactory>();

            builder.Services.AddControllers();
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