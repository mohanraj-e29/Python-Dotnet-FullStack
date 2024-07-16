using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i=i+2)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
