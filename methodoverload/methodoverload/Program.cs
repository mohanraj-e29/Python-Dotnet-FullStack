using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverload
{
    class subject
    {
        static void total(int a,int b)
    {
        Console.WriteLine("Pass="+a+","+b);  
    }
        static void total(int a, int b,int c)
        {
            Console.WriteLine("Pass=" + a+","+b+","+c);
        }
        static void total(double a, double b)
        {
            Console.WriteLine("Pass=" + a+","+b);
        }
        static void Main(string[] args)
        {
            total(60, 70);
            total(70,60,45);
            total(69.7,91.3);
            Console.ReadLine();
        }
    }
}
