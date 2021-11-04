using MVC.Data;
using MVC.Models.GameLogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class GameLogService
    {
        private readonly Guid _userId;

        public GameLogService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateGameLog(GameLogCreate model, int playerId, Player player)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var points = player.PointsPerGame;
                ctx.Players.SingleOrDefault(g => g.PlayerId == playerId);
                var entity =
                new GameLog()
                {
                    PlayerId = model.PlayerId,
                  //  DateOfGame = model.DateOfGame,
                  //  Points = model.Points,
                   // Assists = model.Assists,
                   // Rebounds = model.Rebounds,
                    // Blocks = model.Blocks,
                    // Steals = model.Steals
  
                };
                points.Add(model.Points);
                ctx.GameLogs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
