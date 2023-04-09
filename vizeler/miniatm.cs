using System;

namespace miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz : " + bakiye);
                Console.ReadLine();

            }

            else if(secim=="2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı girin");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar <= bakiye)
                {
                    Console.WriteLine("Kalan Tutar :" + (bakiye - cekilecektutar));
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                        }
            }
            else if(secim=="3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                int yatacaktutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Güncel Bakiyeniz :" + (bakiye+yatacaktutar));
                Console.ReadLine();
            }

            else if(secim=="q")
            {
                Console.WriteLine("ATM'den Çıkış Yapılıyor...");
                Console.WriteLine("Çıkış Yapıldı İyi Günler...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz.");
                Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}

