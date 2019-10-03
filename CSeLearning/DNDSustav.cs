using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public class DNDSustav
    {
        private List<UserControl> kontrole;

        public DNDSustav()
        {
            kontrole = new List<UserControl>();

            /*
                Ovo je privremena implementacija. Služi isključivo za prototipiranje. 
                U daljnjem razvoju potrebno je zaista riješiti problem, ne ga samo sakriti.

                Prilikom izrade vlastitih UserControla za stvaranje sadržaja obvezno je postaviti
                visinu kontrole na 150. [Konkretnije bitno je da su sve UserControle iste visine.]
             */
            UCDodajSliku u1 = new UCDodajSliku();
            UCDodajSliku u2 = new UCDodajSliku();
            UCDodajSliku u3 = new UCDodajSliku();
            UCDodajSliku u4 = new UCDodajSliku();
            UCDodajSliku u5 = new UCDodajSliku();
            u1.Hide();
            u2.Hide();
            u3.Hide();
            u4.Hide();
            u5.Hide();
            kontrole.Add(u1);
            kontrole.Add(u2);
            kontrole.Add(u3);
            kontrole.Add(u4);
            kontrole.Add(u5);
        }

        public void DodajKontrolu(UserControl novaKontrola, int pozicijaKursora)
        {
            kontrole.Insert(OdaberiLokaciju(pozicijaKursora), novaKontrola);
        }

        private int OdaberiLokaciju(int pozicijaKursora)
        {
            int index = 0;
            foreach (UserControl kontrola in kontrole)
            {
                if (pozicijaKursora > kontrola.Size.Height * kontrole.IndexOf(kontrola))
                {
                    index++;
                }
                else if (pozicijaKursora < kontrola.Size.Height * kontrole.IndexOf(kontrola))
                {
                    break;
                }
            }
            return index;
        }

        public List<UserControl> DohvatiKontrole()
        {
            return kontrole;
        }
    }
}
