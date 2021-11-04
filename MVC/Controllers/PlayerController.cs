using Microsoft.AspNet.Identity;
using MVC.Models;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlayerService(userId);
            var model = service.GetPlayers();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerCreate model)
        {
            if (!ModelState.IsValid) return View(model);
            

            var service = CreatePlayerService();

            if(service.CreatePlayer(model))
            {
                TempData["SaveResult"] = "Player was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Player could not be created.");
            return View(model);
        }

        private PlayerService CreatePlayerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlayerService(userId);
            return service;
        }
    }
}