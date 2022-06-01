using MediatR;
using System;

namespace Tasks.Application.Task.Queries
{
    public class GetTaskQuery: IRequest<TaskListVm>
    {
        public Guid UserId { get; set; }
    }
}
