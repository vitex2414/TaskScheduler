using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Task.Domain;



namespace Tasks.Application.Interfaces
{
    
     public interface ITaskDbContext
        {
            DbSet<Task.Domain.Task> Tasks { get; set; }
            
            Task<int> SaveChangesAsync(CancellationToken cancellationToken);
           
    }

    }

