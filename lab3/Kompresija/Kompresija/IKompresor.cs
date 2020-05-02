using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompresija
{
    interface IKompresor
    {
        String Kompresija(String fajl, String kompresovanFajl, String kodnaTabela);
        String Dekompresija(String kompresovanFajl, String fajl, String kodnaTabela);
    }
}