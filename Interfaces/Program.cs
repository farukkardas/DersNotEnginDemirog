using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();

            //Customer teemo = new Customer()
            //{
            //    Id = 1, 
            //    Balance = 1500, 
            //    Name = "Mustafa", 
            //    Surname = "Kardaş"
            //};

            //Student student = new Student() 
            //{
            //    Id = 78, 
            //    Name = "Faruk", 
            //    SchoolName = "SAU", 
            //    Surname = "Kardaş"

            //};
            //manager.Add(teemo);
            //manager.Add(student);

            //ManagerAcess managerAcess = new ManagerAcess();
            //managerAcess.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(), 
                new SqlServerCustomerDal()
            };

            foreach (var dbs in customerDals)
            {
                dbs.Add();

            }

        }

        interface IPerson
        {
            int Id { get; set; }
            string Name { get; set; }
            string Surname { get; set; }
        }
        
        class Customer:IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public int Balance { get; set; }
        }
        
        class Student:IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public string SchoolName { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson customer)
            {
                Console.WriteLine(customer.Name);
            }



        }

    }
}
