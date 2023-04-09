using System;

namespace _6_metotlarornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 2 sayı alıp büyük olanı ekrana yazdırma (geriye değer döndürmeyen)


            Console.WriteLine("İlk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            kontrolet(sayi1,sayi2);
            Console.ReadLine();

        }

        static void kontrolet(int a,int b)
        {
            if(a>b)
            {
                Console.WriteLine("1. sayı 2. sayıdan büyüktür");
            }
            else if(a==b)
            {
                Console.WriteLine("İki sayı birbirine eşittir");
            }
            else
            {
                Console.WriteLine("2. sayı 1. sayıdan büyüktür");
            }
        }
       
    }
}
