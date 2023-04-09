using System;

namespace mirasalmaornek
{
    class Program
    {
        static void Main(string[] args)
        {

            kedi kedi1 = new kedi();
            kedi1.hayvanad = "Boncuk";
            kedi1.hayvancinsiyet = "Dişi";
            kedi1.hayvanyas = 18;
            kedi1.bilgilerigoster();
            
        }
    }
}

