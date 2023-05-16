using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello world!");
			for(int i = 0; i < 3; i++) 
			{ 
			Console.Write(".");
			Thread.Sleep(1000);
			}
			Console.WriteLine("Goodbye world!");
			Thread.Sleep(5000);
		}
	}
}
