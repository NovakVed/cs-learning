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
	public partial class UCIzbornik : UserControl
	{
		private List<UserControl> listaIzbornika = null;
		private Form FormaSIzbornicima { get; set; } = null;
		private Button OdabraniGumb { get; set; } = null;
		private UserControl TrenutniIzbornik { get; set; } = null;
		//private Color bojaPozadineGumba = Color.FromArgb(237, 237, 237); //zamjenska boja pozadine gumbova i izbornika
		private Color bojaPozadineGumba = Color.White;
		private Color bojaOdabranogGumba = Color.FromArgb(204, 221, 221);
		private Color bojaIsticanjaGumba = Color.FromArgb(227, 250, 248);


		[Description("Boja pozadine indikatora."), Category("DodatnePostavke")]
		public Color BojaIndikatora
		{
			get { return UCIzbornikPanelIndikator.BackColor; }
			set { UCIzbornikPanelIndikator.BackColor = value; }
		}

		[Description("Boja pozadine gumba."), Category("DodatnePostavke")]
		public Color BojaPozadineGumba
		{
			get { return bojaPozadineGumba; }
			set { bojaPozadineGumba = value; }
		}

		[Description("Boja pozadine odabranog gumba"), Category("DodatnePostavke")]
		public Color BojaOdabranogGumba
		{
			get { return bojaOdabranogGumba; }
			set { bojaOdabranogGumba = value; }
		}

		[Description("Boja pozadine gumba kada se mišem prijeđe preko njega."), Category("DodatnePostavke")]
		public Color BojaIsticanjaGumba
		{
			get { return bojaIsticanjaGumba; }
			set { bojaIsticanjaGumba = value; }
		}

		public UCIzbornik()
		{
			InitializeComponent();
			OdabraniGumb = UCIzbornikNFBTNPocetna;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
		}

		private void UCIzbornik_Load(object sender, EventArgs e)
		{
			//OdabraniGumb = UCIzbornikNFBTNPocetna;
			//PromjeniPolozajIndikatora(OdabraniGumb);
			//PromjeniBojeGumbovima(OdabraniGumb);
		}

		public void UcitajIzbornikeSForme(List<UserControl> izbornici, Form forma)
		{
			listaIzbornika = izbornici;
			FormaSIzbornicima = forma;
			PrikaziIzbornik(1);
		}

		public void PromjeniBojeGumbovima(Button odabraniGumb)
		{
			odabraniGumb.BackColor = bojaOdabranogGumba;
			odabraniGumb.FlatAppearance.MouseDownBackColor = BojaOdabranogGumba;
			odabraniGumb.FlatAppearance.MouseOverBackColor = bojaOdabranogGumba;
			foreach (Control con in this.Controls)
			{
				if (con.Name != odabraniGumb.Name && con.Name.Contains("BTN"))
				{
					(con as Button).BackColor = bojaPozadineGumba;
					(con as Button).FlatAppearance.MouseDownBackColor = BojaOdabranogGumba;
					(con as Button).FlatAppearance.MouseOverBackColor = bojaIsticanjaGumba;
				}
			}
		}

		public void PromjeniPolozajIndikatora(Button ciljaniGumb)
		{
			UCIzbornikPanelIndikator.Top = ciljaniGumb.Top;
			UCIzbornikPanelIndikator.Height = ciljaniGumb.Height;
		}

		private void PrikaziIzbornik(int indexIzbornika)
		{
			listaIzbornika[indexIzbornika].Show();
			if (TrenutniIzbornik != null && TrenutniIzbornik != listaIzbornika[indexIzbornika])
			{
				TrenutniIzbornik.Hide();
			}
			TrenutniIzbornik = listaIzbornika[indexIzbornika];
		}

		private void UCIzbornikNFBTNProfil_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNProfil;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(0);
		}

		private void UCIzbornikNFBTNPocetna_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNPocetna;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(1);
		}

		private void UCIzbornikNFBTNEdukacije_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNEdukacije;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(2);
		}

		private void UCIzbornikNFBTNIspiti_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNIspiti;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(3);
		}

		private void UCIzbornikNFBTNRezultati_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNRezultati;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(4);
		}

		private void UCIzbornikNFBTNTrgovina_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNTrgovina;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(5);
		}

		private void UCIzbornikNFBTNPostavke_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNPostavke;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			PrikaziIzbornik(6);
		}

		private void UCIzbornikNFBTNIzlaz_Click(object sender, EventArgs e)
		{
			OdabraniGumb = UCIzbornikNFBTNIzlaz;
			PromjeniPolozajIndikatora(OdabraniGumb);
			PromjeniBojeGumbovima(OdabraniGumb);
			FormaSIzbornicima.Close();
            Eventi.OnIzlaz();
		}

		private void UCIzbornik_SizeChanged(object sender, EventArgs e)
		{
			PromjeniPolozajIndikatora(OdabraniGumb);
		}
	}
}

// AKO SE KORISTI OVA METODA, USER CONTROLE NA FORMI NE TREBAJU IMATI INICIJALNO POSTAVLJENO 
// SVOJSTVO "Visible" NA "False"

//private void PrikaziIzbornik(int indexIzbornika)
//{
//	listaIzbornika[indexIzbornika].Show();
//	IEnumerable<int> exc = new List<int> { indexIzbornika };
//	foreach (var i in Enumerable.Range(0, listaIzbornika.Count).Except(exc))
//	{
//		listaIzbornika[i].Hide();
//	}
//}