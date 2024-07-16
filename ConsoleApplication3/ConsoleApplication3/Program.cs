using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=50; i++)
                {
                    if (i%3 == 0)
                    {
                        Console.WriteLine(i + "Angry");
                    }
                    if (i%5 == 0)
                    {
                        Console.WriteLine(i + "Bird");
                    }
                    if (i % 3 == 0 &&  i% 5 == 0)
                    {
                        Console.WriteLine(i + " Angry Bird");
                    }
                    else
                    {
                        Console.WriteLine(i);      
                    }
            }
                    Console.ReadLine();
                

            }
        }

    }
