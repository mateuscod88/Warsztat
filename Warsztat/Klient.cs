using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Klient: Osoba
    {
        public Klient() 
        {
            
        }
        public Klient(int id, string imie, string nazwisko, int telefon) 
        {
            this.OsobaID = id;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Telefon = telefon;
        }
    }
}
