using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutDemo2.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            if(HtmlHelper)
            {

            }
            return View();
        }

        public ActionResult MapList()
        {
            return View();
        }
    }
}