
namespace Tasks.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(TasksDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
