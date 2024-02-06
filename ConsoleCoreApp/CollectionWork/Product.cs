using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.CollectionWork
{
    public class Product : IComparable<Product>
    {
        int _pid;
        string _name;
        float _price;
        int _quantity;

        public Product(int pid, string name, float price, int quantity)
        {
            this.pid = pid;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public int pid { get => _pid; set => _pid = value; }

        public string name { get => _name; set => _name = value; }
        public float price { get => _price; set => _price = value; }

        public int quantity { get => _quantity; set => _quantity = value; }

        public int CompareTo(Product? other)
        {
            return this._pid > other._pid ? 1 : -1;
        }

        public override string ToString()
        {
            return $"PID: {_pid} Name : {_name} Price :{_price} Quantity :{_quantity}";
        }

    }
    //creating custom comperator
    public class MyNameComperator : IComparer
    {
        public int Compare(dynamic? obj1, dynamic? obj2)
        {
            return obj1.name.CompareTo(obj2.name);
        }
    }
    public class MyPriceComperator : IComparer
    {
        public int Compare(dynamic? obj1, dynamic? obj2)
        {
            return obj1.price > obj2.price ? 1 : -1;
        }
    }
  
}



