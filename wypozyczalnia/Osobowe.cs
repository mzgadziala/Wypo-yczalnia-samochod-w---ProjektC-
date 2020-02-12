using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia
{

    /// <summary>Publiczna klasa działająca na liście Samochodów Osobowych </summary>
    public class Osobowe
    {

        /// <summary>Liczba osobowych</summary>
        public int liczbaOsobowych;

        /// <summary>Lista wszystkich Samochodów Osobowych</summary>
        public List<SamochodOsobowy> wszystkieOsobowe;

        /// <summary>Lista dostepnych Samochodow Osobowych</summary>
        public List<SamochodOsobowy> dostepneOsobowe;


        /// <summary>Inicjalizacja przy nowym obiekcie klasy <see cref="Osobowe"/> class.</summary>
        public Osobowe()
        {
            liczbaOsobowych = 0;
            wszystkieOsobowe = new List<SamochodOsobowy>();
            
        }


        /// <summary>Dodawanie Samochodu Osobowego do listy</summary>
        /// <param name="s">obiekt Samochód Osobowy do dodania.</param>
        public void dodajSamochod(SamochodOsobowy s)
        {
            liczbaOsobowych++;
            wszystkieOsobowe.Add(s);
        }


        /// <summary>  Sprawdzanie czy obiekt Samochod Osobowy jest na liście</summary>
        /// <param name="c">  obiekt Samochd Osobowy</param>
        /// <returns>Wybrany Samochd Osobowy nie jest dostępny</returns>
        public bool jestWInwentarzu(SamochodOsobowy c)
        {
            foreach (SamochodOsobowy s in wszystkieOsobowe)
            {
                if (s.Equals(c)) return true;
            }
            return false;
        }

        /// <summary>  Usuwanie Samochodu Osobowego z listy</summary>
        /// <param name="p">  Obiekt Samochd Osobowy do usunięcia</param>
        public void UsunSamochod(SamochodOsobowy p)
        {
            if (jestWInwentarzu(p))
            {
                wszystkieOsobowe.Remove(p);
            }
        }

        /// <summary>Generowanie listy dostępnych wypożyczeń w danym czasie</summary>
        /// <param name="lista"> Lista Wypożyczen</param>
        /// <param name="dataOdbioru">Data odbioru.</param>
        /// <param name="dataZwrotu">Data zwrotu.</param>
        /// <returns>Lista dostępnych Samochodów Osobowych</returns>
        public List<SamochodOsobowy> pokazDostepne(ListaWypozyczen lista, string dataOdbioru, string dataZwrotu)
        {
            DateTime odbior = DateTime.Parse(dataOdbioru);
            DateTime zwrot = DateTime.Parse(dataZwrotu);
            dostepneOsobowe = new List<SamochodOsobowy>(wszystkieOsobowe);

            foreach(SamochodOsobowy s in wszystkieOsobowe)
            {
                foreach(Wypozyczenie w in lista.listaWypozyczen)
                {
                    if(s == w.So && ((zwrot > w.DataOdbioru && odbior < w.DataOdbioru) || 
                        (odbior < w.DataZwrotu && zwrot > w.DataZwrotu) || (odbior > w.DataOdbioru && zwrot < w.DataZwrotu)))
                    {
                        dostepneOsobowe.Remove(s);
                    }
                }
            }
            return dostepneOsobowe;
        }

        /// <summary>Konwersja do Stringa.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (SamochodOsobowy s in wszystkieOsobowe)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }

        /// <summary>Klonowanie instancji.</summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
