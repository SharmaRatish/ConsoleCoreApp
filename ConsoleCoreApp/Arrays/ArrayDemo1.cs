using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ConsoleCoreApp.Arrays
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            //Creating 1-D array
         /*  int[]score=new int[5];
            Console.WriteLine( $"Length of Array:{score.Length}");
            Console.WriteLine($"Length of Array:{score.GetLength}");
            Console.WriteLine($"upper bound for D1:{score.GetUpperBound(0)}");
            Console.WriteLine($"Rank/Dimension of array:{score.Rank}");
         */


            int[] score = {1,2,3,4,5,6};
            //console.writeline($"Third value:{score[2]}");
            //score [3]=10;
            // Display(score);
            /* Console.WriteLine(score.Max());
             Console.WriteLine(score.Min());
             Console.WriteLine(score.Average());
             Console.WriteLine(score.Sum());
             Console.WriteLine(score.Count());*/
/*
            Array.Sort(score);
            Array.Reverse(score);
            Display(score);*/

           /* int result=TotalSum("102","Ratish",score);
            Console.WriteLine($"Total Sum:{result}");
            result= TotalSum("101","rohit",3,4);
            Console.WriteLine($"total Sum:{result}");*/



        }

        private static void Display(int[]score)
        {
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(score[i]);
            }
        }
        //method with variable b=number of argument/ params parameter
      /*  private static int TotalSum(string id,string name,params int[] arr)
        {
            int total = 0;
            foreach (var item in arr)
            {
            total=total+item;
            }
        }*/


    }

}
