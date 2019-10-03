using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Learning
{
    public partial class StartupForma : Form
    {
        public StartupForma()
        {
            InitializeComponent();
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            Eventi.ZaboravljenaLozinka += Eventi_ZaboravljenaLozinka;
            Eventi.RegistrirajSe += Eventi_RegistrirajSe;
            Eventi.NatragNaPrijavu += Eventi_NatragNaPrijavu;
            Eventi.UspjesnaPrijava += Eventi_UspjesnaPrijava;
        }

        private void Eventi_ZaboravljenaLozinka(object sender, EventArgs e)
        {
            prijava1.Hide();
            zaboravljena_lozinka1.Show();
            //MessageBox.Show("Kliknuli ste na nešto!");
        }

        private void Eventi_RegistrirajSe(object sender, EventArgs e)
        {
            prijava1.Hide();
            registracija1.Show();
            //MessageBox.Show("Kliknuli ste na nešto!");
        }

        private void Eventi_NatragNaPrijavu(object sender, EventArgs e)
        {
            glavniIzbornik1.Hide();
            zaboravljena_lozinka1.Hide();
            registracija1.Hide();
            prijava1.Show();
            //MessageBox.Show("Kliknuli ste na nešto!");
        }

        private void Eventi_UspjesnaPrijava(object sender, EventArgs e)
        {
            prijava1.Hide();
            glavniIzbornik1.Show();
            //MessageBox.Show("Kliknuli ste na nešto!");
        }

        private void StartupForma_Load(object sender, EventArgs e)
        {
            prijava1.Visible = true;
            registracija1.Visible = false;
            zaboravljena_lozinka1.Visible = false;
            glavniIzbornik1.Visible = false;
        }
    }
}
