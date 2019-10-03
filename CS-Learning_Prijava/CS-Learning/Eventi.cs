using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Learning
{
    public class Eventi
    {
        public static event EventHandler ZaboravljenaLozinka;
        public static event EventHandler RegistrirajSe;
        public static event EventHandler NatragNaPrijavu;
        public static event EventHandler UspjesnaPrijava;

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

        public static void OnUspjesnaPrijava()
        {
            UspjesnaPrijava?.Invoke(null, null);
        }
    }
}
