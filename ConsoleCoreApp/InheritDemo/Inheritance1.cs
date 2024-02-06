using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleCoreApp.InheritDemo
{
    class mybase
    {
        public void Display()
        {
            Console.WriteLine("display from my base");
        }

    }
    class myDerive1 : mybase { 
    
    public void show ()
        {
            Console.WriteLine("show from derive-1");
            Display();
        
        }
    }


    internal class Inheritance1
    {
        static void Main(string[] args)
        {
            myDerive1 myderive=new myDerive1();
            
        }
    }
}
