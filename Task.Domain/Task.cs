using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain
{
    public class Task
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
        public DateTime Due_Date { get; set; }
       
    }
}
