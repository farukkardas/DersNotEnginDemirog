using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Customer{Id = 10,Name = "Faruk",Surname = "Kardaş"}, 
                new Student{Id=55,Name="Ahmet",Surname = "Mehmet"},
                new Person{Id = 11,Name = "Veli",Surname = "B   akar"}
            };
            foreach (var x in persons)
            {
                Console.WriteLine(x.Name);
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
