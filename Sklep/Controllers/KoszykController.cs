using Sklep.DAL;
using Sklep.Infrastructure;
using Sklep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class KoszykController : Controller
    {
        private KoszykMenager koszykMenager;
        private ISessionMenager sessionMenager { get; set; }
        private KursyContext db;

        public KoszykController()
        {
            db = new KursyContext();
            sessionMenager = new SessionMenager();
            koszykMenager = new KoszykMenager(sessionMenager, db);
        }

        // GET: Koszyk
        public ActionResult Index()
        {
            var pozycjeKoszyka = koszykMenager.PobierzKoszyk();
            var cenaCalkowita = koszykMenager.PobierzWartoscKoszyka();

            KoszykViewModel koszykVM = new KoszykViewModel()
            {
                PozycjeKoszyka = pozycjeKoszyka,
                CenaCalkowita = cenaCalkowita
            };
            return View(koszykVM);
        }

        public ActionResult DodajDoKoszyka(int id)
        {
            koszykMenager.DodajDoKoszyka(id);

            return RedirectToAction("Index");
        }

        public int PobierzIloscElementowKoszyka()
        {
            return koszykMenager.PobierzIloscPozycjiKoszyka();
            
        }

        public ActionResult UsunZKoszyka(int kursId2)
        {
            int iloscPozycji = koszykMenager.UsunZKoszyka(kursId2);
            int iloscPozycjiKoszyka = koszykMenager.PobierzIloscPozycjiKoszyka();
            decimal wartoscKoszyka = koszykMenager.PobierzWartoscKoszyka();

            var wynik = new KoszykUsuwanieViewModel()
            {
                IdPozycjiUsuwanej = kursId2,
                IloscPozycjiUsuwanej = iloscPozycji,
                KoszykCenaCalkowita = wartoscKoszyka,
                KoszykIloscPozycji = iloscPozycjiKoszyka
            };

            return Json(wynik);
        }
    }
}