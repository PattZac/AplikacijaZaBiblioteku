using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Korisnik
    {
        string korisnik_ID ,ime, prezime, email, adresa;
        int brojTelefona;

        public string Korisnik_ID { get => korisnik_ID; set => korisnik_ID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }

        public Korisnik(string korisnik_ID, string ime, string prezime, string email, string adresa, int brojTelefona)
        {
            Korisnik_ID = korisnik_ID;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Adresa = adresa;
            BrojTelefona = brojTelefona;
        }

        public override string ToString()
        {
            return "ID: " + Korisnik_ID + " | Ime i Prezime: " + Ime + " " + Prezime + " | Email: " + Email + " | Adresa: " + Adresa + " | Broj Telefona: " + BrojTelefona;
        }
    }
}
