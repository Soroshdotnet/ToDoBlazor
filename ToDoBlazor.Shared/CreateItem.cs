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
        [StringLength(100, MinimumLength = 1)]
        public string Text { get; set; } = string.Empty;
    }
}
