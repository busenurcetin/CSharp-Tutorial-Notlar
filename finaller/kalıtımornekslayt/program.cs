using System;

namespace kalıtımornekslayt
{
    class Program
    {
        static void Main(string[] args)
        {
            ucgen ucgen1 = new ucgen();
            ucgen1.genislik = 10;
            ucgen1.yukseklik = 2;
            ucgen1.goster();
            Console.WriteLine("Üçgenin Alanı:"+ucgen1.alan());
            Console.ReadLine();
        }
    }
}

