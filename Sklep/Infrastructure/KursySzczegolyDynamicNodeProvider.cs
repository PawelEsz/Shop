using MvcSiteMapProvider;
using Sklep.DAL;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class KursySzczegolyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private KursyContext db = new KursyContext();
        //metoda ta generuje linki do 
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();
            
            foreach(Kurs kurs in db.Kursy)
            {
                DynamicNode node = new DynamicNode();
                node.Title = kurs.TytulKursu;
                node.Key = "kurs_" + kurs.KursId;
                node.ParentKey = "Kategoria_" + kurs.KategoriaId;
                node.RouteValues.Add("id", kurs.KursId);
                returnValue.Add(node);
            }

            return returnValue;
        }
    }
}