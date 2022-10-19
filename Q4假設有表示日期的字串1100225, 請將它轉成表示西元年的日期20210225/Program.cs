using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4假設有表示日期的字串1100225__請將它轉成表示西元年的日期20210225
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = "1100225";
			string value1 = word.Substring(0, 3);
			int value2 = Convert.ToInt32(value1);
			value2 += 1911;
			string newWord = value2.ToString() + word.Substring(3);
			Console.WriteLine(newWord);
		}
	}
}
