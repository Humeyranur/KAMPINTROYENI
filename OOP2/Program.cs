using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Hümeyra";
            //musteri1.Soyadi = "Turgut";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?"; //şahısın şirket adı olmaz dolayısıyla bu kullanılmayan alandır. Hatalıdır.

            //SOLID - L 


            //inheritance tanımladıktan sonra;

            //Hümeyra Nur TURGUT = gerçek müşteri oluşturma

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1; 
            musteri1.MusteriNo = "12332";
            musteri1.Adi = "Hümeyra Nur";
            musteri1.Soyadi = "Turgut";
            musteri1.TcNo = "1234567890";

            //Kodlama.io = tüzel müşteri oluşturma

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "154564865";

            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();


            CustomerManager customerManager = new CustomerManager(); //instance
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);


        }
    }
}
