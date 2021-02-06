using System;

namespace KAMPINTROYENI
{
    class Program
    {
        static void Main(string[] args) //main bir fonksiyon(metottur).
        {
            string kategoriEtiketi = "Kategori";//pythonda direk kategoriEtiketi = "kategori" olarak yazılabilir. burada türünü yazmak zorunludur. Buna TYPE SAFETY denir.(javada da yazılmalıdır.)
                                                //Pythonda tek tırnakta kullanılabilir, burada olmaz ve bu progr. noktalı virgül kullanımı zorunludur. 
            Console.WriteLine(kategoriEtiketi); //bu kodda yapılacak bir değişiklik varsa sadece kategori kısmında yapılması yeterli olacaktır. Kodun kullanıldığı her sayfaya bu değişiklik yansıyacaktır.
                                                //DON'T REPEAT YOURSELF-DRY-Kendini tekrarlama
                                                // değer tutucu - alias (takma isim)

            //değişkenler veri tutuculardır. bool javada boolean diye yazılır.
            bool sistemeGirisYapmisMi = false;  //Burası gerçek hayatta sistemden, veri kaynağından gelir. 
            if (sistemeGirisYapmisMi== true)    //if-else bloğu 2 durum geçerli ise çalışır.
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)     //şart blokları, ayrıca if yazdıktan sonra tab a 2 kez basarsan parantezleri otomatik açar.
            {
                Console.WriteLine("artış butonu"); //if - else if- else 2 den fazla durum geçerli ise
            }

            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
        }
    }
}
