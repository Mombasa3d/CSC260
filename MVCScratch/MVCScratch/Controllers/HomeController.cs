using MVCScratch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Hero()
        {
            HeroModel model = new HeroModel();
            model.HeroName = "Hanzo";
            model.HeroType = "Offense";

            return View(model);
        }

        [HttpGet]
        public ActionResult AddNewHero()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewHero(HeroModel model)
        {
            return RedirectToAction("Hero", "Name");
        }
    }
}