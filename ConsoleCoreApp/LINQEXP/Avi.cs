using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleCoreApp.LINQEXP
{
    internal class Avi
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)        //i=1
                                                //j=1
            {

                //Console.WriteLine("*");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            PETTRN();
        }

        public static void PETTRN()
        {
            for (int i = 1; i <= 4; i++)
            {

                for(int j = 4;j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            int a = 5;
            for (int i = 0; i <= a; i++)
            {

                for (int j = 2 * (a-i); j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }


    }







































//    // int rows = 5;

//            for (int i = 0; i< 5; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//Console.WriteLine();
            
}

