using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerfactlargest
{
    public class calculator
    {
        int bnum, pnum, lar,lar1,fact;
        int f = 1;
        void powinfo()
        {
            Console.WriteLine("Enter The base number:");
            bnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power value:");
            pnum = int.Parse(Console.ReadLine());
            int t = 1;
            for(int i=0;i<=pnum;i++)
            {
                t = t * bnum;
            }
            Console.WriteLine("Power Value=" + t);
        }
       public void fatinfo()
        {
            Console.WriteLine("Enter the Facorial Number:");
            fact = int.Parse(Console.ReadLine());
            for (int i = fact; i >= 1; i--)
            {
                f = f * i;
           }
            Console.WriteLine("Factorial=" + f);
        }
      public void larginfo()
        {
            Console.WriteLine("enter the First value:");
            lar = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Second value:");
            lar1 = int.Parse(Console.ReadLine());
            if(lar>lar1)
            {
                Console.WriteLine("Largest Value=" + lar);
            }
            else
            {
                Console.WriteLine("Largest Value=" + lar1);
            }
        }
        static void Main(string[] args)
        {
            calculator emp = new calculator();
            emp.powinfo();
            emp.fatinfo();
            emp.larginfo();
            Console.ReadLine();

        }
    }
}
