using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankarskaAplikacija
{
    public class Racun
    {
        public int sifra;
        public double stanje;
        public Klijent klijent;

        public bool Uplata(double iznos)
        {
            throw new System.NotImplementedException();
        }

        public bool Isptlata(double iznos)
        {
            throw new System.NotImplementedException();
        }
        //napraviti dva konstruktora
        //1. za sifru i stanje
        //2. za sifru, stanje i klijenta
        public Racun(int sifra, double stanje) // vazno da konsturktor definise vrednosi sa this. iz parametara ()
        {
            this.sifra = sifra;
            this.stanje = stanje;
        }
        public Racun (int sifra, double stanje, Klijent klijent1)
        {
            this.sifra = sifra;
            this.stanje = stanje;
            this.klijent = klijent1;
        }

    }
}