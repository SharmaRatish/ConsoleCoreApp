using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.StringWork
{
    internal class DateTimeDemo
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;   // library  name
            Console.WriteLine("Current date & time:"+date);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.Millisecond);
            DateTime newdate= date.AddMinutes(15);
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Update date"+newdate);
            Console.WriteLine("date formating");
            Console.WriteLine("long date" + date.ToLongDateString());
            Console.WriteLine("Update date" + date.ToShortDateString());
            Console.WriteLine("Update date" + date.ToLongTimeString());
            Console.WriteLine("Update date" + date.ToLongTimeString);

            //Console.WriteLine(date.ToString(""));


            /**********************************************************DATE FORMATIING***************************************/


            Console.WriteLine(date.ToString("MM-dd-yy,H:m:s t"));
            Console.WriteLine(date.ToString("dd-MM-yy,HH:m:ss tt"));
            Console.WriteLine(date.ToString("dd-MM-yy,H:m:ss fffffff tt"));
            Console.WriteLine(date.ToString("MMMM-yyyy"));
            Console.WriteLine(date.ToString("dddd,dd-MM-yy"));

            Console.WriteLine(date.ToString("dddd,MMM dd,yyyy,HH:mm:ss tt"));



            //Trusday,Jan 19,2023 15:58:50 pm


            //reading date value from console 

            Console.WriteLine("input date value[mm/dd/yyyy]:");
            DateTime mydate;
            if (DateTime.TryParse(Console.ReadLine(),out mydate))
            {
                Console.WriteLine("date is:"+mydate);
                Console.WriteLine(mydate.ToString("MMMM,dd-MM-yyyy"));
            }
            else {
                Console.WriteLine("input a valid date....!!!");
            }


        }
    }
}
