using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            for(int i=1;i<=4;i++)
            {
              for(int j=1;j<=i;j++)
              {
                  Console.Write("" + c++);
                  

              }
              Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
