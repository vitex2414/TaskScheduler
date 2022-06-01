
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tasks.Application.Interfaces;

namespace Tasks.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["Host = localhost; Database = TaskSh; Username = postgres; Password = 123"];
           
            services.AddDbContext<TasksDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });


            services.AddScoped<ITaskDbContext>(provider =>
                provider.GetService<TasksDbContext>());
            return services;
        }

    }
}
