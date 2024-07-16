using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
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
            Console.WriteLine("_____________________________________________________________");

        }
        public void tarea()
        {
            double b=10,h=5,ar;
            ar=1/2*b*h;
            Console.WriteLine("Area of a triangle="+ar);
            double an=2,bn=5,cn=6,pe;
            pe=an+bn+cn;
            Console.WriteLine("Perimeter of a triangle="+pe);
            Console.WriteLine("_____________________________________________________________");
        }
        public void carea()
        {
            double rad=2.5,area;
            area=3.14*rad*rad;
            Console.WriteLine("Area of a circle="+area);
            double rg=5,peri;
            peri=2*3.14*rg;
            Console.WriteLine("Perimeter of a circle="+peri);
            
        }
    
        static void Main(string[] args)
        {
            maths sp = new maths();
            sp.rarea();
            sp.tarea();
            sp.carea();
            Console.ReadLine();

        }
    }
}
