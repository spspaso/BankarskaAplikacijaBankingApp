using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarskaAplikacija.Model
{
    internal class BankarskiRacun
    {
        public int sifra;
        public double stanje;

        public bool Uplata(double iznos)
        {
            stanje += iznos;   //stanje = stanje + iznos
            return true;

        }
        //stanje = 1000.0
        //iznos = 2500.0
        public bool Isplata(double iznos)
        {
            if (stanje >= iznos)
            {
                stanje -= iznos;
                return true;
            }

            return false;   

        }
    }
}
