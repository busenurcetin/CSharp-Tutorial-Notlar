using System;

namespace switchcase_miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Bakiye Görüntüle
            // 2- Para Çek
            // 3- Para Yatır
            // 4- Çıkış Yap
            //1-2-3-4 dışında bir değer girilmişse çıkış yap

            int bakiye = 800;

            Console.WriteLine("ATM'ye Hoşgeldiniz..");
            Console.WriteLine("Lütfen Bir İşlem Seçiniz");
            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3-Para Yatır");
            Console.WriteLine("4- Çıkış Yap");

            string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz"+ bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    
                    Console.WriteLine("Çekmek İstediğiniz Tutarı Girin" );
                    int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                    if(cekilecektutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz :"+ (bakiye-cekilecektutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    int yatacaktutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel bakiyeniz:"+ (bakiye+yatacaktutar));
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan Çıkış Yapılıyor İyi Günler");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                    Console.ReadLine();
                    break;


            }
        }
    }
}

