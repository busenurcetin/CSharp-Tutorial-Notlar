using System;

namespace return2
{
    class Program
    {
        static void Main(string[] args)
        {
            string gelenisimsoyisim = isimsoyisimdondur("buse", "çetin");
            Console.WriteLine(gelenisimsoyisim);
            Console.ReadLine();
        }

        static string isimsoyisimdondur(string isim,string soyisim)
        {
            return isim + " " + soyisim;
            //return anahtar kelimesinden sonra yazılan kodlar çalışmaz
        }
    }
}

