using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringexp
{
    class Program
    {
        static void Main(string[] args)
        {
            String teststring = ("STRING CONVERSION");
            String result;
            result = teststring.ToLower();
            Console.WriteLine("" + result);
            result = teststring.ToUpper();
            Console.WriteLine("" + result);
            Console.ReadLine();
        }
    }
}
