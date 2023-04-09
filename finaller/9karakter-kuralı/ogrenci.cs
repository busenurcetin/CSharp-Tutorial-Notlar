using System;
namespace ogrenci
{
	public class ogrenci
	{
		private string ogrencino = "123232";
		public void yaz()
		{
			Console.WriteLine("Yaz metotu çalıştı.");
		}

		public string ogreno
		{
			get
			{
				return ogrencino.Substring(0, 4);
			}
			set
			{
				if(value.Length<9)
				{
					Console.WriteLine("9 karaktere tamamlayın");
				}
				else
				{
					ogrencino = value;
				}
			}
		}
	}
}

