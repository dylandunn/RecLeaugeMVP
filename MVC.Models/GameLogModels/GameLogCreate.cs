using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Models.GameLogModels
{
    public class GameLogCreate
    {
        public int PlayerId { get; set; }
        public DateTime DateOfGame { get; set; }
        public double Points { get; set; }
        public double Assists { get; set; }
        public double Rebounds { get; set; }
        public double Blocks { get; set; }
        public double Steals { get; set; }
    }
}
