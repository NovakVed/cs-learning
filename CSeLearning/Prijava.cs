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
    public partial class Prijava : UserControl
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            using (var baza = new Entities() )
            {
                string kriptiranaLozinka = Korisnik.ShaKriptiranje(txtPrijavaEmail.Text, txtPrijavaLozinka.Text);

                var rowNumPrivremeni = (from item in baza.Korisniks
                                        where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "DA"
                                        select item).Count();

                if( rowNumPrivremeni > 0)
                {
                    Korisnik privremeniZapis = baza.Korisniks.FirstOrDefault(r => (r.username == txtPrijavaEmail.Text ) && (r.password == kriptiranaLozinka) && (r.privremeniZapis == "DA"));

                    PrikazGresakaPrijave.Text = "";
                    // postavi privremene podatke u glavne 
                    Korisnik stariZapis = baza.Korisniks.FirstOrDefault(r => (r.username== privremeniZapis.username ) && (r.privremeniZapis == "NE"));

                    stariZapis.password = privremeniZapis.password;

                    // izbrisi privremene podatke
                    baza.Korisniks.Remove(privremeniZapis);
                    baza.SaveChanges();
                    // prikazi pocetnu stranicu

                    //// AKO BUDE TREBALO PREKO NAZIVA ULOGE DOHVATIT HOCE LI SE OTVARAT STUDENT FORMA ILI PROFESOR FORMA
                    //Uloga korisnickaUloga = baza.Ulogas.FirstOrDefault(r => r.id == stariZapis.uloga_id);
                    //if ( korisnickaUloga.opis == "student") {  Eventi.OnUspjesnaPrijavaStudent(); } else { Eventi.OnUspjesnaPrijavaProfesor(); }

                    if ( stariZapis.uloga_id == 1)
                    {
                        Eventi.OnUspjesnaPrijavaStudent(stariZapis);
                    }
                    else
                    {
                        Eventi.OnUspjesnaPrijavaProfesor(stariZapis);
                    }
                    

                }
                else // provjeri korisnika medju glavnim zapisima
                {
                    var rowNum = (from item in baza.Korisniks
                                  where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "NE"
                                  select item).Count();


                    if (rowNum > 0)
                    {   // Korisnik je pronadjen
                        Korisnik stariZapis = baza.Korisniks.FirstOrDefault(r => (r.username == txtPrijavaEmail.Text) && (r.password == kriptiranaLozinka) && (r.privremeniZapis == "NE"));

                        PrikazGresakaPrijave.Text = "";
                        // izbrisi privremeniZapis ukoliko postoji

                        int brojPrivremenih = (from item in baza.Korisniks
                                               where item.username == txtPrijavaEmail.Text && item.privremeniZapis == "DA"
                                               select item).Count();

                        if ( brojPrivremenih > 0)
                        {
                            Korisnik privremeniZapis = baza.Korisniks.FirstOrDefault(r => (r.username == txtPrijavaEmail.Text) && (r.privremeniZapis == "DA"));
                            baza.Korisniks.Remove(privremeniZapis);
                            baza.SaveChanges();
                        }


                        // prikazi pocetnu stranicu
                        if (stariZapis.uloga_id == 1)
                        {
                            Eventi.OnUspjesnaPrijavaStudent(stariZapis);
                        }
                        else
                        {
                            Eventi.OnUspjesnaPrijavaProfesor(stariZapis);
                        }
                    }
                    else // Nepostojeci korisnik
                    {
                        PrikazGresakaPrijave.Text = "Pogrešna kombinacija korisničkih podataka.";
                    }
              
                }

            }

        }

        private void txtPrijavaEmail_Enter(object sender, EventArgs e)
        {
            if( txtPrijavaEmail.Text == "Korisničko ime")
            {
                txtPrijavaEmail.Text = "";

                txtPrijavaEmail.ForeColor = Color.Black;
            }
        }

        private void txtPrijavaEmail_Leave(object sender, EventArgs e)
        {
            if (txtPrijavaEmail.Text == "")
            {
                txtPrijavaEmail.Text = "Korisničko ime";

                txtPrijavaEmail.ForeColor = Color.Silver;
            }
        }

        

        private void txtPrijavaLozinka_Enter(object sender, EventArgs e)
        {
            if (txtPrijavaLozinka.Text == "Lozinka")
            {
                txtPrijavaLozinka.Text = "";
                txtPrijavaLozinka.PasswordChar = '*';

                txtPrijavaLozinka.ForeColor = Color.Black;
            }
        }

        private void txtPrijavaLozinka_Leave(object sender, EventArgs e)
        {
            if (txtPrijavaLozinka.Text == "")
            {
                txtPrijavaLozinka.Text = "Lozinka";
                txtPrijavaLozinka.PasswordChar = '\0';

                txtPrijavaLozinka.ForeColor = Color.Silver;
            }
        }

        private void linkRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Eventi.OnRegistrirajSe();
        }

        private void linkZaboravi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Eventi.OnZaboravljenaLozinka();
        }

        
    }
}
