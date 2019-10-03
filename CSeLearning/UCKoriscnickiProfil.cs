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
	public partial class UCKoriscnickiProfil : UserControl
	{
		/* TODO: NAKON PRIJAVE, AKO JEKORISNIK PROFESOR MORA SE ISPISATI TEKST DA JE KORISNIK PROFESOR U
		 * ODGOVARAJUCOJ BOJI; ILI DA JE STUDENT U ODGOVARAJUCOJ BOJI */

		/* TODO: NAKON PRIJAVE, PRIKAZATI KORISNIKOVE PODATKE O PROFILU */


		public UCKoriscnickiProfil()
		{
			InitializeComponent();
		}

		private void UCFrmKoriscnickiProfil_Load(object sender, EventArgs e)
		{
			// Ucitati potrebne podatke iz baze podataka
		}

		private void TBOXOpisProfila_Leave(object sender, EventArgs e)
		{
			// POSPREMI PROMJENE U BAZU PODATAKA
		}
	}
}
