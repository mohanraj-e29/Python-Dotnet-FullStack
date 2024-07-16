using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("enter the unit:");
            int unit = int.Parse(Console.ReadLine());
            if(unit <=100)
            {
                Console.WriteLine("Normal charges per unit=0");
                Console.WriteLine("No extra charges per unit");
            }
            else if(unit>=10 && unit<=250)
             {
                Console.WriteLine("Normal charges per unit=2");
                Console.WriteLine("Extra charges per unit=25");
              }
            else if(unit>=251 && unit<=450)
              {
                Console.WriteLine("Normal charges per unit=4");
                Console.WriteLine("Extra charges per unit=75");
              }
            else if(unit >450)
             {
                Console.WriteLine("Normal charges per unit=6");
                Console.WriteLine("Extra charges per unit=100");
             }
            else
            {
                 Console.WriteLine("Invalid Units");
            }

               Console.ReadLine();              
        }

        }
    }

