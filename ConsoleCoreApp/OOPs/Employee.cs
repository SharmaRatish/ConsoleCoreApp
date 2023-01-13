using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.DAY5
{
    internal class Employee
    {
        int _EmpCode;
        string _EmpName;
        float _EmpSalary;


        public Employee()
        {
            Console.WriteLine("Default constr called");
            this._EmpSalary = 20000;
        }


        public void SetEmployeeDetails(int _EmpCode, string _EmpName, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Details saved");
        }

        public Employee(int _EmpCode, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("perametrized constrector 2");
        }

        static Employee()
        {
            Console.WriteLine("static constrector called");
        }
        ~Employee()
        {
            Console.WriteLine("object removed");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Detail is:");
            Console.WriteLine($"Code:{_EmpCode}\tName:{_EmpName}\tSalary:{_EmpSalary}");
        }
       
    }
}
