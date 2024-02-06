using ConsoleCoreApp.DelegateDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.CollectionWork
{

    class MyGenericClass<T1>
    {
        public void Display(T1 t)
        {
            Console.WriteLine($"Type:{t.GetType().Name}\tValue:{t}");
        }

        public void Swap(T1 t1 ,T1 t2)
        {
           
            
            Console.WriteLine($"Before Swap\n:t1:{t1}\tt2:{t2}");
            T1 temp =t1;
            t1 = t2;
            t2 = temp;

            Console.WriteLine($"After Swap\n:t1:{t1}\tt2:{t2}");

        }

    }

    class A
    {


    }

    class B:A 
    {
    
    
    
    }
    //class GenericClass<T1,T2 > where T1:struct
                                //where T2:class
    class GenericClass<T1,T2 > 
    {
            T1 t1;

            T2 t2;
    public GenericClass() 
        {
            t1 = default(T1);
            t2 = default(T2);        
        }

        public void Display(T1 t1, T2 t2) 
        {
            Console.WriteLine($"T1:{t1}\tT2:{t2}");
        
        }


        public void Display()
        {
            Console.WriteLine($"T1:{t1}\tT2:{t2}");

        }

    }




    internal class GenericDemo
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> obj= new MyGenericClass<int>();
            obj.Display(30);


            MyGenericClass<string> obj2= new MyGenericClass<string>();
            //  obj2.Display("patna");
            obj2.Swap("patna", "Cdac");


           /* GenericClass<int,string> obj3 = new GenericClass<int,string>();
            obj3.Display();
            obj3.Display(10,"patna");*/

            /*GenericClass<string, int> obj3 = new GenericClass<string, int>();
            obj3.Display();
            obj3.Display("patna,10");*/

            GenericClass<A,B> obj4=new GenericClass<A,B>();

            obj4.Display(new A(),new B()); 

            obj4.Display(new B(), new B());


        }

    }
}
