using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for( int j=1;j<=i;j++)
                {
                    if(j%2==0)
                    {
                        Console.Write("B ");
                    }
                    else
                    {
                        Console.Write("A ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
