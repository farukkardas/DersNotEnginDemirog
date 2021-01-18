using System;

namespace BTKSartBloklari
{


    class Program

    {


        static void Add(Product product)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Surname);

        }

        class Product
        {
            public string Name { get; set; }
            public string Surname { get; set; }


        }


        static void Main(string[] args)
        {
            //Add();
            //var result = Add2();
            //Console.WriteLine(result);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            var result3 = Multiply(3, 4,5);
            Console.WriteLine(result3);


        }


        static void Add()
        {
            Console.WriteLine("Products are added on basket.");
        }


        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }


        static int Multiply (int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        static int
        // Console.WriteLine("Enter a number: ");

        //int number = 5;

        //while ()
        //{
        //    Console.WriteLine("Döngü dönüyöre.");
        //}


        // int number;
        // number = Convert.ToInt32(Console.ReadLine());
        //if (number >= 0 && number <=100)
        // {
        //     Console.WriteLine("Number is between 0 and 100");
        // }

        //else if (number > 100 && number < 200)
        // {
        //     Console.WriteLine("Number is bigger than 100 and smaller than 200");
        // }

        //else if (number > 200 || number < 0)
        // {
        //     Console.WriteLine("Number is bigger 200 or smaller than 0 ");
        // }


        // -------------------------

        //switch (number)
        //{
        //    case 10:
        //        Console.WriteLine("Sayı 10");
        //        break;
        //    case 15:
        //        Console.WriteLine("Sayı 15");
        //        break;


        //    default:
        //        Console.WriteLine("Doğru sayı girilmedi.");
        //        break;
        //}

        // ----------------------- 

        //if (number == 10 )
        //{
        //    Console.WriteLine("Number is 10");
        //}
        //else if (number >= 10)
        //{
        //    Console.WriteLine("Number is bigger 10");
        //}

        //else
        //{
        //    Console.WriteLine("Number is smaller than 10");
        //}
    


}
