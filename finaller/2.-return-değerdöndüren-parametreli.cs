using System;

namespace _2return_geriyedeğerdöndürenparametreli
{
    class Program
    {
        static void Main(string[] args)
        {
            //parametre alan geriye değer döndüren metot tanımlama
            //void geriye değer döndürmez
            // return anahtar kelimesi

         int donendeger=  toplamayap(10,14);
            if(donendeger>10)
            {
                Console.WriteLine("10dan büyük");
            }
            else
            {
                Console.WriteLine("10'dan küçük");
            }
            Console.ReadLine();

            string donenisim = isimsoyisimdondur("buse", "çetin");
            Console.ReadLine();
        }

        static int toplamayap(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }




        static string isimsoyisimdondur(string isim,string soyisim)
        {
            Console.WriteLine("isim ve soyisminiz : "+ isim + " " +soyisim);
            return isim + soyisim;
        }
    }
}

