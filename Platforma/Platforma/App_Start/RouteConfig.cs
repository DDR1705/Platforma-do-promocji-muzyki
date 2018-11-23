using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Platforma
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
     
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // Aktywacja mechanizmu routingu na bazie atrybutów. Od teraz reguły można umieszczać bezpośrednio w kontrolerach.

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
