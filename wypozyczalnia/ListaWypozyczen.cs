using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wypozyczalnia
{
    /// <summary>
    /// Klasa publiczna generująca listę wypożyczeń
    /// </summary>
    public class ListaWypozyczen
    {

        /// <summary>Liczba wypozyczen</summary>
        public int liczbaWypozyczen = 0;

        /// <summary>Lista wypozyczen</summary>
        public List<Wypozyczenie> listaWypozyczen = new List<Wypozyczenie>();

        /// <summary>Inicjalizacja przy nowym obiekcie klasy <see cref="ListaWypozyczen"/> class.</summary>
        public ListaWypozyczen()
        {
            liczbaWypozyczen = 0;
            listaWypozyczen = new List<Wypozyczenie>();
        }

        /// <summary>Dodawanie do listy nowego obiektu Wypożyczenie</summary>
        /// <param name="w">
        ///   <para>Wypożyczenie</para>
        /// </param>
        public void dodaj(Wypozyczenie w)
        {
            listaWypozyczen.Add(w);
            liczbaWypozyczen++;
        }

        /// <summary>Konwersja do Stringa.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Wypozyczenie w in listaWypozyczen)
            {
                sb.AppendLine(w.ToString());
            }
            return sb.ToString();
        }

    }

}
