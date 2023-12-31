﻿using System;
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
    public partial class PregledKorsinik : Form
    {
        //Makes List of book objects
        List<Korisnik> list = new List<Korisnik>();
        public PregledKorsinik()
        {
            InitializeComponent();
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
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt64(element.Attribute("BrojTelefona").Value));
                        listKorisnik.Items.Add(kor.ToString());
                        list.Add(kor);
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
            listKorisnik.Items.Clear();
            string search = textBox2.Text;
            foreach (Korisnik korisnik in list)
            {
                if (korisnik.Ime.StartsWith(search) == true || korisnik.Prezime.StartsWith(search) == true || korisnik.Adresa.StartsWith(search) == true || korisnik.Email.StartsWith(search) == true || Convert.ToString(korisnik.BrojTelefona).StartsWith(search) == true || korisnik.Korisnik_ID.StartsWith(search) == true || search == "")
                {
                    listKorisnik.Items.Add(korisnik.ToString());
                }

            }
        }
    }
}
