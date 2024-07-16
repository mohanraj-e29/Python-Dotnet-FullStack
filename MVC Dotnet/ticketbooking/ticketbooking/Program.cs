using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic

namespace ticketbooking
{
    public class passanger
    {
        static int id = 1;
        string name;
        int age;
        string berthpreference;
        int passangerid;
        string allotted;
        int number;
    public passanger (string name,int age,string berthpreference)
        {
            this.name = name;
            this.age = age;
            this.berthpreference = berthpreference;
            this.passangerid = id++;
            allotted = "";
            number = -1;
        }
    public class ticketbokker
    {
        //63 berths(upper,lower,middle)+(18 RAC passangers)
        //10 waiting list tickets 21 l, 21 m, 21u, 18rac,10wl
        static int avilablelowerberths=21;
        static int avilablelowerberths = 21;
        static int avilablelowerberths = 21;
        static int avilablelowerberths = 18;
        static int avilablelowerberths = 10;

        static Queue<int> waitinglist=new LinkedList<>(); //queue for wl passangers
        static Queue<int> raclist=new LinkedList<>(); //queue for wl passangers
        static List<int> bookticketoflist=new ArrayList<>(); //queue for wl passangers
    }
        static void Main(string[] args)
        {
        }
    }
}
