using System;

namespace hesapmakinası
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek sayı yazdırma
            /*for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                i = i + 1;
                
            }
            Console.ReadLine();*/

            //çift sayı yazdırma

            /*for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                i = i + 1;

            }
            Console.ReadLine();*/
            /*
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            */
            /* 1'DEN 10A KADAR OLAN SAYILARIN TOPLAMINI YAZDIRAN PROGRAM
            int toplam = 0;
            for(int i=1;i<=10;i++)
            {
                toplam += i;

            }
            Console.WriteLine("1'den 10'a kadar olan sayıların toplamı : "+toplam);
            Console.ReadLine();
            */

            /*
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Aydın MYO");
            }
            Console.ReadLine();
            */
            /*
             * ******7' YE KADAR OLAN SAYILARI YAZDIRAN PROGRAM 
             * EĞER SADECE 7 YAZMASIN İSTİYORSAN CONTİUNE YAZ
            for(int i=1;i<=10;i++)
            {
               
                if(i==7)
                {
                    break;
                }

                Console.WriteLine("İ'nin Değeri : "+i);
            }
            Console.ReadLine();
            */
            /*
            int[] sayilar = { 1, 3, 2, 4, 5, 5, 4, 3, 2, 1, 5, 6 };
            int adet = 0;
            int sayi;
            

            
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            

            for(int i=0;i<sayilar.Length;i++)
            {



                    if (sayi == sayilar[i])
                {
                    adet++;
                }

            }
            if(adet==0)
            {
                Console.WriteLine("Dizinin içinde bu sayı yoktur");
            }
            else
            {
                Console.WriteLine("Dizinin içinde bu sayı vardır");
                Console.WriteLine("Adet :"+adet);
            }
            Console.ReadLine();

            */


            //kullanıcının girdiği metni kullanıcının girdiği sayıda ekrana yazdıran program

            /*Console.WriteLine("Bir metin giriniz");
            string a = Console.ReadLine();
            Console.WriteLine(  "Girdiğiniz metni kaç kere yazdırmak istiyorsunuz?");
            int b = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=b;i++)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();*/

            //klavyeden yaşı girilen 10 kişinin kaçının askere gidip gidemeyeceğini bulan c# programı

            //10 kisiden alınan yaş değerlerine göre askere gidip gidemeyeceklerini bulduran program.

            /*

            int i = 0;
            int sayac = 0;
            do
            {
                Console.WriteLine("Lütfen"+" "+(i+1)+". kişinin yaşını giriniz");
                int yas = int.Parse(Console.ReadLine());
                if(yas>=20)
                {
                    sayac++;
                }
                i++;


            } while (i<10);

            Console.WriteLine("Askere gidebilen kişi sayısı="+ sayac);
            Console.WriteLine("Askere gidemeyen kişi sayısı ="+(10-sayac));
            Console.ReadLine();
          */

            // Klavyeden 0’dan büyük sayı girince girilen sayının iki katını bulan, 1’den küçük sayı girince programı sonlandıran programı yazınız?
            //kullanıcı 0 girene kadar sayıları toplayan ve ortalamasını bulan program


            //toplamayap(2, 7);
            //carpmayap(1, 5, 8);
            //isimyazdır();  
        }


    }
}

