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
    public partial class PregledSvePodataka : Form
    {
        List<Knjiga> listKnj = new List<Knjiga>();
        List<Korisnik> listKor = new List<Korisnik>();
        List<Evidencija> listEvi = new List<Evidencija>();
        public PregledSvePodataka()
        {
            InitializeComponent();
            //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLknjiga = mainFile + "\\Knjige.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLknjiga))
                {
                    XElement newXML = XElement.Load(reader);
                    listBox1.Items.Add("Knjiga");
                    foreach (XElement element in newXML.Elements())
                    {
                        Knjiga knj = new Knjiga(element.Attribute("ID").Value, element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value);
                        listBox1.Items.Add(knj.ToString());
                        listKnj.Add(knj);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            string XMLKorisnik = mainFile + "\\Korisnike.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLKorisnik))
                {
                    XElement newXML = XElement.Load(reader);
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Korisnik");
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt64(element.Attribute("BrojTelefona").Value));
                        listBox1.Items.Add(kor.ToString());
                        listKor.Add(kor);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            string XMLEvidencija = mainFile + "\\Evidencija.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLEvidencija))
                {
                    XElement newXML = XElement.Load(reader);
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Evidencija");
                    foreach (XElement element in newXML.Elements())
                    {
                        Evidencija nv = new Evidencija(element.Attribute("KorisnikID").Value, element.Attribute("KnjigaID").Value, Convert.ToDateTime(element.Attribute("DatumPodizanja").Value));
                        if (element.Attribute("DatumVracanja").Value != "0001-01-01T00:00:00")
                        {
                            nv.DatumVrac = Convert.ToDateTime(element.Attribute("DatumVracanja").Value);
                        }
                        listBox1.Items.Add(nv.ToString());
                        listEvi.Add(nv);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
        }

        private void bntNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string search = textBox2.Text;
            listBox1.Items.Add("Knjiga");
            foreach (Knjiga knjiga in listKnj)
            {
                if (knjiga.Izdavac.StartsWith(search) == true || knjiga.Naslov.StartsWith(search) == true || knjiga.Knjiga_ID.StartsWith(search) == true || knjiga.Author.StartsWith(search) == true || search == "")
                {
                    listBox1.Items.Add(knjiga.ToString());
                }

            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Korisnik");
            foreach (Korisnik korisnik in listKor)
            {
                if (korisnik.Ime.StartsWith(search) == true || korisnik.Prezime.StartsWith(search) == true || korisnik.Adresa.StartsWith(search) == true || korisnik.Email.StartsWith(search) == true || Convert.ToString(korisnik.BrojTelefona).StartsWith(search) == true || korisnik.Korisnik_ID.StartsWith(search) == true || search == "")
                {
                    listBox1.Items.Add(korisnik.ToString());
                }

            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Evidencija");
            foreach (Evidencija evidencija in listEvi)
            {
                if (evidencija.Korisnik_ID.StartsWith(search) == true || evidencija.Knjiga_ID.StartsWith(search) == true || evidencija.DatumPos.ToString().StartsWith(search) == true || evidencija.DatumVrac.ToString().StartsWith(search) == true || search=="")
                {
                    listBox1.Items.Add(evidencija.ToString());
                }

            }
        }
    }
}
