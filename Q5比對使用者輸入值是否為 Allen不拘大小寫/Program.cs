using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5比對使用者輸入值是否為_Allen不拘大小寫
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入Allen");
			string input = Console.ReadLine();
			string answer = "Allen";

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
			}
			if (answer.ToLower() == input.ToLower())
			{
				Console.WriteLine("相同");
			}
			else
			{
				Console.WriteLine("不同");
			}
		}
	}
}
