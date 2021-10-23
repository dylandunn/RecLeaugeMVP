using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class PlayerCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Name must be more than 2 characters.")]
        [MaxLength(50, ErrorMessage ="Name is too long. Please keep name under 50 characters.")]
        public string Name { get; set; }
        [Required]
        public int TeamId { get; set; }
    }
}
