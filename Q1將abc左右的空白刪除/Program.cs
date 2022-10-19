using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1將abc左右的空白刪除
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word1 = " abc ";
			string word2 = word1.Trim();
			Console.WriteLine(word2);
		}
	}
}
