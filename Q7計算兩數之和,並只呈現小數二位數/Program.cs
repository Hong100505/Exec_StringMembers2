using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7計算兩數之和_並只呈現小數二位數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double d1 = 13.66;
			double d2 = 12.2292;
			double d3 = d1 + d2;
			string value2 = d3.ToString("#.##");
			Console.WriteLine(value2);
		}
	}
}
