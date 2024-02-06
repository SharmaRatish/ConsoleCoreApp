using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCoreApp.CollectionWork
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ratish", "86556789");
            ht.Add("nadim", "98563459");
            //ht.Add("nadim", "98563459");      //not allowd as same key
            ht.Add("niyaz", "78956789");
            ht.Add("rohit", "893456789");
            ht.Add("rishi", "893456789");       //this is valid
            ht.Add("sinde", "97956789");
            ht.Add("ojha", "646456789");
           // ht.Add(null, "893456789");          //not valid key can not be null 
            ht.Add("rohit2",null);
            Console.WriteLine("hash table data ");

           // Console.WriteLine($"Mobile no of nadim is :{ht["nadim"]}");

            foreach (DictionaryEntry item in ht) 
            {
                Console.WriteLine(item.Key+"==>"+item.Value);

            }

            Console.WriteLine("Hash Table Data Using GetEnumerator():") ;
            IDictionaryEnumerator itr= ht.GetEnumerator();

           // ht["nadim"] = "998746987";
            while (itr.MoveNext()) 
            {
                Console.WriteLine(itr.Key + "==>" + itr.Value);
            }

            // geting all key

            ICollection keys= ht.Keys;
            IEnumerator keyitr= keys.GetEnumerator();
            Console.WriteLine("keys are:");
            while (keyitr.MoveNext()) 
            {
                Console.WriteLine(keyitr.Current);
            }

            //Sorted
            //stack
            //queue
            //SortedList list= new SortedList(); 
            Stack stack= new Stack();
            stack.Push(20);
            stack.Push(25);
            stack.Push(18);
            stack.Pop();
            stack.Pop();
            stack.Push(60);
            stack.Push(15);
            stack.Pop();
            stack.Push(100);
            stack.Push(100);
            stack.Push(100);
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());


        }

    }
}
