﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class KoszykUsuwanieViewModel
    {
        public decimal KoszykCenaCalkowita { get; set; }
        public int KoszykIloscPozycji { get; set; }
        public int IloscPozycjiUsuwanej { get; set; }
        public int IdPozycjiUsuwanej { get; set; }
    }
}