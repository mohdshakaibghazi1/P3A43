using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskWebApi.Models;

namespace TaskWebApi.Data
{
    public class TaskWebApiContext : DbContext
    {
        public TaskWebApiContext (DbContextOptions<TaskWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<TaskWebApi.Models.Task> Task { get; set; } = default!;
    }
}
