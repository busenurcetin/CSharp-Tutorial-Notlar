using System;
namespace allahımyardımet
{
	public class deneme
	{
		private int ogreno;
		private int vize1;
		private int vize2;
		private int final;
		private string isim;
		private string soyisim;
		private string okulisim;

		public deneme(int _ogreno,string _isim)
		{
			ogreno = _ogreno;
			isim = _isim;
		}

		public void ogrencibilgileri()
		{
			Console.WriteLine("Öğrencinin ismi"+isim);
            Console.WriteLine("Öğrencinin soyismi" + soyisim);
            Console.WriteLine("Öğrencinin okulno" + ogreno);
            Console.WriteLine("Öğrencinin okul ismi" + okulisim);
        }
		public double ortalamabul()
		{
			double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
			return ortalama;
		}
		public void okulgetir()
		{
			Console.WriteLine("Öğrencinin Okulu :"+okulisim);
		}
    }
}

