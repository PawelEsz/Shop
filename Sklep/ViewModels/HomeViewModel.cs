using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class HomeViewModel
    {
        /*
         * Tutaj znajduje sie lista elementow, ktore beda dynamicznie pokazywaly sie na stronie glownej Home
         */

        public IEnumerable<Kategoria> Kategorie { get; set; }
        public IEnumerable<Kurs> Nowosci { get; set; }
        public IEnumerable<Kurs> Bestsellery { get; set; }
    }
}