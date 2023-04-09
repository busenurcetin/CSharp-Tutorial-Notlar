using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //parametresiz geriye değer döndürmeyen metot tanımlama
            //void geriye değer döndürmeyen değerler için kullanılan anahtar kelimelerdir.
  
            adiniyazdir();
            adiniyazdir();
            adiniyazdir();
            adiniyaz();
            selamver();
        }

        static void adiniyazdir()
        {
            Console.WriteLine("buse nur");
            Console.ReadLine();
        }

        static void adiniyaz()
        {
            Console.WriteLine("buse");
            Console.ReadLine();
        }

        static void selamver()
        {
            Console.WriteLine("selamlar");
            Console.ReadLine();
        }


    }
}
