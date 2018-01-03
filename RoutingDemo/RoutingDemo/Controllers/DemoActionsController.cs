using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class DemoActionsController : Controller
    {
        // GET: DemoActions
        public string Dynamic()
        {
            string qualifier = RouteData.Values["qualifier"].ToString();
            return $"Oh my {qualifier}";
        }

        public string Clucks(string numberOfTimes)
        {
            return $"The Chicken Clucks {numberOfTimes} times";
        }

        public string CatchAll(string theRest)
        {
            return $"The rest {theRest}";
        }
    }
}