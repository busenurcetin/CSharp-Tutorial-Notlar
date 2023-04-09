using System;

namespace odevvvv
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.ogrno = "123456789";
            Console.WriteLine("Öğrenci no: "+ogrenci1.ogrno);
            Console.ReadLine();
        }
    }
}

