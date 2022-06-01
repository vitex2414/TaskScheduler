using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks.Domain;
namespace Tasks.Persistence.EntityTypeConfigurations
{
    public class TaskStoryConfiguration : IEntityTypeConfiguration<TaskStory>
    {
       public void Configure(EntityTypeBuilder<TaskStory> builder)
        {
            builder.HasKey(taskstory => taskstory.Id);
            builder.HasIndex(taskstory => taskstory.Id).IsUnique();
            builder.Property(taskstory => taskstory.OperationType).HasMaxLength(250);
        }
    }
}
