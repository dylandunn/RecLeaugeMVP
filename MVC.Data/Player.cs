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
        public Guid OwnerId { get; set; }
        [Key]
        public int PlayerId { get; set; }
        [Required]
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string Name { get; set; }
        public List<double> PointsPerGame { get; set; }
        public double AssistsPerGame { get; set; }
        public double ReboundsPerGame { get; set; }
        public double BlocksPerGame { get; set; }
        public double StealsPerGame { get; set; }
        public int GamesPlayed { get; set; }
    }
}
