using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //manager içeren bir isimlendirme görürsen anlaki içerisinde ürünle ilgili operasyonlar var.
        
       //encapsulation 

       //ürün eklemeyi simüle etmek
        public void Add(Product product) //Product türünde bir şey ver demek. string isim gibi 
        {
            // product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + "eklendi");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

      /* public int Topla(int sayi1, int sayi2) // VOID KULLANIMI
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2) //void git yap bitir demek.programın akışında değer lazımsa tekrar kullanılmaz.void ile return kullanılmaz
        {
            Console.WriteLine( sayi1 + sayi2);
        }
       */


        /*public void BiseyYap(int sayi)
        {
            sayi = 99;
        }*/
    }
}
