using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //product oluşturmak için
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };  // bu şekilde de yazılabilir.


            //instance create
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);  // referans tip olduğu için adresteki değeri okur ve masa yerine kamera yazar.

            /* int sayi = 100;
             productManager.BiseyYap(sayi);
             Console.WriteLine(sayi); */  // int değer tip olduğu için değeri verdiğin an bağlantı kesilir ve 100 değerini alır.


           /* productManager.Topla2(3, 6);

            int toplamasonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamasonucu*2); */
        }
    }
}
