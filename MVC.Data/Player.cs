using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string Name { get; set; }
        public decimal PointsPerGame { get; }
        public decimal AssistsPerGame { get; set; }
        public decimal ReboundsPerGame { get; set; }
        public decimal BlocksPerGame { get; set; }
        public decimal StealsPerGame { get; set; }
        public int GamesPlayed { get; set; }
    }
}
