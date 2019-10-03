using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace UserControls
{
	public class RoundPictureBox : PictureBox 
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath g = new GraphicsPath();
			g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			this.Region = new System.Drawing.Region(g);
			base.OnPaint(pe);
			g.Dispose();
		}

	}
}
