using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.LINQEXP
{
    class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }
    class City
    {
        public int Id { get; set; }
        public int CityStateId { get; set; }
        public string CityName { get; set; }
    }




    internal class LinqDemo2
    {
        static void Main(string[] args)
        {
            IList<State> states = new List<State>() {
                                 new State() { Id = 1, StateName = "UP" },
                                new State() { Id = 1, StateName = "J&k" },
                                new State() { Id = 1, StateName = "Rajasthan" }
                                };


            /* var city=from c in cities
                      where c.CityStateId== 1
                      select new { c.Id,c.CityName };

             Console.WriteLine("Cities are");
             foreach (var item in city)
             {
                 //Console.WriteLine($"{item.Id},{item.CityStateId},{item.CityName}");
                 Console.WriteLine($"{item.Id},{item.CityName}");
             }

             var stategroup = from c in cities
                              group c by c.CityStateId;
             foreach (var state in stategroup)
             {
                 Console.WriteLine(state.Key + "=>");
                 foreach (City c in state)
                 {
                     Console.WriteLine(c.Id + "=>" + c.CityStateId + "=>" + c.CityName);
                 }
             }*/



            IList<City> cities = new List<City>()
         {
             new City(){Id=1,CityStateId=1,CityName="Kanpur"},
             new City(){Id=2,CityStateId=1,CityName="Noida"},
             new City(){Id=3,CityStateId=2,CityName="Jammu"},
             new City(){Id=4,CityStateId=3,CityName="Bhilwada"},
             new City(){Id=5,CityStateId=3,CityName="Kacch"},
             new City(){Id=6,CityStateId=2,CityName="Dehradun"},
             new City(){Id=7,CityStateId=3,CityName="Jaisalmer"},
             new City(){Id=8,CityStateId=2,CityName="kasouli"}
         };





            /* var result=from s in states
                         join c in cities                       
                         on s.Id equals c.CityStateId
                         select new { s.StateName,CID=c.Id,c.CityName };

             Console.WriteLine($"StateName\tCityId\tCityName");
             foreach (var item in result)
             {
                 Console.WriteLine($"{item.StateName}\t\t{item.CID}\t{item.CityName}");
             }*/

            // var result = cities.Skip(4);

            //var result = cities.Take(4);
            var result = cities.SkipWhile(c => c.Id <= 5);
            Console.WriteLine("Cities are");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id}\t{item.CityName}");
            }

            Console.WriteLine("**************************");
            // City city=cities.First(c=>c.Id==4);
            //City city = cities.FirstOrDefault(c => c.Id == 4);
            City city = cities.SingleOrDefault(c => c.Id == 4);
            if (city!=null)
            {
                Console.WriteLine($"{city.Id}\t{city.CityName}");
            }
            else {
                Console.WriteLine("no city exist");
                }
            // bool res=cities.Any(c => c.Id == 60);
            /*bool res = cities.All(c => c.Id == 60);
            Console.WriteLine("Result"+res);*/

        }


    }
}
