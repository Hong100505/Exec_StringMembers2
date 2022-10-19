using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2將字串_Allen_Kuo轉成大寫_ALLEN_KUO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word1 = "Allen Kuo";
			string word2 = word1.ToUpper();
			Console.WriteLine(word2);
		}
	}
}
