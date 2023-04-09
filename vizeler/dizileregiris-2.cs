using System;

namespace dizileregiris_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = { "BUSE", "DAMLA", "HAKAN" };
            double[] ondaliklisayilar ={ 1.54, 2.58, 3.2, 4.5};

            /*Console.WriteLine(isimler[2]);
            Console.ReadLine();*/
            char[] karakter = { '*', '!', '#' };
            for(int i=0;i< karakter.Length;i++)
            {
                Console.WriteLine(karakter[i]);
            }
            Console.ReadLine();
        }
    }
}

