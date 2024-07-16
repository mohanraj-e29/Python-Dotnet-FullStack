using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class bank
    {
        int amt = 2400;
        int acno, dep, wit;
        string fnam, lnam;
        void customerinfo()
        {
            Console.WriteLine("Enter the Account Number:");
            acno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First Name:");
            fnam = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            lnam = Console.ReadLine();

        }
        public void depinfo()
        {
            Console.WriteLine("Enter the Deposit Amount:");
            dep= int.Parse(Console.ReadLine());
            amt= amt + dep;
            Console.WriteLine("Balance=" +amt);
        }
        public void witinfo()
        {
            Console.WriteLine("Account Number:" + acno);
            Console.WriteLine("First Name:" + fnam);
            Console.WriteLine("Last Name:" + lnam);
            Console.WriteLine("Enter the Withdraw Amount:");
            wit = int.Parse(Console.ReadLine());
            amt = amt - wit;
            Console.WriteLine("balance=" +amt);
        }
        
      public  static void Main(string[] args)
        {
            bank emp = new bank();
            emp.customerinfo();
            emp.depinfo();
            emp.witinfo();
            
            Console.ReadLine();
           
        }
    }
}
