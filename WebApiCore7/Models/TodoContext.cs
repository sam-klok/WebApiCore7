using Microsoft.EntityFrameworkCore;

namespace WebApiCore7.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<Picture> Picture { get; set; } = null!;
    }
}
