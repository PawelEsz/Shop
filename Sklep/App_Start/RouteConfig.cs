using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sklep
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "KursySzczegoly", //nazwa naszej trasy
                url: "kurs-{id}.html", //adres url
                defaults: new { controller = "Kursy", action = "Szczegoly" } //ta trasa odwołuje się do kontrolera Home i metody StronyStatyczne. Bedziemy tu przekazywali parametr 'nazwa'
            );

            routes.MapRoute(
                name: "KursyList", //nazwa naszej trasy
                url: "Kategoria/{nazwaKategorii}", //adres url
                defaults: new { controller = "Kursy", action = "Lista" } //ta trasa odwołuje się do kontrolera Home i metody StronyStatyczne. Bedziemy tu przekazywali parametr 'nazwa'
            );

            routes.MapRoute(
                name: "StronyStatyczne", //nazwa naszej trasy
                url: "strony/{nazwa}.html", //adres url
                defaults: new { controller = "Home", action = "StronyStatyczne" } //ta trasa odwołuje się do kontrolera Home i metody StronyStatyczne. Bedziemy tu przekazywali parametr 'nazwa'
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
