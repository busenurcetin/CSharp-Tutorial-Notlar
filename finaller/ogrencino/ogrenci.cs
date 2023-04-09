using System;
namespace ogrencıno
{
	public class ogrenci
	{
		private string ogrencino = "123";
		public string ogrno
		{
			get
			{
				return ogrencino.Substring(0, 2);
			}
			set
			{
				if(value.Length<9)
				{
					Console.WriteLine("9 karakterli olmalı");
				}
				else
				{
					ogrencino = value;
				}
			}
		}
	}
}

