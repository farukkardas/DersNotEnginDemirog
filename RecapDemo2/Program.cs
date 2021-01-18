using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger(); // Burada JsonLogger,DatabaseLogger veya SMS  class'ı kullanılabilir.
            customerManager.Add();

        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; } // Public propoerty ile ILogger türünde bi logger ürettik.
        public void Add()
        {
           Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }

    }

    class JsonLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to JSON file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}

