using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3將字串_aLLeN_kUO_轉換成_Allen_Kuo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word1 = "aLLeN kUO";
			string wordlow = word1.ToLower();
			string word2 = word1.Substring(0, 1);
			word2 = word2.ToUpper();
			string word3 = word1.Substring(6, 1);
			word3 = word3.ToUpper();

			string word4 = wordlow.Substring(1, 5);
			string word5 = wordlow.Substring(7, 2);

			string message = $"{word2}{word4}{word3}{word5}";
			Console.WriteLine(message);
		}
	}
}
