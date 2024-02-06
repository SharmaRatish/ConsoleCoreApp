using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.Oops
{
    internal class Product : IComparable<Product>
    {
        int _pid;
        string _name;
        float _price;

        public int pid { get => _pid; set => _pid = value; }

        public string name { get => _name; set => _name = value; }
        public float price { get => _price; set => _price = value; }

        public int CompareTo(Product? other)
        {
            //
            return this._pid>other._pid?1:1;
         //   return this._pid?-1 : 1;
        }

        public override string ToString()
        {
            return $"PID: {_pid} Name : {_name} Price :{_price}";
        }

    }

    //Creating coutom coparator
/*
    public class MyNameComparator : IComparer<Product> {

    public  int Comparer(Product? obj1, Product? obj2)
        {
            return obj1.name.CompareTo(obj2.name);
        }

        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            throw new NotImplementedException();
        }
    }

    public class MyNameComparator : IComparer<Product>
    {

        public int Comparer(Product? obj1, Product? obj2)
        {
            return obj1.name.CompareTo(obj2.name);
        }
    }
*/

}