using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.AdiSoyadi = "Hümeyra Nur Turgut";
            customer1.Id = 1;
            customer1.KrediPuani = 1850;
            customer1.MusteriAdres = "Kocaeli";

            Customer customer2 = new Customer();
            customer2.AdiSoyadi = "Hasan Esat Paydaş";
            customer2.Id = 2;
            customer2.KrediPuani = 1700;
            customer2.MusteriAdres = "İstanbul";

            Customer customer3 = new Customer();
            customer3.AdiSoyadi = "Mine Demir";
            customer3.Id = 3;
            customer3.KrediPuani = 1300;
            customer3.MusteriAdres = "Ankara";

            Customer customer4 = new Customer();
            customer4.AdiSoyadi = "Fatma Özsoy";
            customer4.Id = 4;
            customer4.KrediPuani = 1250;
            customer4.MusteriAdres = "Trabzon";

            
            CustomerManager musteriManager = new CustomerManager();

            Customer[] musteriler = new Customer[] { customer1, customer2, customer3, customer4 };
            musteriManager.Add(customer1);
            musteriManager.Add(customer2);
            musteriManager.Add(customer3);
            musteriManager.Add(customer4);

            Console.WriteLine("..................");

            musteriManager.Delete(customer1);
            musteriManager.Delete(customer2);
            musteriManager.Delete(customer3);
            musteriManager.Delete(customer4);

            Console.WriteLine("..................");

            musteriManager.ToList(customer1);
            musteriManager.ToList(customer2);
            musteriManager.ToList(customer3);
            musteriManager.ToList(customer4);






        }
    }
}
