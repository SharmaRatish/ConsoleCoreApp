using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.DelegateDemo
{
    //public delegate  void MyDelegate(int x, int y);  //will work as multi cast

   // public delegate int MyDelegate(int x, int y);  //single cast delegates
   // public delegate void MyDel();
    public delegate int MyDel(int x ,int y);

    class Test1
    {
        // public void Add(int a, int b) 
        public int Add(int a, int b)
        {
           // Console.WriteLine($"Sum of{a} And {b} is {a + b}");
           return a + b;
        }
        public int Subtract(int a, int b)
        {
            // Console.WriteLine($"Substraion of{a} And {b} is {a - b}");
            return a - b;
        }
    }
    class Test2
    {
        public int Multiply(int a, int b)
        {
            //Console.WriteLine($"Multiply of{a} And {b} is {a * b}");
            return a * b;
        }

        public int Devide(int a, int b)
        {
            //Console.WriteLine($"Devide of{a} And {b} is {a / b}");

            return a / b;
        }
    }

    

    internal class DelegateDemo1
    {
        static void Main(string[] args)
            
        {
            /*
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();

            //Delegate Instantiation

            MyDelegate myDelegate = new MyDelegate(test1.Add);

            myDelegate += test1.Subtract;
            myDelegate += test2.Multiply;
            myDelegate += test2.Devide;

           // myDelegate(100, 40);

            //Invocation

            int result = myDelegate(100, 40);
            Console.WriteLine($"Result:{result}");
            myDelegate -= test2.Devide;
            result = myDelegate(10, 40);
            Console.WriteLine($"Result:{result}"); //4000

            Console.WriteLine($"Result:{myDelegate(10,40)}");
            */


            /*  MyDel myDel = delegate ()
              {
                  Console.WriteLine("this is anonymous method block");
              };
              myDel();*/
            /*
                        MyDel myDel = delegate (int a, int b)
                        {
                            Console.WriteLine("this is anonymous method block");
                            return a * b;
                        };
                        int res = myDel(30, 20);
                        Console.WriteLine($"Result:{res}");

                        myDel += delegate (int x, int y)
                        {
                            Console.WriteLine("this is anonymous method-2 block");
                            return x + y;
                        };
                        myDel(40,20);
                        Console.WriteLine($"Result:{res}");
            */

            MyDel myDel = (int x, int y) => { return x * y; };
            int res = myDel(20, 10);
            Console.WriteLine(res);

            MyDel myDel1 = (a, b) => { return a + b; };
           // var result 20,30;
            Console.WriteLine(myDel1(20,40));






        }

    }
}
