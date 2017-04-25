using MvcSiteMapProvider;
using Sklep.DAL;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class KategorieDynamicNodeProvider : DynamicNodeProviderBase
    {
        private KursyContext db = new KursyContext();
        //metoda ta generuje linki do 
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach (Kategoria kategoria in db.Kategorie)
            {
                DynamicNode node = new DynamicNode();
                node.Title = kategoria.NazwaKategorii;
                node.Key = "Kategoria_" + kategoria.KategoriaId;
                node.RouteValues.Add("nazwaKategorii", kategoria.NazwaKategorii);
                returnValue.Add(node);
            }

            return returnValue;
        }
    }
}