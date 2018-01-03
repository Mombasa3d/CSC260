using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingLab
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Homepage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "CowMooing",
                url: "{controller}/{action}/{i}",
                defaults: new { controller = "Home", action = "Mooing", i = UrlParameter.Optional}
            );
            routes.MapRoute(
                name: "AboutUs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "About Us", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Chik",
                url: "www.cows.com/EatMoreChicken",
                defaults: new { controller = "Home", action = "Chik", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "www.cows.com/{id}/Gallery",
                defaults: new { controller = "Home", action = "Gallery", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "www.cows.com/EatMoreChicken",
                defaults: new { controller = "Home", action = "Chik", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
