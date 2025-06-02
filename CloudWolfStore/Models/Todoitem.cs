using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudWolfStore.Models
{
     // Models/TodoItem.cs
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public  string Name { get; set; }

        [DisplayName("Item Stored")]
        public bool  TableReady { get; set; } = false;
        public string? Description { get; set; }
    }
}