using System;

namespace sinavcalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //selamver();
            // toplama(7, 2);

        }
        //parametresiz geriye değer döndürmeyen
        static void selamver()
        {
            Console.WriteLine("selamlar");
        }
        //
        //paramtreli geriye değer döndürmeyen
        static void toplama(int sayi,int sayi2)
        {
            Console.WriteLine("toplama sonucu "+(sayi+sayi2));
            Console.ReadLine();
        }

        //

        //kullanıcıdan aldığımız sayının karesini alalım 25ten büyükse 25ten büyük yazalım
    }
}

