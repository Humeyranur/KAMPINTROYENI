using System;

namespace ödevdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Telefon";
            urun1.urunId = 1;
            urun1.satisOranı = 90;
            urun1.garantiSuresi = 2;

            Product urun2 = new Product();
            urun2.urunAdi = "Bilgisayar";
            urun2.urunId = 2;
            urun2.satisOranı = 70;
            urun2.garantiSuresi = 2;

            Product urun3 = new Product();
            urun3.urunAdi = "Ayakkabı";
            urun3.urunId = 3;
            urun3.satisOranı = 85;
            urun3.garantiSuresi = 1;

            Product urun4 = new Product();
            urun4.urunAdi = "Mouse";
            urun4.urunId = 4;
            urun4.satisOranı = 75;
            urun4.garantiSuresi = 1;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };


            
            Console.WriteLine("....................................");
            Console.WriteLine("FOR DÖNGÜSÜ");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " " + urunler[i].urunId + " " + urunler[i].satisOranı + " " + urunler[i].garantiSuresi);
            }

            
            Console.WriteLine("....................................");
            Console.WriteLine("FOREACH DÖNGÜSÜ");
           
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.urunAdi+" " + product.urunId+" "+ product.satisOranı+" "+ product.garantiSuresi);
            }

            
            Console.WriteLine("....................................");
            Console.WriteLine("WHİLE DÖNGÜSÜ");
            
            int a = 0;
            while (a<4)
            {
                Console.WriteLine(urunler[a].urunAdi + " " + urunler[a].urunId + " " + urunler[a].satisOranı + " " + urunler[a].garantiSuresi);
                a++;
            }
        }
    }
}


   class Product
   {
    public string urunAdi { get; set; }
    public int urunId { get; set; }
    public int satisOranı { get; set; }
    public int garantiSuresi { get; set; }
}
