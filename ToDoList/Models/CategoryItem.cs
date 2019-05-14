using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class CategoryItem
    {       
        [Key]
        public int CategoryItemId { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public Category Category { get; set; } 
    }
}