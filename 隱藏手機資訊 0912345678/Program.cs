using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隱藏手機資訊_0912345678
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入手機號碼");
			string phoneNumber = Console.ReadLine();

			string newphoneNumber = phoneNumber.Substring(0, 4) + new string('*', 4) + phoneNumber.Substring(8);
			Console.WriteLine(newphoneNumber);
		}
	}
}
