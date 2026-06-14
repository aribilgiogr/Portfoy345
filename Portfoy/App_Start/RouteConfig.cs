using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Portfoy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Özel rota şablonları: Statik rotalar veya değişkenlere bağlı yarı statik rotalar ekleyebilirsiniz.

            // Tam statik rotalar: Belirli bir URL'ye doğrudan yönlendirme yapar.

            // '/about' URL'si HomeController'ın About action'ına yönlendirilir.
            routes.MapRoute("About", "about", new { controller = "Home", action = "About" });

            // '/contact' URL'si HomeController'ın Contact action'ına yönlendirilir.
            routes.MapRoute("Contact", "contact", new { controller = "Home", action = "Contact" });

            // Yarı statik rotalar: Belirli bir yapıya sahip URL'leri yakalayarak yönlendirme yapar.
            routes.MapRoute(
                name: "Blog categories",
                url: "blog/category/{category_name}",
                defaults: new { controller = "Blog", action = "Category" }
            );

            routes.MapRoute(
                name: "Blog tags",
                url: "blog/tag/{tag_name}",
                defaults: new { controller = "Blog", action = "Tag" }
            );


            // Varsayılan rota şablonu: {controller}/{action}/{id}
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
