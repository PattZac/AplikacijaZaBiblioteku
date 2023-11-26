using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            //File locations for each file
            string XMLknjigaFile = mainFile+"\\Knjige.xml", 
                XMLkorisnikFile = mainFile + "\\Korisnike.xml",
                XMLEvidencija = mainFile + "\\Evidencija.xml";
            //Checks if the directory or file exist, if not creates it.
            if (!Directory.Exists(mainFile))
                Directory.CreateDirectory(mainFile);
            if (!File.Exists(XMLknjigaFile))
                File.Create(XMLknjigaFile);
            if (!File.Exists(XMLkorisnikFile))
                File.Create(XMLkorisnikFile);
            if (!File.Exists(XMLEvidencija))
                File.Create(XMLEvidencija);

            doList();
        }
        private void doList()
        {
            //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            //File locations for each file
            string XMLEvidencija = mainFile + "\\Evidencija.xml";
            try
            {
                textBox1.Clear();
                using (StreamReader reader = new StreamReader(XMLEvidencija))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Evidencija kor = new Evidencija(element.Attribute("KorisnikID").Value, element.Attribute("KnjigaID").Value, Convert.ToDateTime(element.Attribute("DatumPodizanja").Value));
                        if (element.Attribute("DatumVracanja").Value != "0001-01-01T00:00:00")
                        {
                            kor.DatumVrac = Convert.ToDateTime(element.Attribute("DatumVracanja").Value);
                        }
                        else
                        {
                            textBox1.Text += "  Evidencija | "+kor.ToString()+"\r\n";
                        }
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }

        }
        //Buttons to open new windows and makes the main window invisble until the subwindow closes
        //TODO: see how to make this less bloated
        private void bntPregledKorsinik_Click(object sender, EventArgs e)
        {
            PregledKorsinik pregledKorsinik = new PregledKorsinik();
            this.Visible = false;
            if (pregledKorsinik.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void bntPregledKnijga_Click(object sender, EventArgs e)
        {
            PregledKnjige pregledKnjige = new PregledKnjige();
            this.Visible = false;
            if (pregledKnjige.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void bntPregled_Click(object sender, EventArgs e)
        {
            PregledSvePodataka pregledSvePodataka = new PregledSvePodataka();
            this.Visible = false;
            if (pregledSvePodataka.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void bntUnosKorsnik_Click(object sender, EventArgs e)
        {
            UnosKorisnik unosKorisnik = new UnosKorisnik();
            this.Visible = false;
            if (unosKorisnik.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void bntUnosKnjiga_Click(object sender, EventArgs e)
        {
            UnosKnijga unosKnijga = new UnosKnijga();
            this.Visible = false;
            if (unosKnijga.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void bntUnosPosudivanje_Click(object sender, EventArgs e)
        {
            UnosPosudivanje unosPosudivanje = new UnosPosudivanje();
            this.Visible = false;
            if (unosPosudivanje.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
                doList();
            }
        }

        private void bntUnosVracanje_Click(object sender, EventArgs e)
        {
            UnosVracanjeKnjiga unosVracanjeKnjiga = new UnosVracanjeKnjiga();
            this.Visible = false;
            if (unosVracanjeKnjiga.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
                doList();
            }
        }
    }
}
