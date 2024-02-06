using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsole = System.Console;


namespace ConsoleCoreApp.NameSpaceWork
{


    class Console
    {
        public static void Print(string[] str)
        {
            System.Console.WriteLine(str);
        }

    }







    internal class NameSpaceWork
    {
        static void Main(string[] args)
        {
            MyConsole.WriteLine("Hello from name space aliasing");
           // Console.Print(args);
        }
    }
}
