using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Arrays
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            /*  //JaggedArray array declaruition

              int[][]jaggedArr = new int[5][];
              //int[][,] jaggedArr = new int[5][,];

              jaggedArr[0] = new int[5] {1,2,3,4,5 };
              jaggedArr[1] = new int[4] { 1, 2, 3, 4};
              jaggedArr[2] = new int[3] { 1, 2, 3};
              jaggedArr[3] = new int[2] { 1, 2};
              jaggedArr[4] = new int[1] { 1,};
  */


            int[][] jaggedArr = new int[5][] { 
                new int[5] { 1, 2, 3, 4, 5 },
                new int[4] { 1, 2, 3, 4},
                new int[3] { 1, 2, 3},
                new int[2] { 1, 2},
                new int[1] { 1,}

        };

            // Console.WriteLine(jaggedArr.Length);
            //Console.WriteLine(jaggedArr[1].Length);
            Console.WriteLine("jagged elements is");
/*
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j]+"\t");
                }
                Console.WriteLine("\n");

            }*/
            
            foreach (var row in jaggedArr)
            {
                foreach (var item in row)
                {
                    Console.Write(item+"\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
