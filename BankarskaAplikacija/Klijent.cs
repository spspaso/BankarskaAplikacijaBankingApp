using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankarskaAplikacija
{
    public class Klijent
    {
        public string Adresa { get; set; }
        private string ime;
        public string Prezime { get; set; } //interfejsni property
        public string Jmbg { get; set; }    
        public Racun[] Racuni { get; set; } 

        

        public string Ime // potpun property
        {
            get { return ime; }
            set { ime = value; } 
        }    

        public Klijent()
        {
            this.Adresa = "";
            this.Jmbg = "000000";
            this.Ime = "";
            this.Prezime = "";
            this.Racuni = new Racun[5];
        }
        public Klijent(string ime, string prezime, string adr)  //naziv konstruktora Klijent se zove sa nazivom nase klase
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adr;          // ako se nazivi poklapaju this. je obavezeno, u suprotnom dovoljno je adresa = adr;

        }
        // generisani konsturktor preko lamice 
        public Klijent(string adresa, string ime, string prezime, string jmbg, Racun[] racuni) : this(adresa, ime, prezime)
        {
            this.Jmbg = jmbg;
            this.Racuni = racuni;
        }

        public void Ispis()
        {
            Console.WriteLine("Klijent sa imenom " + this.Ime + " i prezime " + this.Prezime
                + " zivi na adresi: " + this.Adresa + " i ima trenutno " + this.Racuni.Length + " racuna");

            Console.WriteLine("Stanje na prvom racunu: " + this.Racuni[0].stanje);
            Console.WriteLine("Stanje na drugom racunu: " + this.Racuni[1].stanje);

            
        }
    }
}
