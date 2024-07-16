using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionlargestprime
{
    class pnumber
    {
       
        void primeinfo()
        {
            int  max = 0;
            for (int i = 1; i <= 10; i++)
            {
                int c = 0;
                for (int j = 1; j <= i; j++)
                {
                    
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c==2)
                {
                    if(max<i)
                    {
                        max = i;
                    }
                }
                
            }
           Console.WriteLine("Largest Prime Number="+max);
        }
        static void Main(string[] args)
        {
            pnumber emp = new pnumber();
            emp.primeinfo();
            Console.ReadLine();

        }
    }
}
