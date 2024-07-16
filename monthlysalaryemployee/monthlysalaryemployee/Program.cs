using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthlysalaryemployee
{
    public abstract class permanent
    {
    public abstract void getinfo();      
    }
    class part:permanent
    {
        public double asalary = 300000, msalary = 25000;
        public string name = "dheena";
        public double asalary1 = 190000, msalary2 = 15800;
        public string name1 = "veera";
     public override void getinfo()
        {
            Console.WriteLine("----FULL TIME EMPLOYEE----");
            Console.WriteLine("Employee name=" + name);
            Console.WriteLine("Monthly salary for full time employee=" + msalary);
            Console.WriteLine("Annual salary for full time employee=" + asalary);
            Console.WriteLine("----PART TIME EMPLOYEE----");
            Console.WriteLine("Employee name=" + name1);
            Console.WriteLine("Monthly salary for part  time employee=" + msalary2);
            Console.WriteLine("Annual salary for part  time employee=" + asalary1);
        }
    }
        class program{
        static void Main(string[] args)
        {
            part sd = new part();
            sd.getinfo();
            Console.ReadLine();
        }
    }
}
