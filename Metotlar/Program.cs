using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //dry- dont repeat yourself

            //metotlar adının üstünde sağ tık ekle class, SepetManager ismini ver.bir tane daha ekle urun adını ver.
           
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };  //diziler çoğul isimlendirilir mesela urunler


            //type safe --- tip güvenli (hangi tiple çalışacağını bilmek ister bu sebeple Urun u yazmak gerekir.
            foreach (Urun urun in urunler)   
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------------METOTLAR------------"); // cw yazıp 2 kez tab a basarsan uzun halini yazar.

            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();  //sepetmanager sayfasında ekle metodunu tanımladık burada çağırdık, istediğimiz kadar çağırabiliriz.
            sepetManager.Ekle(urun1);   //değişiklik yapmak istediğimizde ayrı ayrı sayfalarda yapmak yerine sadece sepetmanager sayfasından bir kere değiştirmek yeterli olacaktır.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 8);
        }
    }
}
