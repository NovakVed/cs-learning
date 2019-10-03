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
	public partial class GlavniIzbornik_Profesor : Form
	{
		public GlavniIzbornik_Profesor(Korisnik prijavljeniKor)
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
				ucPregledTematskihCjelinaProfesor1,
				ucPregledIspitaProfesor1,
				ucPregledIzvjestajaProfesor1,
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
