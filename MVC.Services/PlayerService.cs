using MVC.Data;
using MVC.Models;
using MVC.Models.GameLogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class PlayerService
    {
        private readonly Guid _userId;

        public PlayerService(Guid userId)
        {
            _userId = userId;
        }
        
        public bool CreatePlayer(PlayerCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                
                var gameLog = new GameLogCreate();
                var entity =
            new Player()
            {
                Name = model.Name,
                TeamId = model.TeamId,
            }; 

            
                ctx.Players.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PlayerListItem> GetPlayers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var querey =
                    ctx
                        .Players
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                        e =>
                            new PlayerListItem
                            {
                                PlayerId = e.PlayerId,
                                TeamId = e.TeamId,
                                Name = e.Name
                            }
                           );
                return querey.ToArray();
            }
        }
      //  public PlayerService AddGameLogStatsToPlayer(Player playerCreate, GameLog gameLog)
       // {
         //   List<double> stats = playerCreate.PointsPerGame;
          //  stats.Add(gameLog.Points);
       // }
    }
}
