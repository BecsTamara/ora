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
	public partial class Form1 : Form
	{
		Timer t = new Timer();

		public Form1()
		{
			InitializeComponent();
			t.Tick += T_Tick;
			t.Interval = 1000;
			t.Start();
		}

		private void T_Tick(object sender, EventArgs e)
		{
			DateTime tm = DateTime.Now;
			if (tm.Hour < 10)
			{
				hour0.SetDigits(0);
				hour1.SetDigits(tm.Hour);
			}
			else
			{
				hour0.SetDigits(int.Parse(tm.Hour.ToString()[0].ToString()));
				hour1.SetDigits(int.Parse(tm.Hour.ToString()[1].ToString()));
			}
			if (tm.Minute < 10)
			{
				min0.SetDigits(0);
				min1.SetDigits(tm.Minute);
			}
			else
			{
				min0.SetDigits(int.Parse(tm.Minute.ToString()[0].ToString()));
				min1.SetDigits(int.Parse(tm.Minute.ToString()[1].ToString()));
			}
			if (tm.Second < 10)
			{
				sec0.SetDigits(0);
				sec1.SetDigits(tm.Second);
			}
			else
			{
				sec0.SetDigits(int.Parse(tm.Second.ToString()[0].ToString()));
				sec1.SetDigits(int.Parse(tm.Second.ToString()[1].ToString()));
			}
		}
	}
}
