using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vinarija
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

            routes.MapRoute(
              name: "ProizvoditelImeRoute",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Proizvoditeli", action = "ProizvoditelAction", id ='1' }
          );
            routes.MapRoute(
              name: "SostojkiRoute",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Sostojki", action = "Index", id = '2' }
          );
        }
    }
}
