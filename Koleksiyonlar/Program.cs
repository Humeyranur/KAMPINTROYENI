using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[]{"engin","halil","hasan","ahmet"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            
            isimler = new string[5]; //5 elemanlı bir dizi tanımlamış olduk fakat içi boş, sadece 4. indise ali ismini atadık 0. indis yazdırılırsa boş olarak ekrana gelir.
            isimler[4] = "ali";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>(); //arrayleri kullanamadığımız yerde listeler kullanılır. list yazınca altı kırmızı olur ampulden using kısmını ekle.
            

          // birden fazla yorum satırı ekleyeceksen hepsini seç ctrl k + ctrl c geri almak için ctrl k ctrl u (yukarıda simge yardımı ile de yapılabilir.)
            List<string> isimler3 = new List<string> { "engin", "murat", "kerem", "halil" };  //bu şekilde de yazılabilir.
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("ilker");
            Console.WriteLine(isimler3[4]);
            
            //Kendi Koleksiyonumuzu Yazmak -- genericsıntro ya bak orada
       


        }
    }
}
