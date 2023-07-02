
using Microsoft.EntityFrameworkCore;
using TaskSistem_API.Models;

namespace TaskSistem_API.Data
     

{
    public class TaskSystemDBContext : DbContext
    {
        public TaskSystemDBContext(DbContextOptions<TaskSystemDBContext> options )
        :base(options)
        { 
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
