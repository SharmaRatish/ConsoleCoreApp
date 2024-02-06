using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.LINQEXP
{
    internal class Palindrome1
    {
        public static bool IsPalindrome(string input)
        {
            //Remove non alpha numeric character
          //  string CleanedInput = string.Concat(input.ToLower().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
           // string CleanedInput = string.Concat(input.ToLower());
             string CleanedInput = input.Trim();

            int left = 0;
            int right = CleanedInput.Length-1;
            while (left < right)
            {
            if (CleanedInput[left] != CleanedInput[right]) 
                {
                return false;
                }
                left++;
                right--;
            
            }
            
            return true;
        }

        public static void Main(string[] args) 
        {

            Console.WriteLine("Please enter any Key");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
            Console.WriteLine("it is a palindrom");
            
            }
            else 
            {
            Console.WriteLine("it is not a palindrom");
            
            }


        }


    }
}
