using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCoreApp.Oops;
using ConsoleCoreApp.OOPs;

namespace ConsoleCoreApp.Arrays
{
    internal class ObjectArray
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5]
            {
                new Product () {pid=101,name="soap",price=25},
                new Product () {pid=102,name="Dream light",price=15},
                new Product () {pid=103,name="Oil",price=185},
                new Product () {pid=104,name="Chocklete",price=35},
                new Product () {pid=105,name="Milk",price=50}
            };

            Console.WriteLine("Product Name");

            Displayproduct(products);

            Array.Sort(products);
            Console.WriteLine("Sorted By Id Product List");
            Displayproduct(products);

            /*Array.Sort(products, new MyNameComparator());
            Console.WriteLine("Sorted by name product list");
            Displayproduct(products);

            Array.Sort(products, new MyNameComparator());
            Console.WriteLine("Sorted by price product list");
            Displayproduct(products);*/
        }
        public static void Displayproduct(Product[] product)
        {
            foreach (var item in product)
            {
                //item.DisplayProduct();
                Console.WriteLine(item);
            }
        }
    }
}