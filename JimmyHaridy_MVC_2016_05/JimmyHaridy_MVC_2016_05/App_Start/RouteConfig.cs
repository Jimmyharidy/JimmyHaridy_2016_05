using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JimmyHaridy_MVC_2016_05
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "hexa",
                url: "controller/{action}/{id}",
                defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "octa",
               url: "controller/{action}/{id}",
               defaults: new { controller = "Sprite", action = "Octa", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Store", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
