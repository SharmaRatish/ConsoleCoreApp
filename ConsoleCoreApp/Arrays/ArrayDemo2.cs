using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Arrays
{
    internal class ArrayDemo2
    {

        static void Main(string[] args)
        {
            //2-D Array
            //int[,] matrix = new int[3, 4];
            int[,] matrix = new int[3, 4] { {1, 2, 3, 4 }, {5, 6, 7, 8 }, {9, 10, 11, 12 }};
            //int[,] matrix = new int[4, 3] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 8 ,4 }, { 10, 11, 12 } };

            //AssigningMatrixData
             InputMatrixData(matrix);
            Display(matrix);
        }

        private static void InputMatrixData(int[,]arr)
        {
            Console.Write("Input Matrix Element Value");
            for (int r = 0; r < arr.GetUpperBound(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.WriteLine($"Enter row{r+1} and column {c+1}");
                }
            }

        }

        private static void Display(int[,] arr)
        {
            Console.WriteLine("matrix element are:");
            for (int r = 0; r <= arr.GetUpperBound(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.WriteLine(arr[r,c]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
