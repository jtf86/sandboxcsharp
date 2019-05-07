using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=epicodus;");

        public ToDoListContext(DbContextOptions options) : base(options)
        {

        }
        public ToDoListContext()
        {

        }
    }
}