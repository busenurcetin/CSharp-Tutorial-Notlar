using System;

namespace _9_classlardanobjeoluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba();

            araba1.kapisayisi = 4;
            araba1.arabarengi = "Kırmızı";
            araba1.arabamodeli = "Opel";

            araba1.KapilariKilitle();
            araba1.MotorCalistir();

            Console.WriteLine("Arabanın Kapı Sayısı : "+ araba1.kapisayisi);
            Console.WriteLine("Arabanın Rengi : "+ araba1.arabarengi);
            Console.WriteLine("Arabanın Modeli : "+ araba1.arabamodeli);
            Console.ReadLine();
        }
    }
}

