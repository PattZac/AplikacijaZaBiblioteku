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
    public partial class UnosKorisnik : Form
    {
        //Makes List of user objects
        List<Korisnik> list = new List<Korisnik>();
        public UnosKorisnik()
        {
            InitializeComponent();
            //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLKorisnik = mainFile + "\\Korisnike.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLKorisnik))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value,Convert.ToInt64( element.Attribute("BrojTelefona").Value));
                        list.Add(kor);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            txtIme.Focus();
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            //Creates an random string which is used for the ID, checks all object if another object has the same ID if not saves it to the newly created user object, if it does as starts over for id.
            try
            {
                Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (Korisnik os in list)
                {
                    if (os.Korisnik_ID == ranID)
                    {
                        goto Rando;
                    }
                }
                Korisnik kor = new Korisnik(ranID, txtIme.Text, txtPrezime.Text, txtEmail.Text, txtAdresa.Text, Convert.ToInt64( txtBrojTelefona.Text ));
                list.Add(kor); //Adds the new user object to the user list.
                //Converts all user object into an XDocument
                XDocument korXML = new XDocument(new XElement("Korisnike",
                        from xml in list
                        select new XElement("Korisnik",
                            new XAttribute("ID", xml.Korisnik_ID),
                            new XAttribute("Ime", xml.Ime),
                            new XAttribute("Prezime", xml.Prezime),
                            new XAttribute("Email", xml.Email),
                            new XAttribute("Adresa", xml.Adresa),
                            new XAttribute("BrojTelefona", xml.BrojTelefona))));
                //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
                string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
                mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                string fileStream = mainFile + "\\Korisnike.xml";
                //Deletes the xml file and creates the newly update one.
                File.Delete(fileStream); //TODO: convert the old file to old back-up file
                File.AppendAllText(fileStream, korXML.ToString());

                MessageBox.Show("Korisnik je uspješno spremljena!", "Uspješno spremljena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("Greška\r\n" + n, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIme.Clear();
            txtPrezime.Clear();
            txtEmail.Clear();
            txtAdresa.Clear();
            txtBrojTelefona.Clear();
            txtIme.Focus();
        }

        private void bntNazad_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
