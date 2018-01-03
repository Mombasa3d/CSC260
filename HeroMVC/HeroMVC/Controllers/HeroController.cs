using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroMVC.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero

        public ActionResult Heroes()
        {
            return View();
        }
    }
}