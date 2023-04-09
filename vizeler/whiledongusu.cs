using System;

namespace whiledongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;

            //while(a<=10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //Console.ReadLine();

            //100den 0'a kadar olan sayıların büyükten küçüğe ççiftlerini yazdıralım

            //int a = 100;
            //while(a>=0)
            //{
            //    Console.WriteLine(a);
            //    a -= 2;  //a=a-2'de yazabilirsin.
            //}

            //Console.ReadLine();

            // DO-WHILE ILE 1'DEN 10A KADAR OLAN SAYILARI YAZMA

            //int a = 1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a<=10);

            //Console.ReadLine();

            //DO-WHİLE İLE 1'DEN 100'E KADAR OLAN SAYILARIN TOPLAMI

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a<=100);

            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı" +""+toplam);
            Console.ReadLine();
        }
    }
}

