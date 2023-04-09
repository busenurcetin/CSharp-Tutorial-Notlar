using System;
namespace finaller
{
	public class ogrenci
	{
		private string ogrno = "123";
		public string ogrencino
		{
			get
			{
				return ogrno.Substring(0, 2);
			}
			set
			{
				if(value.Length<9)
				{
					Console.WriteLine(	"9 karakterli olmalı...");
				}
				else
				{
					ogrno = value;
				}
				
			}
			
		}
	}
}
