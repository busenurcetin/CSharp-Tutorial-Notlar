using System;

namespace bedenkitleendeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Kilonuzu Giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Boyunuzu Giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);

            if(bke<18)
            {
                Console.WriteLine("Zayıfsınız");
                Console.ReadLine();
            }
            else if(bke>18&& bke<25)
            {
                Console.WriteLine("İdeal Kilodasınız");
                Console.ReadLine();
            }
            else if(bke>=25)
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();
            }
          
        }
    }
}
