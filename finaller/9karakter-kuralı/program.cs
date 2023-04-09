using System;

namespace deeers
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.ogreno = "22433"; //9 karakterden az girersen diğer öğrencinoyu gösterir.
            Console.WriteLine(ogrenci1.ogreno);
            Console.ReadLine();

            ogrenci1.yaz();
            Console.ReadLine();
        }
    }
}

