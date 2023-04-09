using System;

namespace dizielemanları.kullanıcıdanal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for(int i=0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar Dizisinin "+(i+0)+"index değerini giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("************************************");

            for(int i=0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}

