using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("categories")]
    public class Category
    {

        public Category()
        {
            this.Items = new List<CategoryItem>();
        }
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryItem> Items {get; set;}
    }
}