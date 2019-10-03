using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
	public class EventArgsKorisnik : EventArgs
	{
		public EventArgsKorisnik(Korisnik prijavljeniKor)
		{
			PrijavljeniKorisnik = prijavljeniKor;
		}

		private Korisnik prijavljeniKorisnik = null;

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
