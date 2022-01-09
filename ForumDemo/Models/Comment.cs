using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumDemo.Models
{
    public class Comment
    {
        public  Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Content { get; set; }
    }
}
