using System;

namespace boyutludiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu şekilde de olabilir...

            //string[,] sinifim = new string[10, 3];
            //sinifim[0, 0] = "123";
            //sinifim[0, 1] = "Buse Nur";
            //sinifim[1, 0] = "Çetin";
            //sinifim[1, 1] = "111";
            //sinifim[2, 0] = "Damla Zeliha";
            //sinifim[2, 1] = "İnce";
            //sinifim[3, 0] = "222";
            //sinifim[3, 1] = "333";



            //for(int i=0;i<10;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.WriteLine(sinifim[i,j]);
            //    }
            //}
            //Console.ReadLine();


            //bu şekilde de olabilir...

            int[,] dizi = new int[3, 2];
            dizi[0, 0] = 10;
            dizi[0, 1] = 11;
            dizi[1, 0] = 12;
            dizi[1, 1] = 13;
            dizi[2, 0] = 14;
            dizi[2, 1] = 15;
            for(int i=0;i<3;i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine(dizi[i,j]);
                }
            }
            Console.ReadLine();
        }
    }
}

