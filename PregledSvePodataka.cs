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
                    textBox2.Text = "Knjiga \n\r";
                    foreach (XElement element in newXML.Elements())
                    {
                        Knjiga knj = new Knjiga(element.Attribute("ID").Value, element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value);
                        textBox2.Text += knj.ToString()+"\n\r";
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
                    textBox2.Text = "Korisnik \n\r";
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt32(element.Attribute("BrojTelefona").Value));
                        textBox2.Text += kor.ToString() + "\n\r";
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
                    textBox2.Text = "Evidencija \n\r";
                    foreach (XElement element in newXML.Elements())
                    {
                        Evidencija nv = new Evidencija(element.Attribute("KorisnikID").Value, element.Attribute("KnjigaID").Value, Convert.ToDateTime(element.Attribute("DatumPodizanja").Value));
                        if (element.Attribute("DatumVracanja").Value != "0001-01-01T00:00:00")
                        {
                            nv.DatumVrac = Convert.ToDateTime(element.Attribute("DatumVracanja").Value);
                        }
                        textBox2.Text += nv.ToString() + "\n\r";
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

        }
    }
}
