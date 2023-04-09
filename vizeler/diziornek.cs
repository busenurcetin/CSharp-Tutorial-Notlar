using System;

namespace diziornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının Girdiği Sayı Dizide Var Mı?

            int[] sayilar = { 12, 12, 23, 45, 54, 45, 65, 3, 3, 2, 13, 45, 67, 78, 87, 78 };
            int adet = 0;
            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz : ");

            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if(adet==0)
            {
                Console.WriteLine("Dizinin İçinde Bu Sayı Yoktur.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Vardır");
                Console.WriteLine("Adet : "+adet);
            }

            Console.ReadLine();
        }

    }
}

