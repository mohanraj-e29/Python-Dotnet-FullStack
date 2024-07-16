using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "divisible by 2");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + "divisible by 3");
                }
                Console.ReadLine();
            }

        }
    }
}



