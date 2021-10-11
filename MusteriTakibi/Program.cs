using System;

namespace MusteriTakibi
{
	class Program
	{
		static void Main(string[] args)
		{
			MusteriManager manager = new MusteriManager();
			Musteri musteri = new Musteri();
			Console.WriteLine("Yapılacak İşlem : ");
			string yapilacak=Console.ReadLine();
			if(yapilacak=="Ekle")
			{
				manager.Ekle(musteri);
			}
			else if(yapilacak=="Listeleme")
			{
				manager.Listeleme(musteri);
			}
			else if (yapilacak=="Silme")
			{
				manager.Sil(musteri);
			}

			
			
			
			
		}
	}
}
