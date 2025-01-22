
using Microsoft.EntityFrameworkCore;
using UnionCore.DataAccess;

namespace UnionCore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database
            builder.Services.AddDbContextPool<DataContext>(opt =>
                opt.UseNpgsql(
                    "Host=postgre-db.noahnielsen.dk; Database=\"UnionCore\"; Username=DrawAndGuessCode2; Password=drawAndGuessCode2",
                    o => o
                        .SetPostgresVersion(13, 0)
                ));

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
