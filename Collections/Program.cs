using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");
            

           // Console.WriteLine(dictionary["table"]);

            foreach (var x in dictionary)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(dictionary.ContainsKey("Door"));
            Console.WriteLine(dictionary.ContainsValue("bilgisayar"));


        }

        
        
        
        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Etost");
            cities.Add("araf");
            foreach (var erCity in cities)
            {
                Console.WriteLine(erCity);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer() {Id = 1, Name = "adana"});
            customers.Add(new Customer() {Id = 3, Name = "izmir"});


            var customer2 = new Customer();
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 1, Name = "veli"},
                new Customer() {Id = 4, Name = "Fatih"}
            });

            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();

            customers.Remove(customer2);
            customers.RemoveAll(c => c.Name == "Faruk");
            customers.Insert(0, customer2);

            var index = customers.IndexOf(customer2);
            Console.WriteLine("index : {0}", index);


            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("index : {0}", index2);
            foreach (var eto in customers)
            {
                Console.WriteLine(eto.Name);
            }

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
