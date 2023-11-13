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
    public partial class UnosKnijga : Form
    {
        List<Knjiga> list = new List<Knjiga>();
        string fileStream = "C:\\Users\\" + Environment.UserName + "\\Documents\\AplikacijaZaBiblioteku\\Knjige.xml";
        public UnosKnijga()
        {
            InitializeComponent();

            //FileStream fileStream = new FileStream("knjiga.xml", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Knjiga knj = new Knjiga(element.Attribute("ID").Value, element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value);
                        list.Add(knj);
                    }
            }
        }

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (Knjiga os in list)
                {
                    if (os.Knjiga_ID == ranID)
                    {
                        goto Rando;
                    }
                }
            Knjiga knj = new Knjiga(ranID, txtAuthor.Text, txtNaslov.Text, txtIzdavac.Text);
            list.Add(knj);

            XDocument knjXML = new XDocument(new XElement("knjige", 
                    from xml in list
                    select new XElement("Knjige",
                        new XAttribute("ID", xml.Knjiga_ID),
                        new XAttribute("Author", xml.Author),
                        new XAttribute("Naslov", xml.Naslov),
                        new XAttribute("Izdavac", xml.Izdavac))));

            File.AppendAllText(fileStream, knjXML.ToString());
        }

        private void bntNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
