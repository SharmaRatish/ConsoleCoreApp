using System;

namespace ConsoleCoreApp.LINQEXP
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase");
            string input = Console.ReadLine();
            if (IsPalindrome(input))
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }

        private static bool IsPalindrome(string input)
        {
            // Remove any non-alphanumeric characters and convert to lowercase
            string cleanedInput = string.Concat(input.ToLower().Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

            int left = 0;
            int right = cleanedInput.Length - 1;

            while (left < right)
            {
                if (cleanedInput[left] != cleanedInput[right])
                {
                    return false; 
                }

                left++;
                right--;
            }

            return true;
        }

        
    }
}
