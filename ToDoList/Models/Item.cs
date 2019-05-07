using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("items")]
    public class Item
    {
        public string Description { get; set; }
        public int ItemId { get; set; }

    }
}