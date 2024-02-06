using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.MultiThreading
{

    /***************************************//*PARALLEL PROGRAMING*//*********************************************/
    class Test3
    {
        public static void Print(object ob)
        {
            Console.WriteLine("\nRunning Thread:"+Thread.CurrentThread.Name+"\tPooled Thread:"+Thread.CurrentThread.IsThreadPoolThread);

        }

        public static void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                //normal thread creation
                Thread obj= new Thread(new ParameterizedThreadStart(Test3.Print));
                obj.Name = "th-" + i;
                obj.Start();
                //obj.Start("th-" + i);



            }
        }


        public static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                //creating and thread in thread pool 
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test3.Print));
            }

        } 
    }


    internal class ThreadDemo4
    {
        static void Main(string[] args)
        {
            Stopwatch watch=new Stopwatch();
            Console.WriteLine("\nNormal Thread Execution:");

            watch.Start();
            Test3.ProcessWithThreadMethod();
            watch.Stop();

            Console.WriteLine("Total Time Consumed:"+watch.ElapsedTicks);
            Console.WriteLine("Total Time Consumed:" + watch.ElapsedMilliseconds);

            Console.WriteLine("\nThread Pool Execution");
            watch.Start();
            Test3.ProcessWithThreadPoolMethod();
            watch.Stop();


            Console.WriteLine("Total Time Consumed:" + watch.ElapsedTicks);
            Console.WriteLine("Total Time Consumed:" + watch.ElapsedMilliseconds);
            Console.WriteLine("Main End");

        }
    }
}
