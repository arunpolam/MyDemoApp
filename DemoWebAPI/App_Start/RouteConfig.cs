using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoWebAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //Add new route to map API results.
            routes.MapRoute(
               name: "Demo",
               url: "{controller}/{action}",
               defaults: new { controller = "DemoAPI", action = "HelloWorld"}
           );
            //Add new route to map API results.
            routes.MapRoute(
               name: "DemowithInterface",
               url: "{controller}/{action}",
               defaults: new { controller = "DemoAPI", action = "GetResults" }
           );
        }
    }
}
