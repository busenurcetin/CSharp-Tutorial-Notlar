using System;

namespace _5_metorlarornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan sayının tek mi çift mi olduğunu bulan metot (geriye değer döndürmeyen)


            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            tekmiciftmi(sayi);
            Console.ReadLine();

        }

        static void tekmiciftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }

    }
}

