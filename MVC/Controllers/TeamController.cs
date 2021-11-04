using Microsoft.AspNet.Identity;
using MVC.Models.TeamModels;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    [Authorize]
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TeamService(userId);
            var model = service.GetTeams();

            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TeamService(userId);

            service.CreateTeam(model);

            return RedirectToAction("Index");
        }
    }
}