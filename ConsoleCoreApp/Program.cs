using ConsoleCoreApp.OOPs;
using System.ComponentModel;
using System.Data;
using System.Security.Claims;

// See https://aka.ms/new-console-template for more information

namespace ConsoleCoreApp
{

    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //int x = 20;
            //Console.WriteLine($"Value of x:{x}");
            //ConsoleCoreApp.Day4.Test.Main();
            //Test.Main();
            //int i = 5;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("press any key");
            ////ConsoleKeyInfo ck= Console.ReadKey();
            //ConsoleKeyInfo ck = Console.ReadKey(true);
            //Console.Write("*");
            ////ck.Key => ConsoleKey
            ////ck.key=>char
            //Console.WriteLine($"\npassedKey:{ck.Key}");
            //Console.WriteLine($"passed keychar:{ck.KeyChar}");

            /*
            string password = "";
            Console.Write("Enter your password:-");
            ConsoleKeyInfo ck = Console.ReadKey(true);
            while (ck.Key != ConsoleKey.Enter) 
            {
                Console.Write("*");
                password += ck.KeyChar;
                ck = Console.ReadKey(true);
            }
            Console.WriteLine($"\npassword is:{password}");
            */
            //using for each

            /*
             * int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array element are");

             * 
             * forword only
             * read only
             * foreach(type identifire in collection/array)

            */
            /*
            foreach (var item in arr) 
            {
                //item=item+20; invalid
                Console.WriteLine(item);
            }
            //*/
            //int num = 30;
            //object obj = num;  //boxing
            //Console.WriteLine(obj);
            //int y = (int)obj;
            //Console.WriteLine(y);

            //float z= (float)obj;
            //Console.WriteLine(z);     not valid

            //dynamic var,dyanamic
            // var v = num;
            //int a = v;
            //Console.WriteLine(v);
            //Console.WriteLine(a);

            //dynamic dvar = num;
            //int b = dvar;
            //Console.WriteLine(dvar);
            //Console.WriteLine(b);

            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //foreach(dynamic item in arr)
            //{
            //    if (item == 20)
            //    {

            //    }
            //}

            /*
            int sum = 0;
            int[] arr = new int[5] { -10, 20, 30, -40, 50 };

            {
                for(int i=0; i<arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        sum += arr[i];
                    }

                }
                Console.WriteLine($"sum of possitive value:{sum}");
            }

            */


            /*************************************************************//*12-1-23*//***********************************************************/



            // object creation
            //Employee employee = new Employee();
            /*****************************Mamber Calling*********************************/

            /*
            employee.DisplayEmployeeDetails();
            employee.SetEmployeeDetails(1000, "Ratish", 46466.2f);
            employee.DisplayEmployeeDetails();

            Employee emp2= new Employee();
            emp2.DisplayEmployeeDetails();
            emp2.SetEmployeeDetails(1001, "Rohit", 4646.2f);
            employee.DisplayEmployeeDetails();

            emp2.DisplayEmployeeDetails();

            var emp3 = new Employee();
            dynamic emp4 = new Employee();

            Employee emp5=new ();
            emp5.DisplayEmployeeDetails();

            new Employee

                */





            /****************************************************<?13-Jan-2023?>****************************************************************/




            /*

            // Method Calling
            MethodCalling obj = new ();
            int num1 =150, num2 =10 , sum ,multi,div;
            Console.WriteLine($"Num1:{num1}\tNum2:{num2}");
            obj.CallByValue(num1, num2);                
            Console.WriteLine($"Num1:{num1}\tNum2:{num2}");

            //obj.CallByRef(ref num1,ref num2);
            //Console.WriteLine($"Num1:{num1}\tNum2:{num2}");

            obj.CallByOutput(num1,num2,out div,out  sum,out multi);
            Console.WriteLine($"Multiplication:{sum}\tDevide:{multi}\tsum:{div}");


            obj.CallByNameOptinal(101, "Rohit", "kumar", 35000);
            obj.CallByNameOptinal(fname:"Rohit",surname:"Kumar",id:101,salary:35666);
            obj.CallByNameOptinal(fname: "Rohit", surname: "Kumar", id: 101);

            obj.CallByNameOptinal(fname: "Ratish", id: 101);
            obj.CallByNameOptinal(fname: "Rohit", id: 101, salary: 35666);

            obj.CallByNameOptinal(105);

            */

            /*

            Employee emp1= new Employee();
            Employee emp2 = new();

            Employee emp3 = new(101,25000);
            Employee emp4 = new(101,3232);

            Employee emp5 = new(103, 35000);

            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();
            emp4.DisplayEmployeeDetails();
            emp5.DisplayEmployeeDetails();
            GC.Collect();

            */



            /*

            Point p1= new Point(30,30);
            Point p2= new Point(30,30);

            Point p3 = p1+p2;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            if (p1==p2)
            {
                Console.WriteLine("both are same");
            }
            else 
            {
                Console.WriteLine("both are not same");
            }

            */



            //using static demo
            /*
                        StaticDemo s1 = new StaticDemo();
                        StaticDemo s2 = new StaticDemo();
                        StaticDemo s3 = new StaticDemo();


                        s3.DisplayId();
                        s2.DisplayCount();
                        s1.DisplayId();



                        //s2.DisplayCount();

                        SingltonPettarn obj = SingltonPettarn.getObject();
                        obj.Dispaly();*/

           
        }
        
    }
}
