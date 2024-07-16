using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    interface rectangle
    {
        void rarea();
    }
    interface triangle
    {
        void tarea();
    }
    interface circle
    {
        void carea();
    }
    class maths:rectangle,triangle,circle
    {
        public void rarea()
        {
            double l=2,w=5,a;
            a=l*w;
            Console.WriteLine("Area of a rectangle="+a);
            double le=2,wi=5,p;
            p=(le+wi)*2;
            Console.WriteLine("Perimeter of a rectangle=" + p);
        }
        public void triangle
        {

        }
    }

        static void Main(string[] args)
        {
}
    

