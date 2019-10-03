using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    public class Eventi
    {
        public static event EventHandler ZaboravljenaLozinka;
        public static event EventHandler RegistrirajSe;
        public static event EventHandler NatragNaPrijavu;
        public static event EventHandler<EventArgsKorisnik> UspjesnaPrijavaStudent;
        public static event EventHandler<EventArgsKorisnik> UspjesnaPrijavaProfesor;
        public static event EventHandler Izlaz;

        public static void OnZaboravljenaLozinka()
        {
            ZaboravljenaLozinka?.Invoke(null, null);
        }

        public static void OnRegistrirajSe()
        {
            RegistrirajSe?.Invoke(null, null);
        }

        public static void OnNatragNaPrijavu()
        {
            NatragNaPrijavu?.Invoke(null, null);
        }

        public static void OnUspjesnaPrijavaStudent(Korisnik prijavljeniKor)
        {
            UspjesnaPrijavaStudent?.Invoke(null, new EventArgsKorisnik(prijavljeniKor));
        }

        public static void OnUspjesnaPrijavaProfesor(Korisnik prijavljeniKor)
        {
            UspjesnaPrijavaProfesor?.Invoke(null, new EventArgsKorisnik(prijavljeniKor));
        }

        public static void OnIzlaz()
        {
            Izlaz?.Invoke(null, null);
        }
    }
}
