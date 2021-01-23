using System;

namespace KAMPINTROYENI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmisMi= false;
            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            double dolar1 = 7.45;
            double dolar2 = 7.35;

            if (dolar1 < dolar2)     //şart blokları, ayrıca if yazdıktan sonra tab a 2 kez basarsan parantezleri otomatik açar.
            {
                Console.WriteLine("azalış butonu");
            }

            else if (dolar2 < dolar1)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir");
            }
        }
    }
}
