using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace DigitalClock
{


	class Program
	{
		const char FULLCHAR = (char)9608;
		const string NR0 = "1111110";
		const string NR1 = "0110000";
		const string NR2 = "1101101";
		const string NR3 = "1111001";
		const string NR4 = "0110011";
		const string NR5 = "1011011";
		const string NR6 = "1011111";
		const string NR7 = "1110000";
		const string NR8 = "1111111";
		const string NR9 = "1111011";
		static Dictionary<int, string> szamok = new Dictionary<int, string>()
		{
			{0,NR0 },
			{1,NR1 },
			{2,NR2 },
			{3,NR3 },
			{4,NR4 },
			{5,NR5 },
			{6,NR6 },
			{7,NR7 },
			{8,NR8 },
			{9,NR9 }
		};
		static void Main(string[] args)
		{
			Timer timer = new Timer(1000);
			timer.Elapsed += Timer_Elapsed;
			timer.Start();
			while (true)
			{
				System.Threading.Thread.Sleep(50);
			}
		}

		private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.SetCursorPosition(0, 10);
			Console.ForegroundColor = ConsoleColor.Red;
			DateTime tm = DateTime.Now;
			int min = tm.Minute;
			int hour = tm.Hour;
			string[] pos0, pos1, pos2, pos3;
			if (hour < 10)
			{
				pos0 = GenerateDigitalNumber(NR0);
				pos1 = GenerateDigitalNumber(szamok[hour]);
			}
			else
			{
				string hourStr = hour.ToString();
				int pos0I = int.Parse(hourStr[0].ToString());
				int pos1I = int.Parse(hourStr[1].ToString());
				pos0 = GenerateDigitalNumber(szamok[pos0I]);
				pos1 = GenerateDigitalNumber(szamok[pos1I]);
			}

			if (min < 10)
			{
				pos2 = GenerateDigitalNumber(NR0);
				pos3 = GenerateDigitalNumber(szamok[min]);
			}
			else
			{
				string minStr = min.ToString();
				int pos3I = int.Parse(minStr[0].ToString());
				int pos4I = int.Parse(minStr[1].ToString());
				pos2 = GenerateDigitalNumber(szamok[pos3I]);
				pos3 = GenerateDigitalNumber(szamok[pos4I]);
			}

			for (int i = 0; i < 11; i++)
			{
				string kiir = "  " + pos0[i];
				kiir += "    ";
				kiir += pos1[i];
				if ((i == 4 || i == 5 || i == 7 || i == 8) && tm.Second % 2 == 0)
				{
					kiir += $"   {FULLCHAR}{FULLCHAR}   ";
				}
				else
				{
					kiir += "        ";
				}
				kiir += pos2[i];
				kiir += "    ";
				kiir += pos3[i];
				Console.WriteLine(kiir);
			}
		}

		public static string[] GenerateDigitalNumber(string NR)
		{
			List<string> bl = new List<string>();
			if (NR[0] == '1')
			{
				bl.Add(GetHLine());
			}
			else
			{
				bl.Add("          ");
			}
			if (NR[1] == '1' && NR[5] == '1')
			{
				bl.AddRange(GetDoubleLine());
			}
			else if (NR[1] == '1' && NR[5] == '0')
			{
				bl.AddRange(GetVSecondLine());
			}
			else
			{
				bl.AddRange(GetVFirstLine());
			}
			if (NR[6] == '1')
			{
				bl.Add(GetHLine());
			}
			else
			{
				bl.Add("          ");
			}
			if (NR[2] == '1' && NR[4] == '1')
			{
				bl.AddRange(GetDoubleLine());
			}
			else if (NR[2] == '1' && NR[4] == '0')
			{
				bl.AddRange(GetVSecondLine());
			}
			else
			{
				bl.AddRange(GetVFirstLine());
			}
			if (NR[3] == '1')
			{
				bl.Add(GetHLine());
			}
			else
			{
				bl.Add("          ");
			}
			return bl.ToArray();
		}

		static string GetHLine()
		{
			string a = " ";
			for (int i = 0; i < 8; i++)
			{
				a += FULLCHAR;
			}
			a += " ";
			return a;
		}

		static string[] GetVFirstLine()
		{
			string[] a = new string[4];
			for (int i = 0; i < 4; i++)
			{
				a[i] = $"{FULLCHAR}         ";
			}
			return a;
		}
		static string[] GetVSecondLine()
		{
			string[] a = new string[4];
			for (int i = 0; i < 4; i++)
			{
				a[i] = $"         {FULLCHAR}";
			}
			return a;
		}

		static string[] GetDoubleLine()
		{
			string[] a = new string[4];
			for (int i = 0; i < 4; i++)
			{
				a[i] = $"{FULLCHAR}        {FULLCHAR}";
			}
			return a;
		}
	}
}
