using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; } //NEW
        public DbSet<Item> Items { get; set; }
        public DbSet<CategoryItem> CategoryItem {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=root;port=3306;database=to_do_list;");

        public ToDoListContext(DbContextOptions options) : base(options)
        {

        }
        public ToDoListContext()
        {

        }

    }
}