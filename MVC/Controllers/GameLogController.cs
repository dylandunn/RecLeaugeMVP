using Microsoft.AspNet.Identity;
using MVC.Data;
using MVC.Models.GameLogModels;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class GameLogController : Controller
    {
        // GET: GameLog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameLogCreate model, int playerId, Player player)
        {
            if (!ModelState.IsValid) return View(model);


            var service = CreateGameService();

            if (service.CreateGameLog(model, playerId, player))
            {
                TempData["SaveResult"] = "GameLog was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "GameLog could not be created.");
            return View(model);
        }
        private GameLogService CreateGameService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new GameLogService(userId);
            return service;
        }
    }
}