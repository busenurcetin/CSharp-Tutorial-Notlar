using System;

namespace parametrealangeriyedegerdondurenmetot
{
    class Program
    {
        static void Main(string[] args)
        {
            //parametre alan geriye değer döndüren metot tanımlama
            //RETURN

           int donendeger= toplamayap(1, 3);
            Console.ReadLine();
           
        }

        static int toplamayap(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
           
        }
    }
}
