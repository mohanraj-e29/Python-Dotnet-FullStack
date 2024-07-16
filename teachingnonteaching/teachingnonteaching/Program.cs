using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachingnonteaching
{
    public class teaching
    {
        double bsal = 10000, hra = 10000, ta = 5000, pf = 2000,gsal;
        public virtual void staff()
        {
            Console.WriteLine("---Teaching Gsal---");
            Console.WriteLine("Salary=" +( gsal = (bsal + hra + ta) - pf));
            Console.WriteLine("---Non teaching Gsal---");
            Console.WriteLine("Salary=" + (gsal= bsal));
        }
        class nonteaching:teaching
        {
            public override void staff()
            {
               
            }
        }
        static void Main(string[] args)
        {
            teaching te = new teaching();
            te.staff();
            Console.ReadLine();
        }


    }
}
