using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "CatchAll",
                url: "Chickens/{*theRest}",
                defaults: new { controller = "DemoActions", action = "CatchAll  ", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "PartialDynamicRoute",
                url: "Chickens/Cluck{numberofTimes}times",
                defaults: new { controller = "DemoActions", action = "Clucks", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DynamicRoute",
                url: "Students/Neumont/Wow/{qualifier}",
                defaults: new { controller = "DemoAction", action = "Dynamic", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "StaticRoute",
                url: "Students/Neumont/Wow",
                defaults: new { controller = "Home", action = "Static", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
