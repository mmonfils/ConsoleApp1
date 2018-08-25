using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");
            Console.WriteLine("Hello from Jay!");

            //Testing
            Stopwatch myStopWatch = Stopwatch.StartNew();
            while (myStopWatch.Elapsed.Seconds < 5)
            {
                //This will break after 5 second
            }
		}
	}
}
