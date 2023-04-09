using System;

namespace fordongusuornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz...");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i=1; i<=sayi; i++)
            {
                toplam =+ i;
            }

            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50'den Büyüktür");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den Küçüktür...");
                Console.ReadLine();

            }
        }
    }
}

