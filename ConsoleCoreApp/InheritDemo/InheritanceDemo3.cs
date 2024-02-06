using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.InheritDemo
{

    class MyBase3
    {
        int id;
        public MyBase3(int id)
        {

            this.id = id;
            Console.WriteLine("constr from my base-3");
            Console.WriteLine($"ID:{this.id}");
        }
    }

    class Drive1:MyBase3
        {
        string name;
        public Drive1(int id, string name):base(id)
        {
            //super(id)
            this.name = name;
            Console.WriteLine("constructor from Drive 1");
            Console.WriteLine($"Name:{this.name}");
        }

        }

    class Drive2:Drive1
    {
        int age;
        public Drive2(int id, string name,int age) : base(id,name)
        {
            //super(id)
            this.age = age;
            Console.WriteLine("constructor from Drive 2");
            Console.WriteLine($"Age:{this.age}");
        }

    }


    internal class InheritanceDemo3
    {

        static void Main(string[] args)
        {
            Drive2 drive2 = new Drive2(25,"Nadeem",102);  
        }
    }
}
