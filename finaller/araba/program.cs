using System;

namespace araba
{
    class Program
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba(4,"Kırmızı","Ford");
            Console.WriteLine("Arabanın Rengi:"+araba1.arabarenk);
            Console.WriteLine("Arabanın Kapı Sayısı:"+araba1.kapisayisi);
            Console.WriteLine("Arabanın Modeli:"+araba1.arabamodel);
            Console.ReadLine();
        }
    }
}
