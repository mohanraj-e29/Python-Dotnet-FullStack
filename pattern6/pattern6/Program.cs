using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==i && j==5 && j==1 && j==5)
                    {
                        Console.WriteLine("* ");
                    }
                    if(i==j)
                    {
                        Console.WriteLine("* ");
                    }
                    if(i%2==0 && j%2==0)
                    {
                        Console.WriteLine("* ");
                    }
                }
            }
            
            Console.ReadLine();
        }
    }
}
