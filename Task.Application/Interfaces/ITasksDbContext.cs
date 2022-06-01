using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Tasks.Domain;



namespace Tasks.Application.Interfaces
{
    
     public interface ITaskDbContext
        {
            DbSet<Tasks.Domain.Task> Tasks { get; set; }
            
            Task<int> SaveChangesAsync(CancellationToken cancellationToken);
           
    }

    }

