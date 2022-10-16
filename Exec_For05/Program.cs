using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_For05
			//用迴圈呈現指定右側的結果
			int i, j;       
			for (i = 1; i <= 5; i++)
			{
				int countOfPlus = 5 - i;
				
				string plus = new string('+', countOfPlus);
				Console.Write(plus);
				
				for (j = 1; j <= i; j++)
				{
					int countOfNumber = i;
					string number = i.ToString();
					Console.Write(number);
				}
				Console.WriteLine();
			}

			/*
			 * 4 1
			 * 3 2 
			 * 2 1 
			 * 1 4
			 * 0 4	
			 * */
		}
	}
}
