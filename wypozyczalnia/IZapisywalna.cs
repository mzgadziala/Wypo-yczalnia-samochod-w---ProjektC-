using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia
{

    /// <summary>Interfejs zawierający metody publiczne wykorzystywane w klasie Wypożyczenie</summary>
    interface IZapisywalna
    {
        void ZapiszXML(string nazwa, Wypozyczenie w);
        Object OdczytajXML(string nazwa);
    }
}
