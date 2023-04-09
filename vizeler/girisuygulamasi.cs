using System;

namespace girisuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {


            int haksayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı Adını Giriniz");
                string kullaniciadi = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz");
                string sifre = Console.ReadLine();

                if(kullaniciadi=="buse" && sifre=="123")
                {

                   Console.WriteLine("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                    break;
                }

                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış");
                    if (haksayisi>0)
                    {
                        haksayisi -= 1;
                    }
                    if (haksayisi == 0)
                    {
                        Console.WriteLine("Hakkınız Dolmuştur Daha Giriş Yapamazsınız");
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
