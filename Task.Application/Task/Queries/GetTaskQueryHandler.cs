
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Tasks.Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Tasks.Application.Task.Queries
{
    public class GetTaskQueryHandler : 
        IRequestHandler<GetTaskQuery, TaskListVm>
    {
        private readonly ITaskDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetTaskQueryHandler(ITaskDbContext dbContext,
            IMapper mapper) =>
             (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<TaskListVm> Handle(GetTaskQuery request, CancellationToken cansellationToken)
        {
            var taskQuery = await _dbContext.Tasks
                .Where(node => node.UserId == request.UserId)
                .ProjectTo<TaskLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cansellationToken);
            return new TaskListVm { Tasks = taskQuery };
        }
    }
}
