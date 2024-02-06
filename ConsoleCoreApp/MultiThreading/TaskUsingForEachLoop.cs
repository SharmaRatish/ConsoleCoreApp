using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.MultiThreading
{
    internal class TaskUsingForEachLoop
    {
        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(10, 20).ToList();
            Console.WriteLine("Using ForEach:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Using Parallel ForEach:");
            Parallel.ForEach(list, (item) =>
            {
                Console.WriteLine(item);



            });
        }

    }
}
