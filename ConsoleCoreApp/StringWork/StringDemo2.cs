using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleCoreApp.StringWork
{
    internal class StringDemo2
    {
        static void Main(string[] args)
        {
            string str = "abcd123ef85g45hijk8566klm235nopq7546rs81tu12v36w65x78yz";

            bool result=Regex.IsMatch(str,"\\d");   //[0-9]
            Console.WriteLine(result);

            result = Regex.IsMatch(str, @"\d{4}");
            Console.WriteLine(result);
            //  Console.WriteLine(str);
            Console.WriteLine("----------------------------------------------------");
            if (result )
            {
                Match match = Regex.Match(str, @"\d{2,}");
                Console.WriteLine(match.Success);
                Console.WriteLine(match.Name); 
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Length);
                match=match.NextMatch();
                Console.WriteLine("_________________________________________");
                Console.WriteLine(match.Name);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Length);


            }
            MatchCollection matches = Regex.Matches(str, @"\d[1-9]{1,}");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value+":"+match.Length);
            }

            Console.WriteLine("____________________________________________________");
            //string[] data = Regex.Split();

        }
    }
}
