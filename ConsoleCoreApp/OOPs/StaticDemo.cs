using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPs
{
    internal class StaticDemo
    {
        int id;
        static int count;
        public StaticDemo()
        {
            this.id = count++;
        }
        public void DisplayId()
        {
            Console.WriteLine($"ID:{id}");
        }

        public void DisplayCount()
        {
            Console.WriteLine($"Object Created:{count}");
        }

        static StaticDemo()
        {
            count = 0;
        }
    }
}
