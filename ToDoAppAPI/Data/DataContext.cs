using Microsoft.EntityFrameworkCore;
using ToDoAppAPI.Models;

namespace ToDoAppAPI.Data
{
    public class DataContext : DbContext
    { 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        }

        // It was needed to tup the whole path becouse it was 
        // mistaking with the System.Threading.Tasks.Task class.
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
