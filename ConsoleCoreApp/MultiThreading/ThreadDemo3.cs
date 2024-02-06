using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.MultiThreading
{
    internal class ThreadDemo3
    {
        private static void PrintSquare()
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine($"Executing Thread:{Thread.CurrentThread.Name}\t" + $"Square of{i} is {i * i}");
                Thread.Sleep(1000);
            }

        }

        private static void PrintCube(object obj)
        {
            var limit = Convert.ToInt32(obj);
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine($"Executing Thread:{Thread.CurrentThread.Name}\t" + $"cube of{i} is {i * i * i}");
                Thread.Sleep(50);
            }


        }


        static void Main(string[] args)
        {
            //creating thread using threadStart delegate

            Thread th1 = new Thread(new ThreadStart(PrintSquare));
            th1.Name = "th-1";
            th1.Priority = ThreadPriority.Lowest;
            th1.Start();

            Thread th2 = new Thread(new ThreadStart(PrintSquare));
            th2.Name = "th-2";
            th2.Priority = ThreadPriority.Highest;
            th2.Start();

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
