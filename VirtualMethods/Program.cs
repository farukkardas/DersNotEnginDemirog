using System;
using System.Threading.Channels;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MysqlServer mysql = new MysqlServer();
            mysql.Add();
            AdoNet adonet = new AdoNet();
            adonet.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted.");
        }

    }

    class MysqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by mysql");
            //base.Add();
            
        }
    }

    class AdoNet : Database
    {

    }
}

