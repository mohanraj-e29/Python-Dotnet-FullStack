using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printsalary
{
    public class print
    {
        string name = "MOHANRAJ E";
        int age = 23;
        long phoneno = 6385554813;
        string address = "5-206,kulakkaraistreet,melsithamur,villupuram(dt),vallam,pin-604206";
        int salary = 50000;
        void outinfo()
        {
            Console.WriteLine("---DETAILS--");
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Age=" + age);
            Console.WriteLine("Phone Number=" +phoneno);
            Console.WriteLine("Address=" + address);

        }
        static void Main(string[] args)
        {
            print emp=new print();
            emp.outinfo();
            Console.WriteLine("Salary=" + emp.salary);
            Console.ReadLine();

        }
    }
}
