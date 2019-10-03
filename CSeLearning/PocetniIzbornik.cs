using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
	public partial class PocetniIzbornik : Form
	{
		public PocetniIzbornik()
		{
			InitializeComponent();
            PratiEvente();
        }

        private void PratiEvente()
        {
            Eventi.ZaboravljenaLozinka += Eventi_ZaboravljenaLozinka;
            Eventi.RegistrirajSe += Eventi_RegistrirajSe;
            Eventi.NatragNaPrijavu += Eventi_NatragNaPrijavu;
            Eventi.UspjesnaPrijavaStudent += Eventi_UspjesnaPrijavaStudent;
            Eventi.UspjesnaPrijavaProfesor += Eventi_UspjesnaPrijavaProfesor;
            Eventi.Izlaz += Eventi_Izlaz;
        }

        private void Eventi_ZaboravljenaLozinka(object sender, EventArgs e)
        {
            prijava1.Hide();
            zaboravljena_lozinka1.Show();
            registracija1.Hide();

        }

        private void Eventi_RegistrirajSe(object sender, EventArgs e)
        {
            prijava1.Hide();
            zaboravljena_lozinka1.Hide();
            registracija1.Show();

        }

        private void Eventi_NatragNaPrijavu(object sender, EventArgs e)
        {

            zaboravljena_lozinka1.Hide();
            registracija1.Hide();
            prijava1.Show();

        }

        private void Eventi_UspjesnaPrijavaStudent(object sender, EventArgsKorisnik e)
        {
            prijava1.Hide();
            zaboravljena_lozinka1.Hide();
            registracija1.Hide();
            this.Visible = false;
            GlavniIzbornik_Student stud = new GlavniIzbornik_Student(e.PrijavljeniKorisnik);
            stud.ShowDialog();
			this.Close();
			//MessageBox.Show("Ulogiran kao student!");
		}

		private void Eventi_UspjesnaPrijavaProfesor(object sender, EventArgsKorisnik e)
        {
            prijava1.Hide();
            zaboravljena_lozinka1.Hide();
            registracija1.Hide();
            this.Visible = false;
            GlavniIzbornik_Profesor prof = new GlavniIzbornik_Profesor(e.PrijavljeniKorisnik);
			prof.ShowDialog();
			this.Close();
            //MessageBox.Show("Ulogiran kao profesor!");
        }

        private void Eventi_Izlaz(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartupForma_Load(object sender, EventArgs e)
        {
            prijava1.Visible = true;
            registracija1.Visible = false;
            zaboravljena_lozinka1.Visible = false;
        }
    }
}
