using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class Team
    {
        public Guid OwnerId { get; set; }
        public int TeamId { get; set; }
        public virtual List<Player> Roster { get; set; }
        public string TeamName { get; set; }
        public decimal PointsPerGame { get; }
        public decimal AssistsPerGame { get; }
        public decimal ReboundsPerGame { get; }
        public decimal BlocksPerGame { get; }
        public decimal StealsPerGame { get; }

    }
}
