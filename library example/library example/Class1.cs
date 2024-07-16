using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace library_example
{
    public class Bank
    {
        public int balance = 34000;
        public int balinfo()
        {
            return balance;
        }
    public float interest(int p,int n)
    {
       float si,r=3.4F;
       si=p*n*r/100;
       return si;
     }
    public int deposit(int amt)
    {
       balance=balance+amt;
       return balance;
     }
  }
}