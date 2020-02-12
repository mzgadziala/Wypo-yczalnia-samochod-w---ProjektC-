using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia;


namespace wypozyczalnia
{
    /// <summary>
    /// Klasa publiczna opisująca Klienta
    /// </summary>

    public class Klient
    {
        private string imie;
        private string nazwisko;
        private string numerTelefonu;
        private string adresEmail;
        private string numerKarty;
        private string waznoscKarty;
        private string kodZabazpieczajacy;

        /// <summary>Gets or sets imie.</summary>
        /// <value>Imię Klienta</value>
        public string Imie { get => imie; set => imie = value; }

        /// <summary>Gets or sets nazwisko.</summary>
        /// <value>Nazwisko Klienta</value>
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        /// <summary>Gets or sets numer telefonu.</summary>
        /// <value>  Numer telefonu.</value>
        public string NumerTelefonu { get => numerTelefonu; set => numerTelefonu = value; }

        /// <summary>Gets or sets adres email.</summary>
        /// <value>  Adres email.</value>
        public string AdresEmail { get => adresEmail; set => adresEmail = value; }

        /// <summary>Gets or sets numer karty.</summary>
        /// <value> Numer karty.</value>
        public string NumerKarty { get => numerKarty; set => numerKarty = value; }

        /// <summary>Gets or sets waznosc karty.</summary>
        /// <value>  Waznosc karty.</value>
        public string WaznoscKarty { get => waznoscKarty; set => waznoscKarty = value; }

        /// <summary>Gets or sets kod zabazpieczajacy.</summary>
        /// <value>  Kod zabazpieczajacy.</value>
        public string KodZabazpieczajacy { get => kodZabazpieczajacy; set => kodZabazpieczajacy = value; }

        /// <summary>Inicjalizacja przy nowym obiekcie klasy <see cref="Klient"/> class.</summary>
        /// <param name="imie">  Imie.</param>
        /// <param name="nazwisko">Nazwisko.</param>
        /// <param name="numerTelefonu">Numer telefonu.</param>
        /// <param name="adresEmail">Adres email.</param>
        public Klient(string imie, string nazwisko, string numerTelefonu, string adresEmail)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerTelefonu = numerTelefonu;
            this.adresEmail = adresEmail;
        }

        /// <summary>Konwersja do Stringa</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            return $"{imie} {nazwisko}";
        }

    }
}
