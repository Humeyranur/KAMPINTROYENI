using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Döngüler birbirine benzeyen işlemleri tekrar etmek için kullanılır.

            for (int i = 1; i < 10; i=i+2)  //i+=2
            {
                Console.WriteLine(i);
            }


           //array-dizi
           //elimizde birden fazla değişken varsa(e ticaret sistemi) hepsini string vs. diye tek tek tanımlamak yerine dinamik bir şekilde dizilerde tutarız. Pythonda listelerde tutulur.

            string[] kurslar = new string[] //javada s büyük yazılır.
            { "yazılımcı geliştirme kursu","java","c#","python" }; //birden fazla string tutmak istiyoruz.

            for (int i = 0; i < kurslar.Length; i++) //length ile dinamik yapı oluşturuldu. Diziye başka elemanlar eklensede burada değişiklik yapmaya gerek kalmaz.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu-footer");

            foreach (string kurs in kurslar) // dizi temelli yapıları dönmeye yarar. string kısmında var da yazılı olsa çalışır.
            {
                Console.WriteLine(kurs);  //kurs burada aliastır herhangi bir şey yazılabilir.
            }
        }

    }
}
