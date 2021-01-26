using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "Batuhan";
            musteri1.musteriSoyadi = "Zorluoğlu";
            musteri1.musteriDogumYeri = "İskenderun";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "Cihat";
            musteri2.musteriSoyadi = "İleri";
            musteri2.musteriDogumYeri = "Adana";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı :"+musteri.musteriAdi+" "+"Müşteri Soyadı :"+musteri.musteriSoyadi+" "+"Müşteri Id :"+musteri.Id+" "+"Müşteri Doğum Yeri : "+musteri.musteriDogumYeri);
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            MusteriManager musteriListeleme = new MusteriManager();
            musteriListeleme.Listele(musteri1);
            musteriListeleme.Listele(musteri2);

            MusteriManager musteriSilme = new MusteriManager();
            musteriSilme.Silme(musteri1);
            musteriSilme.Silme(musteri2);
            

        }
    }
}
