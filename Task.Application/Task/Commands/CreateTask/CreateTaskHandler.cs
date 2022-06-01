using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tasks.Domain;

using MediatR;
using Tasks.Application.Interfaces;

namespace Tasks.Application.Task.Commands.CreateTask
{
    public class CreateTaskHandler
        :IRequestHandler<CrateTaskCommand, Guid>
    {

        private readonly ITaskDbContext _dbContext;
        public CreateTaskHandler(ITaskDbContext dbContext) => _dbContext = dbContext;
        public async Task<Guid> Handle (CrateTaskCommand request,
            CancellationToken cansellationToken)
        {
            var task = new Tasks.Domain.Task
            {
                UserId = request.UserId,
                Title = request.Title,
                Description = request.Description,
                Id = Guid.NewGuid(),
                Created_Date = System.DateTime.Now,
                Modified_Date = System.DateTime.Now,
                Due_Date = request.Due_Date
            };

            await _dbContext.Tasks.AddAsync(task, cansellationToken);
            await _dbContext.SaveChangesAsync(cansellationToken);
            return task.Id;
        }
    }
}
