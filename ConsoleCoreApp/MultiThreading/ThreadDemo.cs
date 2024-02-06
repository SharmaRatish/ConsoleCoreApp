using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleCoreApp.MultiThreading
{
    internal class ThreadDemo
    {
        static void Main(string[] args)
        {
            Thread th=Thread.CurrentThread;
            th.Name = "Main Thread";
            Console.WriteLine($"Name:{th.Name}");
            Console.WriteLine($"IsAlive:{th.IsAlive}");
            Console.WriteLine($"IsBackGround:{th.IsBackground}");
            Console.WriteLine($"IsThreadPoolThread:{th.IsThreadPoolThread}");
            Console.WriteLine($"ThreadPriority:{th.Priority}");
            Console.WriteLine($"Thread State:{th.ThreadState}");

        }
    }
}
