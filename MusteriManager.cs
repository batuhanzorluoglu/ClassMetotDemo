using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :" + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriDogumYeri + " " + musteri.Id);
        }
        
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :" + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriDogumYeri + " " + musteri.Id);
        }
            
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + musteri.musteriDogumYeri + " " + musteri.Id);
        }
        
            
            
        
    }
}
