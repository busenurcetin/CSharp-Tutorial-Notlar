using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace csharpegitim
{
   internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 7;
            //int sayi2 = 6;
            //int sonuc = sayi1 * sayi2;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            // mod alma operatörü bir sayıyı diğerine böldüğümüzde o bölümden kalanı verir.%

            //int sayi1 = 10;
            //int sayi2 = 3;
            //int sonuc = sayi1 % sayi2;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //int sayi = 10;

            //sayi++;
            //Console.WriteLine(sayi);
            //Console.ReadLine();

            // sayi++ değeri bir arttırır
            //sayi--  değeri bir azaltır.

            //int sayi1 = 4;
            //int sayi2 = 4;
            //bool Kontrolet= sayi1 == sayi2;
            //Console.WriteLine(Kontrolet);
            //Console.ReadLine();

            //int sayi1 = 4;
            //int sayi2 = 4;
            //bool kontrolet = sayi1 != sayi2;
            //Console.WriteLine(kontrolet);
            //Console.ReadLine();

            //int yas = 18;
            //bool kontrolet = yas >= 18;
            //Console.WriteLine(kontrolet);
            //Console.ReadLine();

            //int sayi1 = 29;
            //int sayi2 = 15;
            //bool kontrol = sayi1 <= sayi2;
            //Console.WriteLine(kontrol);
            //Console.ReadLine();

            //&& (Ve operatörü verilen tüm koşullar sağlanırsa true döner. bir tanesi bile yanlış olursa false döner)

            //int sayi1 = 5;
            //int sayi2 = 10;
            //int sayi3 = 10;
            //bool kontrol = sayi1 != sayi2 && sayi1 < sayi3;
            //Console.WriteLine(kontrol);
            //Console.ReadLine();

            //alt ve - bu tuşa basarak veya operatörü simgesi olan veya operatörünü (|| bunu) yazabilirsin
            //veya operatörü ve operatörünün tam tersi gibidir. eğer bir tane bile sayı true dönmüşse true kabul eder.

            //int sayi1 = 7;
            //int sayi2 = 10;
            //int sayi3 = 20;
            //bool kontrol = sayi1 == sayi2 || sayi2 < sayi3;
            //Console.WriteLine(kontrol);
            //Console.ReadLine();

            //değil operatörü= !
            //var olan bir şeyi zıttına çevirir.

            //bool a = true;
            //Console.WriteLine(!a);
            //Console.ReadLine();

            //normalde true dünecekti ama değil ! koyduğumuz için tam tersi yani false döndü

            //   +=
            //   -=
            //   /=
            //   *=

            //int a = 5;
            //a = a + 5;
            //a değeri 5ti ama 5 daha ekledik artık a değeri 10 bunun kısaltılmış versiyonu:


            //a += 5;
            //Console.WriteLine(  "A'nın Değeri= " + a);
            //Console.ReadLine();

            //breakpoint tek tek kodların üzerinden geçmedir.

            //int a = 3;
            //int b = 5;
            //int c = 10;
            //int sonuc = a + b + c;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();


            //Kullanıcıdan Değer Almak İçin Readline Fonksiyonu Kullanılır.
            /////
            //Console.WriteLine(  "Lütfen Adınızı Giriniz...");
            //string isim = Console.ReadLine();

            //Console.WriteLine(  "Soyisminizi Giriniz...");
            //string soyisim = Console.ReadLine();

            //Console.WriteLine(  "Kullanıcının İsmi : " + isim);
            //Console.WriteLine(  "Kullanıcının Soyismi : "+ soyisim);
            //Console.ReadLine();

            // TÜR DÖNÜŞÜMLERİ

            //***** STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRME

            //string sayi1 = "1";
            //string sayi2 = "2";
            //Console.WriteLine(sayi1+sayi2);
            //Console.ReadLine();

            //string değerler toplanamadığı için 1 ve 2 yi yanyana yazdırarak 12 değerini verdi
            // stringten inte dönüştürmek için 2 alternatifimiz var. 1.si int.parse

            //string sayi1 = "1";
            //string sayi2 = "2";

            //int a = int.Parse(sayi1);// sayı 1 değerini inte dönüştür
            //int b = int.Parse(sayi2);

            //Console.WriteLine(a + b);
            //Console.ReadLine();

            //ikinci yöntem=
            // ya int.parse ya da converttoint32 metodunu kullanacaksın.

            //string sayi1 = "1";
            //string sayi2 = "2";
            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);

            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //*************İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜME YAPALIM

            //int sayi1 = 5;
            //int sayi2 = 10;

            //string a = sayi1.ToString();
            //string b = sayi2.ToString(); //ToString elimizdeki değerleri stringe dönüştürmemize yarar bu değerler int double float vs olabilir.
            //Console.WriteLine(a+b);
            //Console.ReadLine(); //string değerler toplanamayacağı için yan yana yazdırılır.

            //**************** DOUBLE VERİ TİPİDEN İNT VERİ TİPİNE DÖNÜŞÜM

            //double sayi = 5.22;
            //int a = Convert.ToInt32(sayi);

            //Console.WriteLine(a);
            //Console.WriteLine(sayi.GetType());
            //Console.ReadLine();

            // int veri yipi tam sayıları tuttuğu için 5.22 yerine 5 olarak alır.

            //****** KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR.

            //Console.WriteLine("lütfen yaşınızı giriniz");

            //string kullaniciyas = Console.ReadLine();

            //int kullaniciyasInt = int.Parse(kullaniciyas); //1. dönüşüm

            //    int kullaniciyasInt2 = Convert.ToInt32(kullaniciyas); //2. dönüşüm

            //Console.WriteLine(kullaniciyasInt);
            //Console.WriteLine(kullaniciyasInt2);
            //Console.ReadLine();

            //kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran program

            Console.WriteLine("Lütfen ilk sayıyı giriniz");

            string sayi1 = Console.ReadLine();

            Console.WriteLine("İkinci sayıyı giriniz");
            string sayi2 = Console.ReadLine();

            int sayi1Int = int.Parse(sayi1);
            int sayi2Int = int.Parse(sayi2);

            Console.WriteLine("iki sayının toplamı : " + ( sayi1Int+sayi2Int));
            Console.ReadLine();

            // Bu kısımda aşağıda yazanları gördük
            //ToString();
            //Convert.ToInt32();
            //int.Parse();
            //double.Parse();
            //(int)
        }
    }
}

