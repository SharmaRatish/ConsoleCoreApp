using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.DelegateDemo
{



    //using Predefnd delegates
    internal class DelegateDemo2
    {
        static int Add(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {

            //Normal method
            Func<int, int, int> myfunc = Add;
                Console.WriteLine(myfunc(20,30));

            //Anonymous method
            Func<int, int, int, int> myfunc2 = delegate (int x, int y, int z) { return x * y * z; };
            Console.WriteLine(myfunc2(20,10,5));

            //Lembda Expression
            Func<int ,int>squreFun = (num) => { return num*num; };          //
            Console.WriteLine(squreFun(20));



            /*****************************************************************//*Predicate*//*******************************************************/

            //using predecate keyword
            /*
                        Predicate<string> checkString = (str) =>
                        {

                            if (str.EndsWith(".java"))
                                return true;
                            return false;
                        };
                        Console.WriteLine(checkString("hello.java"));
                        Console.WriteLine(checkString("Hello.C#"));



                        Func<int ,int ,int> myFunc3=(num1,num2)=> { return num1+num2; };
                        Console.WriteLine(myFunc3(40,30));

                        myFunc3 += (num1, num2) => { return num1 - num2; };

                        Console.WriteLine(myFunc3(50,20));
            */




            //using Action delegate

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            Action<int, int> myAction = (num1, num2) =>
            {
                Console.WriteLine($"{num1 + num2}");
            };

            myAction += (num1, num2) =>
            {
                Console.WriteLine($"{num1 - num2}");
            };

             myAction += (num1, num2) =>
            {
                Console.WriteLine($"{num1 * num2}");
            };
            myAction(40,20);
        }
    }
}
