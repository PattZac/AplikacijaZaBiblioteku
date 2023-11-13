using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // TEST!
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                
            string XMLknjigaFile = mainFile+"\\Knjige.xml", XMLkorisnikFile = mainFile + "\\Korsnike.xml", XMLposudivanjeFile = mainFile + "\\Posudivanje.xml";
            if (File.Exists(mainFile))
            {
                File.Create(mainFile);
                File.Create(XMLknjigaFile);
                File.Create(XMLkorisnikFile);
                File.Create(XMLposudivanjeFile);
            }
        }

        private void bntPregledKorsinik_Click(object sender, EventArgs e)
        {
            PregledKorsinik pregledKorsinik = new PregledKorsinik();
            pregledKorsinik.Show();
        }

        private void bntPregledKnijga_Click(object sender, EventArgs e)
        {
            PregledKnjige pregledKnjige = new PregledKnjige();
            pregledKnjige.Show();
        }

        private void bntPregled_Click(object sender, EventArgs e)
        {
            PregledSvePodataka pregledSvePodataka = new PregledSvePodataka();
            pregledSvePodataka.Show();
        }

        private void bntUnosKorsnik_Click(object sender, EventArgs e)
        {
            UnosKorisnik unosKorisnik = new UnosKorisnik();
            unosKorisnik.Show();
        }

        private void bntUnosKnjiga_Click(object sender, EventArgs e)
        {
            UnosKnijga unosKnijga = new UnosKnijga();
            unosKnijga.Show();
            //DialogResult 

        }

        private void bntUnosPosudivanje_Click(object sender, EventArgs e)
        {
            UnosPosudivanje unosPosudivanje = new UnosPosudivanje();
            unosPosudivanje.Show();
        }

        private void bntUnosVracanje_Click(object sender, EventArgs e)
        {
            UnosVracanjeKnjiga unosVracanjeKnjiga = new UnosVracanjeKnjiga();
            unosVracanjeKnjiga.Show();
        }
    }
}
