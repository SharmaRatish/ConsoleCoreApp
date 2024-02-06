using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.DelegateDemo
{

    public delegate void MyEventHandler(int number);
    internal class EventDemo
    {
        //declare event
        public event MyEventHandler myEvent;


        //HandlerMethods
        public void GetFact(int number)
        {

            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Fectorial of{number} is {fact}");

        }

        public void GetSqure(int number)
        {
            Console.WriteLine($"Square of:{number} is{number * number}");

        }


        static void Main(string[] args)
        {

            EventDemo eventDemo = new EventDemo();

            //Event Insertion/Subscription
            int number;
            while (true)
            {
                Console.WriteLine("Enter Number");
                number = Convert.ToInt32(Console.ReadLine());
                eventDemo.myEvent = null;

                if (number > 0 && number < 10)
                {
                    eventDemo.myEvent += new MyEventHandler(eventDemo.GetFact);
                }
                else
                

                    eventDemo.myEvent += new MyEventHandler(eventDemo.GetSqure);


                    //eventDemo.myEvent += new MyEventHandler(eventDemo.GetSqure);
                    //eventDemo.myEvent += eventDemo.GetFact;

                    if (eventDemo.myEvent != null)
                    {



                        //Fire The event/Invocation
                        // eventDemo.myEvent.Invoke(5);
                        //eventDemo.myEvent(6);
                        eventDemo.myEvent.Invoke(number);
                    }
                }
            }
        }
    }
