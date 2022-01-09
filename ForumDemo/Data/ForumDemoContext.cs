using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ForumDemo.Models;

namespace ForumDemo.Data
{
    public class ForumDemoContext : DbContext
    {
        public ForumDemoContext (DbContextOptions<ForumDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comment { get; set; }
    }
}
