using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callby_vale_callby_ref
{
    class Program
    {
        void info(int n)
        {
            n = n * n;
        }
        public void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("number=" + n);
            info(n);
            Console.WriteLine("after=" + n);
        }
    }
}
