using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6比對使用者輸入值是否為_Allen__區分大小寫
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入Allen");
			string input2 = Console.ReadLine();
			string answer2 = "Allen";

			if (answer2.Substring(0, 1) == input2.Substring(0, 1))
			{
				if (answer2.Substring(1) == input2.Substring(1))
				{
					Console.WriteLine("跟答案相同");

				}
				else
				{
					Console.WriteLine("跟答案不同");
				}
			}
			else
			{
				Console.WriteLine("跟答案不同");
			}
		}
	}
}
