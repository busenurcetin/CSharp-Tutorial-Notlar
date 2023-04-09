using System;
namespace odevvvv
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
					Console.WriteLine("Öğrenci no 9 karakter olmalı");
				}
				else
				{
					ogrencino = value;
				}
			}
		}
	}
}
