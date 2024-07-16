using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the percentage%=");
            int marks = int.Parse(Console.ReadLine());
            if(marks>=85)
            {
                Console.WriteLine("Grade=A");
            }
            else if (marks >= 75 && marks <85)
            {
                Console.WriteLine("Grade=B");
            }
            else if (marks >=65 && marks <75)
            {
                Console.WriteLine("Grade=C");
            }
            else if(marks <65)
            {
                Console.WriteLine("Grade=D");
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
            Console.ReadLine();
        }
    }
}
