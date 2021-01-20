using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Microsoft.VisualBasic;

namespace Exceptions
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                FindException();
            }
            catch (RecordNotFound exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {

            }

            HandleException(() =>
            {
                FindException();
            });


            void HandleException(Action action)
            {
                try
                {
                    action.Invoke();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    
                }
            }

            void FindException()
            {
                List<string> students = new List<string>() { "Faruk", "Ertuğrul", "Oğuzhan" };


                if (!students.Contains("Ahmet"))
                {
                    throw new RecordNotFound("Record not found");
                }
                else
                {
                    Console.WriteLine("Record found");
                }
            }


            void ExceptionIntro()
            {
                try
                {
                    string[] students = new string[3] { "Faruk", "Ertuğrul", "Oğuzhan" };

                    students[3] = "Ahmet";
                }
                catch (IndexOutOfRangeException exception) // hata buysa bunu çalıştır
                {
                    Console.WriteLine(exception.Message);
                }
                catch (DivideByZeroException exception) // değilse bunu
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception exception) // değilse bunu
                {
                    Console.WriteLine(exception.Message);
                }
            }


        }

    }
}
