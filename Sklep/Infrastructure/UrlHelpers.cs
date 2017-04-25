﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Infrastructure
{
    //musi byc static, aby umiescic w niej extention methods dla tej klasy

    public static class UrlHelpers
    {
        //helper, ktory zwraca sciezke do naszych ikon kategorii
        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwaIkonyKategorii)
        {
            var IkonyKategoriiFolder = AppConfig.IkonyKategoriiFolderWzgledny;
            var sciezka = Path.Combine(IkonyKategoriiFolder, nazwaIkonyKategorii);
            var sciezkaBezwzgledna = helper.Content(sciezka);

            return sciezkaBezwzgledna;
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var ObrazkiFolder = AppConfig.ObrazkiFolderWzgledny;
            var sciezka = Path.Combine(ObrazkiFolder, nazwaObrazka);
            var sciezkaBezwzgledna = helper.Content(sciezka);

            return sciezkaBezwzgledna;
        }
    }
}