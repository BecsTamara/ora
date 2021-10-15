using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
	public enum Irany
	{
		Vizszintes,
		Fuggoleges
	}

	public partial class Mutato : UserControl
	{


		Graphics _Graphics;

		public Color Szin { get; set; } = Color.Black;
		public Irany Irany { get; set; } = Irany.Vizszintes;
		public int Vastagsag { get; set; } = 10;
		public int Hossz { get; set; } = 150;

		public Mutato()
		{
			InitializeComponent();
		}

		private void Mutato_Paint(object sender, PaintEventArgs e)
		{
			this._Graphics = e.Graphics;
			Brush brush = new SolidBrush(this.Szin);
			Pen pen = new Pen(brush, Vastagsag);
			if (this.Irany == Irany.Vizszintes)
			{
				this.Width = this.Hossz;
				this.Height = this.Vastagsag;
			}
			else
			{
				this.Width = this.Vastagsag;
				this.Height = this.Hossz;
			}
			this._Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
		}
	}
}
