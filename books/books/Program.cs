using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    class book
    {
        int isbn;
        string bokn, autn, publ;
        void booksinfo()
        {
            Console.WriteLine("Enter the book name:");
            bokn = (Console.ReadLine());
            Console.WriteLine("Enter ISBN number:");
            isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the author name:");
            autn = (Console.ReadLine());
            Console.WriteLine("Enter the publisher name:");
            publ = (Console.ReadLine());
        }
        void printinfo()
        {
            Console.WriteLine("Book Name:"+bokn);
            Console.WriteLine("ISBN Number:"+isbn);
            Console.WriteLine("Author Name:"+autn);
            Console.WriteLine("Publisher:"+publ);

        }
        public static void Main(string[] args)
        {
            book emp = new book();
            emp.booksinfo();
            emp.printinfo();
            Console.ReadLine();
        }
    }
}
