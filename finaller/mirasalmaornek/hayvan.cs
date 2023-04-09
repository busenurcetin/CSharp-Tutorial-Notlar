using System;
namespace mirasalmaornek
{
	public class hayvan
	{
		public string hayvanad;
		public string hayvancinsiyet;
		public int hayvanyas;

		public void bilgilerigoster()
		{
			Console.WriteLine("Hayvanın İsmi :"+hayvanad);
			Console.WriteLine("Hayvanın Cinsiyeti :"+hayvancinsiyet);
			Console.WriteLine("Hayvanın Yaşı :"+hayvanyas);
			Console.ReadLine();
		}

	}
}
