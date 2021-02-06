using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Tanımladığımız class'tan nesneler oluşturuyoruz.

        Product product1 = new Product();
        product1.Id = 1;
        product1.ProductName = "Masa";
        product1.ProductPrice = 1000;
        product1.ProductDescription = "Ahşap Masa";

        Product product2 = new Product();
        product2.Id = 2;
        product2.ProductName = "Halı";
        product2.ProductPrice = 1200;
        product2.ProductDescription = "Yün Halı";

        Product product3 = new Product();
        product3.Id = 3;
        product3.ProductName = "Tabak";
        product3.ProductPrice = 50;
        product3.ProductDescription = "Porselen Tabak";

        Product product4 = new Product();
        product4.Id = 4;
        product4.ProductName = "Tava";
        product4.ProductPrice = 100;
        product4.ProductDescription = "Teflon Tava";

        Product product5 = new Product();
        product5.Id = 5;
        product5.ProductName = "Televizyon";
        product5.ProductPrice = 5000;
        product5.ProductDescription = "Smart TV";

        // classımızın türünde bir dizi tanımlayıp nesnelerimizi bu dizinin içine atıyoruz.

        Product[] products = new Product[] { product1, product2, product3, product4, product5 };

        // for döngüsü ile ürünleri listeliyoruz.

        Console.WriteLine("** For Döngüsü ile Listeleme **");
        Console.WriteLine();

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Ürün ID          :" + products[i].Id);
            Console.WriteLine("Ürün Adı         :" + products[i].ProductName);
            Console.WriteLine("Ürün Fiyatı      :" + products[i].ProductPrice);
            Console.WriteLine("Ürün Açıklaması  :" + products[i].ProductDescription);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        // foreach döngüsü ile ürünleri listeliyoruz.

        Console.WriteLine("** Foreach Döngüsü ile Listeleme **");
        Console.WriteLine();

        foreach (var product in products)
        {
            Console.WriteLine("Ürün ID          :" + product.Id);
            Console.WriteLine("Ürün Adı         :" + product.ProductName);
            Console.WriteLine("Ürün Fiyatı      :" + product.ProductPrice);
            Console.WriteLine("Ürün Açıklaması  :" + product.ProductDescription);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        // while döngüsü ile ürünleri listeliyoruz.

        Console.WriteLine("** While Döngüsü ile Listeleme **");
        Console.WriteLine();

        int k = 0;
        while (k < 5)
        {
            Console.WriteLine("Ürün ID          :" + products[k].Id);
            Console.WriteLine("Ürün Adı         :" + products[k].ProductName);
            Console.WriteLine("Ürün Fiyatı      :" + products[k].ProductPrice);
            Console.WriteLine("Ürün Açıklaması  :" + products[k].ProductDescription);
            k++;
            Console.WriteLine("-----------------------------------");
        }
    }
}

// Product adında bir class oluşturup, property'lerini tanımlıyoruz.
class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int ProductPrice { get; set; }
    public string ProductDescription { get; set; }
}
