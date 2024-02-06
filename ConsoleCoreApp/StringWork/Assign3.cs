using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.StringWork
{
    internal class Assign3
    {
        public static void PrintPattern() 
        {
            Console.WriteLine("please input A string");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(str[i]);
                }
                else
                {
                    for (int j = 1; j < str[i]; j++)
                    {
                        Console.WriteLine(str[i-1]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Answer:{PrintPattern}");
        }
    }

   
}
