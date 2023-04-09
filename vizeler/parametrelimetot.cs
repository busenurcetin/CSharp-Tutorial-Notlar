using System;

namespace parametrelimetot
{
    class Program
    {
        static void Main(string[] args)
        {

            //parametre alan geriye değer döndürmeyen metot

           // toplamayap(1, 2);
            //carpmayap(2, 5, 7);
            isimsoyisimyazdir("buse", "çetin");
        
        }

        static void toplamayap(int sayi1, int sayi2)
        {
            Console.WriteLine("gönderilen sayilarin toplami :"+(sayi1+sayi2));
            Console.ReadLine();

        }

        static void carpmayap(int sayi1 ,int sayi2,int sayi3)
        {
            Console.WriteLine("gönderilen 3 sayının çarpımı :" +(sayi1*sayi2*sayi3));
            Console.ReadLine();
        }
        static void isimsoyisimyazdir(string isim,string soyisim)
        {
            Console.WriteLine("isim ve soyisim :"+ isim+" "+ soyisim);
            Console.ReadLine();
        }
    }
}