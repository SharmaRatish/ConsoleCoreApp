using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Arrays
{
    internal class ArrayTaskQ2
    {
        static void Main(string[] args)
        {
            //JaggedArray array declaruition

            int[][] jaggedArr = new int[4][];
            //int[][,] jaggedArr = new int[5][,];

            jaggedArr[0] = new int[4] { 4, 2, 7, 1 };
            jaggedArr[1] = new int[4] { 20, 70, 40, 90 };
            jaggedArr[2] = new int[3] { 1, 2, 0 };
            jaggedArr[3] = new int[3] { 7, 90, 2 };


            }
        private static void Returnvalue(int[] arr)
        {
            Console.WriteLine("Input Matrix Element Value");
          foreach (var row in arr)
            {

            }

        }
    }
    }
