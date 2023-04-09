using System;

namespace ogrencino
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.ogrno = "123456789";
            Console.WriteLine("Öğrencinin Numarası:"+ogrenci1.ogrno);
            Console.ReadLine();
        }
    }
}
