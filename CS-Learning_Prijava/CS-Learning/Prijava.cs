using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (var baza = new Entities())
            {
                string kriptiranaLozinka = Korisnik.ShaKriptiranje(txtPrijavaEmail.Text, txtPrijavaLozinka.Text);

                var rowNumPrivremeni = (from item in baza.Korisniks
                                        where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "DA"
                                        select item).Count();

                if( rowNumPrivremeni > 0)
                {
                    var proba = from item in baza.Korisniks
                                where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "DA"
                                select item;

                    PrikazGresakaPrijave.Text = "";
                    // postavi privremene podatke u glavne 
                    // izbrisi privremene podatke
                    // prikazi pocetnu stranicu

                    grid.DataSource = null;
                    grid.DataSource = proba.ToList();
                    grid.Columns[11].Visible = false;
                    //Eventi.OnUspjesnaPrijava();

                }
                else // provjeri korisnika medju glavnim zapisima
                {
                    var rowNum = (from item in baza.Korisniks
                                  where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "NE"
                                  select item).Count();


                    if (rowNum > 0)
                    {   // Korisnik je pronadjen
                        var proba = from item in baza.Korisniks
                                    where item.username == txtPrijavaEmail.Text && item.password == kriptiranaLozinka && item.privremeniZapis == "NE"
                                    select item;

                        PrikazGresakaPrijave.Text = "";
                        // prikazi pocetnu stranicu
                        

                        grid.DataSource = null;
                        grid.DataSource = proba.ToList();
                        grid.Columns[11].Visible = false;
                        //Eventi.OnUspjesnaPrijava();
                    }
                    else // Nepostojeci korisnik
                    {
                        PrikazGresakaPrijave.Text = "Pogrešna kombinacija korisničkog imena i lozinke.";
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
