 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPs
{
    internal class SingltonPettarn
    {
        static SingltonPettarn singlton;
            private SingltonPettarn()
        {

        }
        public static SingltonPettarn getObject() 
        {
        return singlton==null ? new SingltonPettarn(): singlton;
        }
        public void Dispaly()
        {
            Console.WriteLine("Dispaly from Singlton method");
        }

    }
}
