using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tasks.Application.Task.Commands.CreateTask
{
    public class CrateTaskCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Due_Date { get; set; }
    }
}
