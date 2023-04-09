using System;

namespace icicefordongusu
{
    class Program
    {
        static void Main(string[] args)
        {
           static void hesapla(int sayi1,int sayi2, string islem)
            {
                if (islem=="+")
                {
                    return sayi1 + sayi2;
                }
                else if (islem=="-")
                {
                    return sayi1 - sayi2;

                }
                else if(islem=="*")
                {
                    return sayi1 * sayi2;
                }
                else if(islem=="/")
                {
                    return sayi1 / sayi2;
                }
            }

        }
     
    }
}
