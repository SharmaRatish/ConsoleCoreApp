using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.LINQEXP
{
    internal class LinqDemo1
    {
        static void Main(string[] args)
        {
            var number = new int[] { 10,17,8,123,4,64,22,33,13,4,64,};
            //Deferred Execution
            var evenNums = from num in number
                           where num % 2 == 0
                           select num;
            Console.WriteLine("Even Number Are:=>");

            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }

            //Immediate Execution
            var oddNums=number.Where((n)=> n % 2 != 0).ToArray();

            Console.WriteLine("Odd Number Are:=>");
            foreach (var item in oddNums)
            {
                Console.WriteLine(item);
            }

            ArrayList list=new ArrayList()
            {
                10,20,"Noida",25,40,"Patna","Mumbai","Delhi",28,50,60,"Bhopal"

            };
            var nums = list.OfType<int>();
            Console.WriteLine("numeric value From list:");
            foreach (var item in nums) 
            {
            Console.WriteLine(item);
            }

            //finding max element of each array of jagged type array and assigning  it to a new array
            int[][] arr = new int[3][]
                {
                new int[] { 1, 2, 3,4 },
                new int[] { 2, 4 },
                new int[] {9, 10, 11 }
                };
            //  var maxarr = arr.Select(v => v.Max()).ToArray();
            var sumarr = arr.Select(v => v.Sum()).ToArray();
            foreach (var item in sumarr)
            {
                Console.WriteLine(item);
            }


            IList<string> names = new List<string>() {
                    "Sunil Kumar",
                    "Manoj Kumar",
                    "Aman Yadav",
                    "Vikram Ashsih" ,
                    "Shaziya",
                    "Nisha Prasad"
 };
            var result = (from name in names
                         where name.EndsWith("Kumar")
                         orderby name ascending
                         select name).ToArray();
                 foreach (var item in result)
            { 
                Console.WriteLine(item);
            }
                 

        }

    }
}
