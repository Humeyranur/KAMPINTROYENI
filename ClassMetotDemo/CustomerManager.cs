using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
        Console.WriteLine("Müşteri Başarı ile eklendi:" + " " + musteri.AdiSoyadi);
        }

        public void Delete(Customer musteri)
        {
            Console.WriteLine("Müşteri adres bilgileri başarı ile silindi:" + " " + musteri.MusteriAdres );
        }

        public void ToList(Customer musteri)
        {
            Console.WriteLine("Müşteriler Kredi puanına göre listelendi:" + " " + musteri.KrediPuani);
        }
    }
}
