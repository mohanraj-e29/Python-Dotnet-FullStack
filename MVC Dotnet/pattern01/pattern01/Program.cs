using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern01
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i<=j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                       
                    } 
                    
                }
                Console.WriteLine(""); 
               
           
            }
            
            Console.ReadLine();
            
        }
    }
}
