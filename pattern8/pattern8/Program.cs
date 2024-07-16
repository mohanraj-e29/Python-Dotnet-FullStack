using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1||j == n||i == 1||i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.ReadLine();
            }
        }
    }
}