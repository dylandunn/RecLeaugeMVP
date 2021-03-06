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
        public Guid OwnerId { get; set; }
        [Key]
        public int GameLogId { get; set; }

        [Required]
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public DateTime DateOfGame { get; set; }
        public double Points { get; set; }
        public double Assists { get; set; }
        public double Rebounds { get; set; }
        public double Blocks { get; set; }
        public double Steals { get; set; }
    }
}
