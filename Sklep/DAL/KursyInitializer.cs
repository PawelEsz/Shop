using Sklep.Migrations;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Sklep.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext, Configuration>
    {
        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() {KategoriaId = 1, NazwaKategorii ="Asp.net", NazwaPlikuIkony="aspnet.png", OpisKategorii = "opis asp net mvc",},
                new Kategoria() {KategoriaId = 2, NazwaKategorii ="JavaScript", NazwaPlikuIkony="javascript.png", OpisKategorii = "opis javascript" },
                new Kategoria() {KategoriaId = 3, NazwaKategorii ="jQuery", NazwaPlikuIkony="jquery.png", OpisKategorii = "opis jQuery" },
                new Kategoria() {KategoriaId = 4, NazwaKategorii ="Html5", NazwaPlikuIkony="html.png", OpisKategorii = "opis html" },
                new Kategoria() {KategoriaId = 5, NazwaKategorii ="Css3", NazwaPlikuIkony="css.png", OpisKategorii = "opis css" },
                new Kategoria() {KategoriaId = 6, NazwaKategorii ="Xml", NazwaPlikuIkony="xml.png", OpisKategorii = "opis xhtml" },
                new Kategoria() {KategoriaId = 7, NazwaKategorii ="C#", NazwaPlikuIkony="csharp.png", OpisKategorii = "opis c#" }
            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs() {KursId = 1, KategoriaId = 1, TytulKursu = "Asp.Net", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekaspnet.png", OpisKursu = "opis...",
                CenaKursu = 0, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 2, KategoriaId = 1, TytulKursu = "Asp.Net Mvc", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekmvc.png", OpisKursu = "opis...",
                CenaKursu = 0, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 3, KategoriaId = 1, TytulKursu = "Asp.Net Mvc - Sklep Internetowy", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekmvc2.png", OpisKursu = "opis...",
                CenaKursu = 100, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 4, KategoriaId = 2, TytulKursu = "JavaScript", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekjavascript.png", OpisKursu = "opis...",
                CenaKursu = 70, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 5, KategoriaId = 3, TytulKursu = "jQuery", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekjquery.png", OpisKursu = "opis...",
                CenaKursu = 90, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 6, KategoriaId = 4, TytulKursu = "Html5", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekhtml.png", OpisKursu = "opis...",
                CenaKursu = 70, Bestseller=false, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 7, KategoriaId = 5, TytulKursu = "Css3", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekcss.png", OpisKursu = "opis...",
                CenaKursu = 70, Bestseller=false, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 8, KategoriaId = 6, TytulKursu = "Xml", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekxml.png", OpisKursu = "opis...",
                CenaKursu = 60, Bestseller=false, Ukryty=false, OpisSkrocony = "opis skrocony..." },
                new Kurs() {KursId = 9, KategoriaId = 7, TytulKursu = "C#", AutorKursu = "Paweł", DataDodania = DateTime.Now, NazwaPlikuObrazka = "obrazekcsharp.png", OpisKursu = "opis...",
                CenaKursu = 90, Bestseller=true, Ukryty=false, OpisSkrocony = "opis skrocony..." },
            };

            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();
        }
        

    }
}