using Lesnichestvo.DAL.Entities;
using Lesnichestvo.DAL.Interfaces;
using Lesnichestvo.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Lesnichestvo.DAL.DI
{
    public static class InjectorDAL
    {
        public static IServiceCollection AddDataAccessLevel(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlServer");

            services.AddDbContext<MainContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.InitRepositories();

            return services;
        }

        private static void InitRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Dacha>, BaseRepository<Dacha>>();
            services.AddScoped<IBaseRepository<Inspection>, BaseRepository<Inspection>>();
            services.AddScoped<IBaseRepository<Item>, BaseRepository<Item>>();
            services.AddScoped<IBaseRepository<Mapping>, BaseRepository<Mapping>>();
            services.AddScoped<IBaseRepository<Qualification>, BaseRepository<Qualification>>();
            services.AddScoped<IBaseRepository<QuartalNetwork>, BaseRepository<QuartalNetwork>>();
            services.AddScoped<IBaseRepository<Report>, BaseRepository<Report>>();
            services.AddScoped<IBaseRepository<SoldWood>, BaseRepository<SoldWood>>();
            services.AddScoped<IBaseRepository<UnsoldWood>, BaseRepository<UnsoldWood>>();
            services.AddScoped<IBaseRepository<WoodType>, BaseRepository<WoodType>>();
            services.AddScoped<IBaseRepository<Work>, BaseRepository<Work>>();
            services.AddScoped<IBaseRepository<Worker>, BaseRepository<Worker>>();
            services.AddScoped<IBaseRepository<WorkHasInventory>, BaseRepository<WorkHasInventory>>();
            services.AddScoped<IBaseRepository<WorkHasWorkers>, BaseRepository<WorkHasWorkers>>();
            services.AddScoped<IBaseRepository<WorkType>, BaseRepository<WorkType>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IProcedureRepository, ProcedureRepository>();
        }
    }
}
