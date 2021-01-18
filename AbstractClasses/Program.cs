using System;
using System.Threading.Channels;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract class için yeni bir üye oluşturulamaz.

            Database database = new Oracle();
            database.Add();
            database.Delete();
            
            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
        }

        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default.");
            }

            //İçi dolu olmayan virtual methoddur herhangi bir yerde çağırılıp implement edilebilir.
            public abstract void Delete();

        }

        class SqlServer : Database
        {
            //Abstract voidi çağırdık.
            public override void Delete()
            {
                Console.WriteLine("Deleted by SqlServer");
            }
        }
        
        /*Eğer bir abstract void oluşturulmuş ise ve başka bir classa miras bırakılacak ise 
        miras alan class içinde tanımlanması zorunludur.
        */
        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle.");
            }
        }
    }

}
