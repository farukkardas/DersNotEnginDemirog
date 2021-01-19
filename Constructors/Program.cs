using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(23);

            customer.List();

            Product product = new Product { Id = 1, Name = "Faruk" };
            Product product2 = new Product(13, "Mehmet");


            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());

            employeeManager.Add();

            PersonManager personManager = new PersonManager("faruk");
            personManager.Add();

            
            Teacher.Number = 10;  // Static classlarda çağırılan objeyi direk classın isminden çağırıyoruz.
            Utilities.Validate();
            Manager.DoSomething();

            
            // Public classlarda ise methodu çağırmak için bir instance oluşturmamız gerekiyor
            Manager manager = new Manager();
            manager.DoSomething2();
            
        }
    }

    class CustomerManager
    {
        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }

    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Employee Added!");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }


    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
    
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Do something");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Do something 2");
        }
    }
}