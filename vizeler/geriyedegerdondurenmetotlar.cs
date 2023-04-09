using System;

namespace geriyedegerdondurenmetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int donendeger= toplamaYap(10,6);
            if (donendeger > 10)
            {
                Console.WriteLine("Değer 10'dan Büyüktür");
            }
            else

            {
                Console.WriteLine("Değer 10'dan Küçüktür");
            }

            Console.ReadLine();*/
           string gelenisimsoyisimdegeri= isimsoyisimdondur("Buse", "Çetin");
                Console.WriteLine( gelenisimsoyisimdegeri);
            Console.ReadLine();
            
        }

        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
          
        }

       static string[] isimsoyisimdondur(string isim,string soyisim)
        {
            return isim + "  " + soyisim;
        }
        
    }
}
