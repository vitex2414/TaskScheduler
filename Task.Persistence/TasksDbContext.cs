using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tasks.Domain;
using Tasks.Persistence.EntityTypeConfigurations;
using Tasks.Application.Interfaces;


namespace Tasks.Persistence
{
    public class TasksDbContext : DbContext, ITaskDbContext
    {
        public DbSet<Tasks.Domain.Task> Tasks { get; set; }
   
        public TasksDbContext(DbContextOptions<TasksDbContext> options)
            : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TaskConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
