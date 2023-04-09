using System;

namespace finaller
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.ogrencino = "123456789";
            Console.WriteLine(ogrenci1.ogrencino);
            Console.ReadLine();
        }
    }
}
