using System;

namespace calisan
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan c1 = new calisan();

            c1.isim = "Buse";
            c1.soyisim = "Çetin";
            calisan.maas = 2500;

            Console.WriteLine("Çalışanın İsmi :"+c1.isim);
            Console.WriteLine("Çalışsanın Soyismi:"+c1.soyisim);
            Console.WriteLine("Çalışanın Maaşı:"+calisan.maas);
            Console.ReadLine();
        }
    }
}