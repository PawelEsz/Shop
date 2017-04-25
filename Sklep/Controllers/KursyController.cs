using Sklep.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class KursyController : Controller
    {
        private KursyContext db = new KursyContext();

        // GET: Kursy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista(string nazwaKategorii, string searchQuery = null)
        {
            var kategoria = db.Kategorie.Include("Kursy").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategorii.ToUpper()).Single();
            var kursy = kategoria.Kursy.Where(a => (searchQuery == null) ||
                                                a.TytulKursu.ToLower().Contains(searchQuery.ToLower()) ||
                                                a.AutorKursu.ToLower().Contains(searchQuery.ToLower()) &&
                                                !a.Ukryty);

            if(Request.IsAjaxRequest())
            {
                return PartialView("_KursyList", kursy);
            }
            //var kursy = kategoria.Kursy.ToList();
            return View(kursy);
        }

        public ActionResult Szczegoly(int id)
        {
            var kurs = db.Kursy.Find(id);
            return View(kurs);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60000)]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }

        public ActionResult KursyPodpowiedzi(string term)
        {
            var kursy = this.db.Kursy.Where(a => !a.Ukryty && a.TytulKursu.ToLower().Contains(term.ToLower())).Take(5).Select(a => new { label = a.TytulKursu });

            return Json(kursy, JsonRequestBehavior.AllowGet);
        }
    }
}