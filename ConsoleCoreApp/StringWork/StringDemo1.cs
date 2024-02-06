using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.StringWork
{
    internal class StringDemo1
    {
        static void Main(string[] args)
        {

            /*

            //CREATING ARRAY USING RANGE METHOD
            var arr = Enumerable.Range(20, 10); //  [20,29]
            foreach (var item in arr)

            {
                Console.WriteLine(item);
            }
            //Genrating Random number
            Random random = new Random(100000);
            int num = random.Next(5000);
            Console.WriteLine($"Random Value:{num}");

            */
            int[] arr = RandomArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
        }
        public static int[] RandomArray() 
        
        {
            int[] str = new int[5];
            Random random= new Random(10);
            bool flag = false;
            

            for (int i = 0; i < str.Length; i++)
            {
                
                {

                }
                
            }
            return str;
        }
    }
}

