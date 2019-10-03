using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
	public class NoTabFocusButton : Button
	{
		protected override bool ShowFocusCues => false;
	}
}
