using BankarskaAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarskaAplikacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racun racun = new Racun(1, 1000.0);
            //racun.sifra = 1;
            //racun.stanje = 1000.0;
            Racun racun2 = new Racun(2, 1500.0);

            //niz racuna  - pravim jer imam dva racuna
            

            Racun[] nizRacuna = new Racun[2]; // alternativan nacin unosa  - Racun[] nizRacuna = new Racun[]{racun, racun2};
                                                                    // u ovom slucaju ne mora se unositi vrednost u []
            nizRacuna[0] = racun;
            nizRacuna[1] = racun2;

                                              // Console.WriteLine(nizRacuna[0].stanje);
                                              // ---  puca program  kad pristupim objektiu da uzmem njegovo stanje


            Klijent klijent1 = new Klijent("Jagoda", "jagodic", "LN 36", "123456783211", nizRacuna);
           // klijent.ime = "Jagoda";
            //klijent.prezime = "Jagodic";
            //klijent.adresa = "Laze Nancica 36";
            //klijent.jmbg = "123456783211";
            
            racun.klijent = klijent1; // hocu da klijent u tom racunu postane Jagoda Jagodic
            Console.WriteLine("Klijent sa imenom " + klijent1.Ime + " i prezime " + klijent1.Prezime
                + " zivi na adresi: " + klijent1.Adresa + " i ima trenutno " + klijent1.Racuni.Length + " racuna");

            Console.WriteLine("Stanje na prvom racunu: " + klijent1.Racuni[0].stanje);
            Console.WriteLine("Stanje na drugom racunu: " + klijent1.Racuni[1].stanje);

            // primer enkapsulacije 
            racun.klijent = klijent1;
            
            klijent1.Ispis();


            Console.ReadKey();
        }
    }
}
