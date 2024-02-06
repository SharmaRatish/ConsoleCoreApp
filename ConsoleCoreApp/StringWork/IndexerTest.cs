using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.StringWork
{
    class Employee
    {
        private long[] empContacts;
        public Employee(int size)
        {
            empContacts = new long[size];
        }
        public int ContactsLength => empContacts.Length;     // randomly propety

        // indexer

        public long this[int index] 
        { 
            get{ return empContacts[index]; }
            set { empContacts[index] = value; }
        }


    }






    internal class IndexerTest
    {
        static void Main(string[] args)
        {
            Employee employee =new Employee(4);
            employee[0] = 65413218;
            employee[1] = 65413218;
            employee[2] = 65413218;
            employee[3] = 65413218;

            for (int i = 0; i < employee.ContactsLength; i++)
            {
                Console.WriteLine(employee[i]);
            }
        }
    }
}
