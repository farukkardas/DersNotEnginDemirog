using System;
using AccesModifiers;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {

        protected int Id { get; set; }

        public void Save()
        {

        }

        public void Delete()
        {

        }

    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            
        }


    }

    public class Course
    {
        public string Name { get; set; }

    }

}

