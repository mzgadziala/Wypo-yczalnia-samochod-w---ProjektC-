using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia
{
    class Program
    {
        static void Main(string[] args)
        {
            //dodanie samochodów
            SamochodOsobowy so1 = new SamochodOsobowy("Renault", "Clio", "2010", Silniki.Benzyna, Skrzynie.Manualna, 5.4, 120.0, 5);
            SamochodOsobowy so2 = new SamochodOsobowy("Toyota", "yaris", "2014", Silniki.Diesel, Skrzynie.Manualna, 6.1, 100.0, 4);
            SamochodOsobowy so3 = new SamochodOsobowy("Skoda", "Octavia", "2016", Silniki.BenzynaTSI, Skrzynie.Automatyczna, 5.9, 140.5, 5);
            SamochodOsobowy so4 = new SamochodOsobowy("Ford", "Mondeo", "2013", Silniki.Diesel3, Skrzynie.Automatyczna, 6.0, 150.0, 5);
            SamochodOsobowy so5 = new SamochodOsobowy("Peugeot", "508", "2015", Silniki.Diesel, Skrzynie.Manualna, 5.4, 165.0, 5);

            SamochodDostawczy sd1 = new SamochodDostawczy("Fiat", "Ducato", "2017", Silniki.Benzyna, Skrzynie.Manualna, 9.4, 250.0, 550);
            SamochodDostawczy sd2 = new SamochodDostawczy("Renault", "Trafic Furgon", "2017", Silniki.Benzyna, Skrzynie.Automatyczna, 8.2, 350.0, 2250);

            //stworzenie przykładowych klientów
            Klient k1 = new Klient("Jan", "Kot", "567345234", "jankot@gmail.com");
            Klient k2 = new Klient("Anna", "Nowak", "142756243", "annowak@wp.pl");

            Osobowe osobowe = new Osobowe();
            osobowe.dodajSamochod(so1);
            osobowe.dodajSamochod(so2);
            osobowe.dodajSamochod(so3);
            osobowe.dodajSamochod(so4);
            osobowe.dodajSamochod(so5);

            Dostawcze dostawcze = new Dostawcze();
            dostawcze.dodajSamochod(sd1);
            dostawcze.dodajSamochod(sd2);

            //dodanie kilku wypożyczeń
            Wypozyczenie w1 = new Wypozyczenie(Miasta.Kraków, Miasta.Warszawa, "12-05-2020", "16-05-2020", k1, so1);
            Wypozyczenie w2 = new Wypozyczenie(Miasta.Łódź, Miasta.Szczecin, "10-05-2020", "15-05-2020", k2, so2);

            ListaWypozyczen wypozyczenia = new ListaWypozyczen();
            wypozyczenia.dodaj(w1);
            wypozyczenia.dodaj(w2);

            //żeby wypisać dostene osobowe
            var listaDostepnych = osobowe.pokazDostepne(wypozyczenia, "13-05-2020", "14-05-2020");
            int ile = listaDostepnych.Count();

            StringBuilder sb = new StringBuilder();
            foreach(SamochodOsobowy samOs in listaDostepnych)
            {
                sb.AppendLine(samOs.ToString());
            }

            //żeby wypisać dostepne dostawcze
            var listaDostepnychDost = dostawcze.pokazDostepne(wypozyczenia, "13-05-2020", "14-05-2020");
            
            StringBuilder sb2 = new StringBuilder();
            foreach (SamochodDostawczy samDost in listaDostepnychDost)
            {
                sb2.AppendLine(samDost.ToString());
            }

            //wypisanie dostepnych os i dost
            //Console.WriteLine(sb);
            //Console.WriteLine(ile);
            //Console.WriteLine(sb2);







            Console.ReadKey();
        }
    }
}
