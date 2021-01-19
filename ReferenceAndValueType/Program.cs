using System;
using System.Data;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
           int number1 = 10;
           int number2 = 20;

           number2 = number1;
           number1 = 30;
           Console.WriteLine(number2);

           string[] cities1 = new[] {"Adana", "Aradahan", "Amasya"};
           string[] cities2 = new[] { "Antalya", "Ankara", "Ağrı" };

           cities2 = cities1;
           cities1[0] = "Urfa";
           Console.WriteLine(cities2[0]);

           DataTable dataTable1; // Burada new table kullanmadık çünkü gereksiz olacaktı ve performans kaybı yaşayacaktık.
           DataTable dataTable2 = new DataTable();

           dataTable1 = dataTable2; // Datatable2'nin referansını datatable1'e atadık.


        }
    }
}
