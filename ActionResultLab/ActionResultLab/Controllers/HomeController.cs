using ActionResultLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Character c)
        {
            return View(c);
        }


        public ActionResult _CharToString(Character c)
        {
            return Content(c.ToString());
        }

        public ActionResult _CharToXML(Character c)
        {
            return View("~/Views/Home/_CharToXML.cshtml", c);
        }

        public ActionResult _CharToJSON(Character c)
        {
            return View("~/Views/Home/_CharToJSOn.cshtml", c);
        }

        public ActionResult FourOhFour()
        {
            return View("~/Views/Home/FourOhFour.cshtml");
        }

        public ActionResult Download()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Resources/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "botw1-1.jpg");
            string fileName = "botw1-1.jpg";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }

}