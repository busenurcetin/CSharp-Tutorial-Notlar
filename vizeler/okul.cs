using System;

namespace okul
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            kontrolet(sayi, sayi2);
            Console.ReadLine();
     
        }

        static void kontrolet(int a, int b)
        {
            if(a>b)
            {
                Console.WriteLine("1. sayı ikinci sayıdan büyüktür");
            }
            else if(a==b)
            {
                Console.WriteLine("İki sayı birbirine eşittir");
            }
            else
            {
                Console.WriteLine("2. sayı birinci sayıdan büyüktür");
            }
        }
    }
}

