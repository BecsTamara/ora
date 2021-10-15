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
	public partial class DigitDisplay : UserControl
	{

		readonly Dictionary<int, string> _szamok = new Dictionary<int, string>()
		{
			{0,"1111110" },
			{1,"0110000" },
			{2,"1101101" },
			{3,"1111001" },
			{4,"0110011" },
			{5,"1011011" },
			{6,"1011111" },
			{7,"1110000" },
			{8,"1111111" },
			{9,"1111011" }
		};

		readonly Dictionary<int, Mutato> _digits;

		public DigitDisplay()
		{
			InitializeComponent();
			this._digits = new Dictionary<int, Mutato>()
			{
				{0,M0 },
				{1,M1 },
				{2,M2 },
				{3,M3 },
				{4,M4 },
				{5,M5 },
				{6,M6 }
			};
		}

		public void SetDigits(int number)
		{
			for (int i = 0; i < 7; i++)
			{
				if (this._szamok[number][i] == '1')
				{
					this._digits[i].Visible = true;
				}
				else
				{
					this._digits[i].Visible = false;
				}
			}
		}
	}
}
