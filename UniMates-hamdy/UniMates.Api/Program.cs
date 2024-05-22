
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UniMates.Domain;
using UniMates.Infrastructure.Contracts.IRepositories;
using UniMates.Infrastructure.Mapper;
using UniMates.Infrastructure.Repositories;

namespace UniMates.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IComplaintReposaitory, CompliantReposatory>();
            builder.Services.AddTransient<IReviewReposaitory,ReviewReposaitory>(); 
            builder.Services.AddTransient<ISubjectReposaitory,SubjectReposaitory>();
            builder.Services.AddTransient<ISessionReposaitory,SessionReposaitory>();
            builder.Services.AddTransient<ITutorSubjectReposaitory,TutorSubjectRepoSaitory>();



            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(
           options =>
           {
               options.UseSqlServer(builder.Configuration.GetConnectionString("db"));
           }
           );
            // autoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
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
