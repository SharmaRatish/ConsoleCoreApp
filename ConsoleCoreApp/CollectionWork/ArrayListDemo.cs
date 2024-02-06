using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.CollectionWork
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            //ArrayList list= new ArrayList();   //default cunstructor  memory icrese as 0/4/8/16/32/64/

            // ArrayList list = new ArrayList(5); 

            ArrayList list = new ArrayList() { 8,7,6,31,};// this is paramete constructor  is increment like n*2
            Console.WriteLine($"Total Items:{list.Count}");
            Console.WriteLine($"Total Current Capacity:{list.Capacity}");


            list.Add(20);
            Console.WriteLine($"Total Items:{list.Count}");
            Console.WriteLine($"Total Current Capacity:{list.Capacity}");


            list.Add(0);
            list.Add(20);
            list.Add(90);
            list.Add(27);
            Console.WriteLine($"Total Items:{list.Count}");
            Console.WriteLine($"Total Current Capacity:{list.Capacity}");


            //cresting a new list using any existing list 

            ArrayList list1=new ArrayList(list);


            //Displaing List Data
            Console.WriteLine("Using for loop");
            for (int i = 0; i <list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            Console.WriteLine("Using for each loop");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // diaplay arraylist using enumrator
            IEnumerator itr = list1.GetEnumerator();
            while (itr.MoveNext()) 
            {
            Console.WriteLine(itr.Current);
            }


            //Assigning user input value
            /*
            ArrayList list3=new ArrayList();
            Console.WriteLine("input list data items:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter item{i+1} value:");
                //list3.Add(Console.ReadLine());
                list3.Add(Int32.Parse(Console.ReadLine()));

            }
            Console.WriteLine("list item are");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            */

            ArrayList list4= new ArrayList() {1,2,3,4,5,6 };
            ArrayList list5= new ArrayList() { 7,8,9,16,35,44,75};
            list4.AddRange(list5);
            Console.WriteLine("list-4 items:");
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }

            //remove 8 from list
            list4.Insert(list4.IndexOf(7)+1,25);
            list4.Sort();
            list4.Reverse();
            Console.WriteLine("updated list item");
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }
            list4.TrimToSize();
            Console.WriteLine("cpapacty:"+list4.Capacity);
            Console.WriteLine("count:"+list4.Count);

        }
    }
}
