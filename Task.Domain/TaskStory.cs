using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain
{
    public class TaskStory
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string OperationType { get; set; }  
        public DateTime History_Date { get; set; }
      
    }
}
