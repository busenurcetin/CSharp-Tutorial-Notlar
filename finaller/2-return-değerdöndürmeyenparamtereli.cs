using System;

namespace return_geriyedeğerdöndürenmetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //paramter alan geriye değer döndürmeyen metotlar
           

            toplamayap(4,3);

            carpmayap(8, 10, 5);
            isimsoyisimyazdir("buse","çetin");
            Console.ReadLine();

            
        }

        static void toplamayap(int sayi1, int sayi2)
        {

            //parametreli metotlar tanımlamak için parantezlerin içine yazarsın
            Console.WriteLine("Gönderilen Sayıların Toplamı : " +(sayi1+sayi2));

        }

        static void carpmayap(int sayi1,int sayi2, int sayi3)
        {
            Console.WriteLine("Üç Sayının Çarpımı : " +( sayi1*sayi2*sayi3));
        }

        static void isimsoyisimyazdir(string isim,string soyisim)
        {
            Console.WriteLine(isim+" "+soyisim);
        }

    }
}