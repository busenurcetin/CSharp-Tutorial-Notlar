using System;

namespace breakVEcontiune
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a=1; a<=10;a++)
            {
                if (a==7)
                {
                    continue; //break dersen 7'ye kadar devam eder continue kullanırsan 7'yi kullanmadan 10'a kadar devam eder.
                }
                Console.WriteLine("A nın değeri :" +a);
            }
            Console.ReadLine();
        }
    }
}

