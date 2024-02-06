using ConsoleCoreApp.DAY5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Oops
{
    internal class EmployeeMain
    {
        static int count = 0;
        static void Main(string[] args)
        {

            Employee[] arr = new Employee[6];
            do
            {
                Console.WriteLine("enter 1 for add");
                Console.WriteLine("enter 2 for display");
                Console.WriteLine("enter 3 for exit");

                Console.WriteLine("enter the choice ");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            AddEmployee(arr, count);
                            count++;
                            break;
                        }
                    case 2:
                        {
                            Display(arr);
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid choice");
                            break;
                        }
                }


            } while (true);

        }
        private static void AddEmployee(Employee[] emp, int count)
        {
            Console.WriteLine("enter the id ");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the name ");
            string name = Console.ReadLine();
            Console.WriteLine("enter the salary ");
            float salary = Single.Parse(Console.ReadLine());

          //  Employee e1 = new (id, name, salary);

          //  emp[count] = e1;
        }
        private static void Display(Employee[] emp)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(emp[i].ToString());
            }

        }
    }
}