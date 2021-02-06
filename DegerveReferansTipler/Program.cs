using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10; 
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);   //sayi1= 30 olur.



            int[] sayilar1 = new int[] { 10, 20, 30,40 }; //int array 
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1 in referans değeri sayilar2 nin referans değerine eşit demek. Bu eşitliği yazdığın an sayilar1 sayilar2 nin adresini tutuyor demek.
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]); //sayilar1[0]=999 olur

            //int, decimal, float, double, bool = değer tip
            //array, class, interface = referans tip
            // bellekte stack ve heap adında 2 alan vardır. değer tip stackte, referans tip hem stack hem heapte çalışır.


            //değer tip değeri kopyalar ve işi biter.
            //değişkeni stackte tanımlar. new dediğin anda sayılar1 için yeni bir alan oluştur ve değerini yaz demek.
        }
    }
}
