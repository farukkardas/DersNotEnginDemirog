using System;
using AccesModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // AccesModifiers assemblysinin içindeki Course classını çağırıp yeni bir member oluşturdum.
            Course course = new Course();
            
            //Diğer assemblyde kullanılacak olan class'ın başına public yazılır bu sayede o class diğer assemblylerde kullanılır.
            //Dependencies kısmına gelip "Add Reference" denir ve class hangi assemblydeyse o seçilir. 
            //Projenin üstüne using AccessModifiers; yazıp o assemblyi dahil ettik ve classını kullanabildik.
        }
    }
}
