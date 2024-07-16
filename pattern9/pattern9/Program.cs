using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int j=n;j>=i;j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
