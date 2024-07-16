using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionmaximum_of_n
{
    class maximum
    {
        int max=0;
        void maxinfo()
        {
            int[]a = { 99, 95, 93, 89, 87 };
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > max) 
               {
                  max = a[i];
                }
               
            }
            Console.WriteLine("Maximum number is=" + max);

        }
        public static void Main(string[] args)
        {
            maximum emp = new maximum();
            emp.maxinfo();
            Console.ReadLine();
        }
    }
}
