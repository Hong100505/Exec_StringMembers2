using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1將" abc " 左右的空白刪除
			string word1 = " abc ";
			string word2 = word1.Trim();
			Console.WriteLine(word2);

			//Q2將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"

			string word3 = "Allen Kuo";
			string word4 = word3.ToUpper();
			Console.WriteLine(word4);

			//Q3將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			string word5 = "aLLeN kUO";
			string wordlow =word5.ToLower();
			string word6 = word5.Substring(0,1);
			word6 = word6.ToUpper();
			string word7 = word5.Substring(6,1);
			word7 = word7.ToUpper();

			string word8 = wordlow.Substring(1, 5);
			string word9 = wordlow.Substring(7, 2);

			string message = $"{word6}{word8}{word7}{word9}";
			Console.WriteLine(message);

			//Q4假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"

			string word = "1100225";
			string value1 = word.Substring(0,3);
			int  value3 = Convert.ToInt32(value1);
			value3 += 1911;
			string newWord =value3.ToString() + word.Substring(3);
			Console.WriteLine(newWord);




			//Q5比對使用者輸入值是否為 "Allen" 不拘大小寫
			Console.WriteLine("請輸入Allen");
			string input = Console.ReadLine();
			string answer = "Allen";

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
			}
			if (answer.ToLower() == input.ToLower())
			{
				Console.WriteLine("輸入值為allen");
			}
			else
			{
				Console.WriteLine("輸入值不是allen");
			}

			//Q6比對使用者輸入值是否為 "Allen", 區分大小寫
			Console.WriteLine("請輸入Allen");
			string input2 = Console.ReadLine();
			string answer2 = "Allen";

			if(answer2.Substring(0,1) == input2.Substring(0,1))
			{
				if(answer2.Substring(1) == input2.Substring(1))
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

			//Q7計算兩數之和,並只呈現小數二位數

			double d1 = 13.66;
			double d2 = 12.2292;
			double d3 = d1 + d2;
			string value2 = d3.ToString("#.##");
			Console.WriteLine(value2);

			//隱藏手機資訊 0912345678 => 0912****78
			Console.WriteLine("輸入手機號碼");
			string phoneNumber = Console.ReadLine();

			string newphoneNumber = phoneNumber.Substring(0,4) + new string('*',4) + phoneNumber.Substring(8);
			Console.WriteLine(newphoneNumber);

		}
	}
}
