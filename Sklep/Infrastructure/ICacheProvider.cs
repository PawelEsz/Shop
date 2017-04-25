using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Infrastructure
{
    public interface ICacheProvider
    {
        //pobieranie danych z cache
        object Get(string key);

        //ustawianie cache
        void Set(string key, object data, int cacheTime);

        //sprawdza czy w cache cos sie znajduje
        bool isSet(string key);

        //usuwanie cache
        void Invalidate(string key);
    }
}
