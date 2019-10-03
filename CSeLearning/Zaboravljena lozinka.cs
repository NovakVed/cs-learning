using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;

namespace CS_Learning
{
    public partial class Zaboravljena_lozinka : UserControl
    {
        public Zaboravljena_lozinka()
        {
            InitializeComponent();
        }

        private void btnZaboraviOdustani_Click(object sender, EventArgs e)
        {
            Eventi.OnNatragNaPrijavu();
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            using (var baza = new Entities())
            {
                int rowNum = (from item in baza.Korisniks
                              where item.email == txtZaboravljenaEmail.Text  // Trazimo postoji li uneseni e-mail u bazi
                              select item).Count();

                if (rowNum > 0)
                { // Uneseni email je pronadjen u bazi 
                    lblZaboravljenaLozGreska.Text = "";
                    Korisnik stariZapis;
                    string generiranaLozinka = Korisnik.GenerirajLozinku();

                    rowNum = (from item in baza.Korisniks
                              where item.email == txtZaboravljenaEmail.Text && item.privremeniZapis == "DA"  // Trazimo postoji li vec postojeci privremeni zapis
                              select item).Count();

                    

                    if (rowNum > 0)
                    { // Korisnik vec ima privremeni zapis ( AZURIRAJ POSTOJECI )
                        stariZapis  = baza.Korisniks.FirstOrDefault(r => (r.email == txtZaboravljenaEmail.Text) && (r.privremeniZapis == "DA") );

                        

                        stariZapis.password = Korisnik.ShaKriptiranje(stariZapis.username,generiranaLozinka);
                        baza.SaveChanges();

                    }
                    else
                    { // Korisnik nema prethodno generiran privremeni zapis ( STVORI PRIVREMENI ZAPIS )
                        stariZapis = baza.Korisniks.FirstOrDefault(r => r.email == txtZaboravljenaEmail.Text);

                        Korisnik noviPrivremeniZapis = new Korisnik();  
                        noviPrivremeniZapis.ime = stariZapis.ime;
                        noviPrivremeniZapis.prezime = stariZapis.prezime;
                        noviPrivremeniZapis.uloga_id = stariZapis.uloga_id;
                        noviPrivremeniZapis.username = stariZapis.username;
                        noviPrivremeniZapis.email = stariZapis.email;
                        noviPrivremeniZapis.datumPridruzivanja = stariZapis.datumPridruzivanja;
                        noviPrivremeniZapis.slikaProfila = stariZapis.slikaProfila;
                        noviPrivremeniZapis.opisProfila = stariZapis.opisProfila;


                        noviPrivremeniZapis.password = Korisnik.ShaKriptiranje(stariZapis.username,generiranaLozinka);       
                        noviPrivremeniZapis.privremeniZapis = "DA";

                        baza.Korisniks.Add(noviPrivremeniZapis);
                        baza.SaveChanges();


                    }

                    stariZapis.PosaljiNaMail(generiranaLozinka);
                    Eventi.OnNatragNaPrijavu();
                }
                else
                { // Uneseni email ne postoji u bazi
                    lblZaboravljenaLozGreska.Text = "Uneseni e-mail ne postoji u bazi podataka.";
                }
            }

            
        }

        private void txtZaboravljenaEmail_Enter(object sender, EventArgs e)
        {
            if (txtZaboravljenaEmail.Text == "Email")
            {
                txtZaboravljenaEmail.Text = "";

                txtZaboravljenaEmail.ForeColor = Color.Black;
            }
        }

        private void txtZaboravljenaEmail_Leave(object sender, EventArgs e)
        {
            if (txtZaboravljenaEmail.Text == "")
            {
                txtZaboravljenaEmail.Text = "Email";

                txtZaboravljenaEmail.ForeColor = Color.Silver;
            }
        }

        
    }
}
