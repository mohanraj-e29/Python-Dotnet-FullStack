using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number=");
            int i = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();       
        }

    }
}
