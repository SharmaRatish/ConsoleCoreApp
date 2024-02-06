using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.MultiThreading
{
    internal class TaskUsingParallalForLoop
    {

        
        
            static void Main(string[] args)
            {
                DateTime sTime = DateTime.Now;
                Console.WriteLine($"Parallel For loop Execution started at: {sTime.ToLongTimeString()}");
/*
            Parallel.For(0, 10, i =>
            {
                long sum = DoTask();
                Console.WriteLine($"{i}=>{sum}");
            });*/
                var option = new ParallelOptions 
                { 
                    MaxDegreeOfParallelism = 5
                };
            Parallel.For(0, 10,option, i =>
            {
                long sum = DoTask();
                Console.WriteLine($"{i}=>{sum}");
            });


            DateTime eTime = DateTime.Now;
                Console.WriteLine($"For Loop Execution Started at : {eTime.ToLongTimeString()}");
                TimeSpan span = eTime - sTime;
                int msecond = Convert.ToInt32(span.TotalMilliseconds);
                Console.WriteLine($"Total Execution time:{msecond}");


            }
            static long DoTask()
            {
                long sum = 0;

                for (int i = 0; i < 100000000; i++)
                {
                    sum = sum + i;
                }

                return sum;
            }

        }

    }
