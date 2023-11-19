using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Evidencija
    {
        string korisnik_ID, knjiga_ID;
        DateTime datumPos, datumVrac;
        int brojPus;

        public Evidencija(string korisnik_ID, string knjiga_ID, DateTime datumPos/*, int brojPus*/)
        {
            Korisnik_ID = korisnik_ID;
            Knjiga_ID = knjiga_ID;
            DatumPos = datumPos;
            BrojPus = 1;
        }

        public string Korisnik_ID { get => korisnik_ID; set => korisnik_ID = value; }
        public string Knjiga_ID { get => knjiga_ID; set => knjiga_ID = value; }
        public DateTime DatumPos { get => datumPos; set => datumPos = value; }
        public DateTime DatumVrac { get => datumVrac; set => datumVrac = value; }
        public int BrojPus { get => brojPus; set => brojPus = value; }
    }
}
