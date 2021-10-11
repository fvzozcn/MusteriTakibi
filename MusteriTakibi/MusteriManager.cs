using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakibi
{
	class MusteriManager
	{
		public void Ekle(Musteri musteri)
		{
			Random r = new Random();
			Console.WriteLine("Müşteri Adı Giriniz : ");
			musteri.MusteriAdi = Console.ReadLine();
			if (musteri.MusteriAdi == "")
			{
				Console.WriteLine("Müşteri Eklenemedi.");
			}
			else
			{
				musteri.HesapNo = r.Next(1, 9999);
				musteri.MusteriAdres = Console.ReadLine();
				
			}

		}
		public void Sil(Musteri musteri)
		{
			Console.WriteLine(musteri.MusteriId + " | " + musteri.MusteriAdi + " "+ "Müşteri Silinmiştir.");
		}
		public void Listeleme(Musteri musteri)
		{
			Console.WriteLine(musteri.MusteriId + " | " + musteri.MusteriAdi + " " + "Müşteri Listelenmiştir.");
		}
	}
}
