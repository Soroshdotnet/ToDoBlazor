using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBlazor.Shared.Entities
{
    public class CreateItem
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Text { get; set; } = string.Empty;
    }
}
