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
    public partial class Registracija : UserControl
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string email = txtRegistracijaEmail.Text;
            string korIme = txtRegistracijaKorIme.Text;

            string lozinka = Korisnik.ShaKriptiranje(korIme, txtRegistracijaLozinka.Text);

            using (var baza = new Entities())
            {

            }


        }

        private void btnRegistracijaNatrag_Click(object sender, EventArgs e)
        {
            Eventi.OnNatragNaPrijavu();
        }

        private void txtRegistracijaEmail_Enter(object sender, EventArgs e)
        {
            if (txtRegistracijaEmail.Text == "Email")
            {
                txtRegistracijaEmail.Text = "";

                txtRegistracijaEmail.ForeColor = Color.Black;
            }
        }

        private void txtRegistracijaEmail_Leave(object sender, EventArgs e)
        {
            if (txtRegistracijaEmail.Text == "")
            {
                txtRegistracijaEmail.Text = "Email";

                txtRegistracijaEmail.ForeColor = Color.Silver;
            }
        }

        private void txtRegistracijaKorIme_Enter(object sender, EventArgs e)
        {
            if (txtRegistracijaKorIme.Text == "Korisničko ime")
            {
                txtRegistracijaKorIme.Text = "";

                txtRegistracijaKorIme.ForeColor = Color.Black;
            }
        }

        private void txtRegistracijaKorIme_Leave(object sender, EventArgs e)
        {
            if (txtRegistracijaKorIme.Text == "")
            {
                txtRegistracijaKorIme.Text = "Korisničko ime";

                txtRegistracijaKorIme.ForeColor = Color.Silver;
            }
        }

        private void txtRegistracijaLozinka_Enter(object sender, EventArgs e)
        {
            if (txtRegistracijaLozinka.Text == "Lozinka")
            {
                txtRegistracijaLozinka.Text = "";
                txtRegistracijaLozinka.PasswordChar = '*';

                txtRegistracijaLozinka.ForeColor = Color.Black;
            }
        }

        private void txtRegistracijaLozinka_Leave(object sender, EventArgs e)
        {
            if (txtRegistracijaLozinka.Text == "")
            {
                txtRegistracijaLozinka.Text = "Lozinka";
                txtRegistracijaLozinka.PasswordChar = '\0';

                txtRegistracijaLozinka.ForeColor = Color.Silver;
            }
        }

        private void txtRegistracijaPotvrda_Enter(object sender, EventArgs e)
        {
            if (txtRegistracijaPotvrda.Text == "Potvrdi lozinku")
            {
                txtRegistracijaPotvrda.Text = "";
                txtRegistracijaPotvrda.PasswordChar = '*';

                txtRegistracijaPotvrda.ForeColor = Color.Black;
            }
        }

        private void txtRegistracijaPotvrda_Leave(object sender, EventArgs e)
        {
            if (txtRegistracijaPotvrda.Text == "")
            {
                txtRegistracijaPotvrda.Text = "Potvrdi lozinku";
                txtRegistracijaPotvrda.PasswordChar = '\0';

                txtRegistracijaPotvrda.ForeColor = Color.Silver;
            }
        }

        
    }
}
