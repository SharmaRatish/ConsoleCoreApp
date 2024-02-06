using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPs
{

    class Student
    {
        int _RollNo;
        string _FirstName;
        string _LastName;
        float _Tmarks;

        public int RollNo
        {
            get { return _RollNo; }
            set { _RollNo = value; }
        }

        public string FirstName
        { get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }

        }
        public float Totalmark
        {
            get { return _Tmarks; }
            set { _Tmarks = value; }
        }

        //creating rendomly property
        public float percentage
        {
            get { return _Tmarks / 5; } //write only banae k liye get only hatana padega 
            set { _Tmarks = value; }
        }

        public override string ToString()
        {
            return $"Roll No:{_RollNo}\tFull Name:{_FirstName + "" + _LastName}" +
                $"\tTotal Mark:{_Tmarks}";
        }

        //Expression Body Properties
        /********************************************************************Ye wala latest syntex hai or sabhi me ek hi kaam hor rha *******************************************************/

        public string FullName => $"{_FirstName} {_LastName}";
        int _Age;
        public int Age { get => _Age; set => _Age = value; }

        public int Square(int num)
        {
            return num * num;
        }

        //method with expression-body

        public int Cube(int num) => (num * num * num);

        /********************************************************************************************************************************************************************************/


        public string College { get; set; }

        public string Course { get; set; }


    }


    internal class PropertyDemo
        {
            static void Main(string[] args)

            {
            /*
             Student student=new Student();
            student.RollNo = 101;  //Here set accessor will be called , write operation
            student.FirstName = "Rohit";
            student.LastName = "kumar";
            student.Totalmark = 450;
            //Reading data from property
            int rollno = student.RollNo;  //HAre get accessor will be called operation
            Console.WriteLine($"Roll No:{rollno}");
            Console.WriteLine($"First Name:{student.FirstName}");
            Console.WriteLine($"Last Name:{student.LastName}");
            //Console.WriteLine($"Total Marks:{student.Totalmark}");

            Console.WriteLine(student);
            student.percentage= 70;    // Not allowed

            Console.WriteLine($"{student.percentage}");  // not allowd when it is write only

            //using auto -implemented properties
            student.College = "AKU";
            student.Course = "BTech";
            Console.WriteLine($"College:{student.College}\tCourse:{student.Course}");

            */


            /*

            Student s1= new Student()
            {
                    RollNo=101,
                    FirstName="Ratish",
                    LastName="Sharma",
                    College="CDAC",
                    Course ="PGDAC",
                    Totalmark=220
            };

            Console.WriteLine(s1);

            Student s2 = new Student() {

                RollNo = 101,
                FirstName = "Ratish",
                LastName = "Sharma",
                College = "CDAC",
                Course = "PGDAC",
                Totalmark = 220


            };
            */
            

                Student s3 = new Student();

                s3.FirstName = "rohit";
                s3.LastName = "kumar";
                s3.Age = 25;
                Console.WriteLine($"Full Name:{s3.FirstName}");
                Console.WriteLine($"Age:{s3.Age}");
                Console.WriteLine($"Cube:{s3.Cube}");

            }
        }
    }

