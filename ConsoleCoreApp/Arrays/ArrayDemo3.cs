using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Arrays
{
    internal class ArrayDemo3
    {
        static void Main(string[] args)
        {
            Array cities=Array.CreateInstance(typeof(string), 5);  // 1-D Array

            Console.WriteLine(cities.Length);
            Console.WriteLine(cities.Rank);

            //cities[0]="patna";    invalid
            //console.writeline(cities[2]); invalid
            cities.SetValue("patna", 0);
            cities.SetValue("Noida", 1);
            cities.SetValue("Delhi", 2);
            cities.SetValue("Jhansi", 3);
            cities.SetValue("Gwalior", 4);
            //cities.SetValue("patna", 5);  // out of bound hai

            Console.WriteLine(cities.GetValue(2));
            Array.Sort(cities);

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }


        }
    }
}
