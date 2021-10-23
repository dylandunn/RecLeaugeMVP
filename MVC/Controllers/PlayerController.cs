using MVC.Models;
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
            var model = new PlayerListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}