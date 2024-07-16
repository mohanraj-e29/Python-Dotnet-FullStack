using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_empl_mangr
{
    public class employee
    {
        string name, adress;
        long phoneno;
        int age;
        public void empdet()
        {
            name = "Mohanraj E";
            age = 23;
            phoneno = 89562910;
            adress = "chennai";

        }
        public void print()
        {
            empdet();
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Age=" + age);
            Console.WriteLine("Phone Number=" + phoneno);
            Console.WriteLine("Address=" + adress);
        }

       class manager : employee
        {
            int salary1 = 25000;
         public int salary()
            {
                print();
                return salary1;

            }
        }
        public static void Main(string[] args)
        {
            manager emp = new manager();
            Console.WriteLine("salary=" + emp.salary());
            Console.ReadLine();

        }
    }
}
