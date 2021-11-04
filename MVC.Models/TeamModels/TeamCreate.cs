using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models.TeamModels
{
    public class TeamCreate
    {
        [Required]
        [MinLength(4, ErrorMessage = "Team name must be more than 5 characters")]
        [MaxLength(50, ErrorMessage ="Team name is too long")]
        public string TeamName { get; set; }
    }
}
