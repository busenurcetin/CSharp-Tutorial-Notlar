using System;

namespace okul1
{
    class Program
    {
        static void Main(string[] args)
        {

            int toplam = 0;
            for(int i = 1; i<=10; i++)
            {
                Console.Write((i+0)+". sayıyı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi<0)
                {
                    break;
                }
                else if(sayi==0)
                {
                    toplam += sayi;
                    Console.WriteLine(toplam);
                }
                Console.ReadLine();

            }
        }
    }
}

