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
	public partial class GlavniIzbornik_Student : Form
	{
		public GlavniIzbornik_Student(Korisnik prijavljeniKor)
		{
			InitializeComponent();
			PrijavljeniKorisnik = prijavljeniKor;
		}

		private void ucIzbornik1_Load(object sender, EventArgs e)
		{
			List<UserControl> izbornici = new List<UserControl>
			{
				ucKoriscnickiProfil1,
				ucPocetnaStranica1,
				ucPregledTematskihCjelinaStudent1,
				ucPregledIspitaStudent1,
				ucPregledIzvjestajaStudent1,
				ucTrgovina1,
				ucPostavke1
			};
			ucIzbornik1.UcitajIzbornikeSForme(izbornici, this);
		}

		private Korisnik prijavljeniKorisnik;

		public Korisnik PrijavljeniKorisnik
		{
			get
			{
				return prijavljeniKorisnik;
			}
			set
			{
				prijavljeniKorisnik = value;
			}
		}
	}
}
