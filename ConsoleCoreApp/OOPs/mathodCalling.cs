using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPs
{
    internal class MethodCalling
    {

        //method for coll by value
        public void CallByValue(int x,int y)
        {

            x = x + 20;
            y = y + 30;
            Console.WriteLine($"x:{x}\ty:{y}");

        }

        //method for call by refrence behaviour by a ref keyword
        public void CallByRef(ref int x, ref int y)
        {

            x = x + 20;
            y = y + 30;
            Console.WriteLine($"x:{x}\ty:{y}");

        }

        //method for call by refrence behaviour using out keyword 

        public void CallByOutput( int x, int y,out int s,out int m,out int d)
        {

            s = x + y;
            m = x * y;
            d = x / y;

        }

        public void CallByNameOptinal(int id,string fname="Guest",string surname="",float salary=25000)
        {
            Console.WriteLine($"welcome:{fname}{surname}");
            Console.WriteLine($"ID:{id}\t Salary:{salary}");
        }


    }
}
