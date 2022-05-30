using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task.Domain;
namespace Task.Persistence.EntityTypeConfigurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task.Domain.Task>
    {
       public void Configure(EntityTypeBuilder<Task.Domain.Task> builder)
        {
            builder.HasKey(task => task.Id);
            builder.HasIndex(task => task.Id).IsUnique();
            builder.Property(task => task.Title).HasMaxLength(250);
        }
    }
}
