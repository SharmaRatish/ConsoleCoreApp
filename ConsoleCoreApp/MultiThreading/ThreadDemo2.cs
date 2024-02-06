using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ConsoleCoreApp.MultiThreading
{
    internal class ThreadDemo2
    {
        //syncronious non-static block
        private  void PrintSquare() 
        {
            lock (this)
            {
                for (int i = 0; i <=10; i++)
                {
                    Console.WriteLine($"Executing Thread:{Thread.CurrentThread.Name}\t" + $"Square of{i} is {i * i}");
                    Thread.Sleep(1000);
                }
            }
        }
        //Syncronizing Static Block
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void PrintCube(object obj)
        {
            var limit=Convert.ToInt32(obj);
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine($"Executing Thread:{Thread.CurrentThread.Name}\t" + $"cube of{i} is {i * i * i}");
                Thread.Sleep(50);
            }


        }


        static void Main(string[] args)
        {
            //creating thread using threadStart delegate

            ThreadDemo2 obj=new ThreadDemo2();
            Thread th1= new Thread(new ThreadStart (obj.PrintSquare));
            th1.Name = "th-1";
            th1.Priority=ThreadPriority.Lowest; 
            th1.Start();

            Thread th2 = new Thread(new ThreadStart(obj.PrintSquare));
            th2.Name = "th-2";
            th2.Priority = ThreadPriority.Highest;
            th2.Start();

            //Creating Thread  using  Parametrized thread delegate 

            Thread th3 = new Thread(new ParameterizedThreadStart(PrintCube));
            th3.Name = "th-3";
            th3.Start(10);
            Thread th4 = new Thread(PrintCube);
            th4.Name = "th-4";
            th4.Start(5);

            Console.WriteLine("main end");
        }

    }
}
