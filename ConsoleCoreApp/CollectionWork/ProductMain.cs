using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleCoreApp.CollectionWork
{
    
        internal class ProductMain
        {

            public static void AddProduct(ArrayList arl)
            {
                Console.WriteLine("enter the pid ");
                int pid = Int32.Parse(Console.ReadLine());
                Console.WriteLine("enter the name ");
                string name = Console.ReadLine();
                Console.WriteLine("enter the product price ");
                float price = Single.Parse(Console.ReadLine());
                Console.WriteLine("enter the quantity ");
                int wuantity = Int32.Parse(Console.ReadLine());

                Product p = new Product(pid, name, price, wuantity);
                arl.Add(p);
            }
            public static void DisplayProduct(ArrayList arl)
            {
                foreach (var item in arl)
                {
                    Console.WriteLine(item);
                }
            }
            public static void SortByName(ArrayList arl)
            {
                arl.Sort(new MyNameComperator());
                // arl.Sort()

            }
            public static void SortByprice(ArrayList arl)
            {
                arl.Sort(new MyPriceComperator());
            }

            /*public static Product SearchById(ArrayList arl,int pid)
            {
                IEnumerator itr=arl.GetEnumerator();
                while(itr.MoveNext())
                {
                    itr.Current
                }
                return true;
            }*/
            public static void Deleteproduct(ArrayList arl)
            {
                Console.WriteLine("enter the pid ");
                int pid = Int32.Parse(Console.ReadLine());

                foreach (var item in arl)
                {
                    Product obj = (Product)item;
                    if (obj.pid == pid)
                    {
                        Console.WriteLine(obj);
                        arl.Remove(obj);
                        break;
                    }
                }

                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                ArrayList product = new ArrayList();

                do
                {

                    Console.WriteLine("select the choice  ");
                    Console.WriteLine("select 1 to add record  ");
                    Console.WriteLine("select 2 to display record  ");
                    Console.WriteLine("select 3 to sort record by name ");
                    Console.WriteLine("select 4 to sort record by price ");
                    Console.WriteLine("select 5 to delete the record");
                    Console.WriteLine("select 6 to exit");

                    Console.WriteLine("enter your choice ");
                    int ch = Int32.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            {
                                AddProduct(product);
                                break;
                            }
                        case 2:
                            {
                                DisplayProduct(product);
                                break;
                            }
                        case 3:
                            {
                                SortByName(product);
                                break;
                            }
                        case 4:
                            {
                                SortByprice(product);
                                break;

                            }
                        case 5:
                            {
                                Deleteproduct(product);
                                break;

                            }
                        case 6:
                            {
                                Environment.Exit(0);
                                break;

                            }
                        default:
                            break;
                    }
                } while (true);



            }
        }
    }

