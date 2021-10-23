using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class GameLog
    {
        [Key]
        public int GameLogId { get; set; }

        [Required]
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public DateTime DateOfGame { get; set; }
        public int? Points { get; set; }
        public int? Assists { get; set; }
        public int? Rebounds { get; set; }
        public int? Blocks { get; set; }
        public int? Steals { get; set; }
    }
}
