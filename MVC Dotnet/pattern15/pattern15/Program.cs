using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j<=5; j++)
                {
                    if(i==j)
                    {
                        Console.Write("*");
                        Console.WriteLine(); 
                    }
                    else
                    {
                        Console.Write("");
                        Console.WriteLine(); 
                    }
                    
                }
                
            }
            Console.ReadLine(); 
        }
        
    }
}
