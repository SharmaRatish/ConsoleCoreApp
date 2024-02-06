using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.MultiThreading
{
    class Test4
    {
        public void Print()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Running Thread:" + $"{Thread.CurrentThread.Name}\tValue of i:{i}");

                }
                //setting Rendom Value To GetRendom Property
                GetRandom = new Random().Next(0, 50);
                Monitor.Pulse(this);    //notify the thread that is wating queue
               // Monitor.PulseAll(this);
            }

        }
        public int GetRandom { get; set; }
    }
        internal class ThreadDemo5
     {
        static void Main(string[] args)
        {
            Test4 t4= new Test4();
            Thread th1 = new Thread(t4.Print);
            th1.Name= "Thread-1";
            th1.Start();
            Thread th2=Thread.CurrentThread;
            th2.Name = "Main Thread";
            lock (t4)
            {
                //any value with in givin 0
                Monitor.Wait(t4); // wait for resourse to be free 
                Console.WriteLine("in Main");
                for (int i = 0; i < t4.GetRandom; i++)
                {
                    Console.WriteLine($"Running Thread:{Thread.CurrentThread.Name}"+$"\tvalue  of i:{i}");


                }

            }

        }

    }
    
}
