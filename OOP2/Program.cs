using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Alpaslan";
            musteri1.Soyadi = "Tiryakioğlu";
            musteri1.TcNo = "231321321";



            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "546465";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "13212313232";

            //gerçek müşteri - tüzel müşteri
            //solid

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
                

            
        }
    }
}
