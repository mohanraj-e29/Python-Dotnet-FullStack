using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionascending
{
    class asdeding
    {
        void asdinfo()
        {
            int temp = 0;
            int[] a = { 5, 4, 3, 6, 7, 9, 10, 1 };
            for (int i = 0; i <= a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                

                Console.WriteLine( ""+a[i] );
            }
        }
        public static void Main(string[] args)
        {
            asdeding emp = new asdeding();
            emp.asdinfo();
            Console.ReadLine();
        }
    }
}