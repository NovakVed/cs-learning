using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UCDodajSliku : UserControl
    {
        public UCDodajSliku()
        {
            InitializeComponent();
        }

        private void OnDodajSlikuClick(object sender, EventArgs e)
        {
            OpenFileDialog odabir = new OpenFileDialog();
            odabir.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";

            if (odabir.ShowDialog() == DialogResult.OK)
            {
                Bitmap datotekaSlika = new Bitmap(odabir.FileName);
                PBSlika.BackgroundImage = datotekaSlika;
                BTNDodaj.Text = "Uredi";
            }
        }

        /*
            @OnIzbrisiClick
            Ovo je privremena implementacija. Služi isključivo za prototipiranje. 
            U daljnjem razvoju potrebno je zaista izbrisati objekt, ne ga samo sakriti.
        */
        private void OnIzbrisiClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
