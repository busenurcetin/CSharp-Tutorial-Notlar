using System;

namespace diziornek_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan 10 tane değer alıp kaç çift kaç tek var kontrol et çiftleri topla
            //tekleri topla, çiftler mi büyük tekler mi yazdır.

            int[] sayilar = new int[10];
            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayilarinToplami = 0;
            int CiftSayilarinToplami = 0;
            int kullanicideger;

            for(int i=0;i<sayilar.Length; i++)
            {
                Console.WriteLine((i+0)+". index değerini giriniz : ");
                kullanicideger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = kullanicideger; //dizinin içini kullanıcıdan aldığımız değerlerle doldurduk.
            }

            for(int j=0; j<sayilar.Length;j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftAdetToplam++;
                    CiftSayilarinToplami += sayilar[j];

                }
                else
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }
            }

            if(CiftSayilarinToplami>tekSayilarinToplami)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür");

            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür");
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Çift sayıların Toplamı : " +CiftSayilarinToplami);
            Console.WriteLine("Çift Sayıların Adedi : " + ciftAdetToplam);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Tek sayıların toplamı : " + tekSayilarinToplami);
            Console.WriteLine("Tek sayıların adedi : " + tekAdetToplam);
            Console.ReadLine();
        }
    }
}

