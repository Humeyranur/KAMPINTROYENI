using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // işlemleri tekrar etmek için kullanılır.

            for (int i = 1; i < 10; i=i+2)  //i+=2
            {
                Console.WriteLine(i);
            }

           //array-dizi

            string[] kurslar = new string[]
            { "yazılımcı geliştirme kursu","java","c#","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }

    }
}
