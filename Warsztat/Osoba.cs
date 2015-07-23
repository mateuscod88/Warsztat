using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
   public abstract class Osoba
    {
        public int OsobaID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Telefon { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return Imie +" "+ Nazwisko+" ID:"+ OsobaID;
        }
    }
}
