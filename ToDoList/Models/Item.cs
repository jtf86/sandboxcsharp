using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("items")]
    public class Item
    {
        public Item()
        {
            this.Categories = new List<CategoryItem>();
        }

        [Key]
        public int ItemId { get; set; }
        public string Description { get; set; }

        public ICollection<CategoryItem> Categories { get;}

    }
}