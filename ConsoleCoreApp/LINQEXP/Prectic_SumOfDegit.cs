using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.LINQEXP
{
    internal class Prectic_SumOfDegit
    {
        public static int SumOfDegit(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;


            }
            return sum;

        }

        public static int Gum(int x ,int y)
        {
            //int sum = 0;

            /* while (number != 0)
             {
                 int digit = number % 10;
                 sum += digit;
                 number /= 10;


             }*/
           /* int x = 10;
            int y = 5;*/
            int Bum = x + y;

            return Bum;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no.");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int result = SumOfDegit(number);
                Console.WriteLine("result of SUM" + result);

            }
            else
            {
                Console.WriteLine("Invalid number please press right key");
            }

            //That is not user input

            /*   Console.WriteLine("Enter no");
               string input = Console.ReadLine();
               Console.WriteLine(SumOfDegit);

               int result = SumOfDegit(12345);
               Console.WriteLine(result);*/
            Console.WriteLine();
            Console.WriteLine("Sum of X and Y");
            
            int Bum = Gum(25, 25);
            Console.WriteLine(Bum);

        }

       

    }
}
