using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paramteresiz Geriye Değer Döndürmeyen Metot Tanımlama (void geriye değer döndürmeyen demek)

            selamver();
            selamver();
            adiniyazdir();
        }

        static void selamver()
        {
            Console.WriteLine("selamlar");
            Console.ReadLine();
        }
        static void adiniyazdir()
        {
            Console.WriteLine("buse nur çetin");
            Console.ReadLine();
        }


        //metot kullandığımız için sadece metodu yazmak o metodun içindeki kodları çalıştırmak için yeterli
    }
}
