using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); // kurs diye bir tip tanımlayabilmek için kendi classımızı oluşturduk(aşağıda) ve C# a bunu tanıttık. 
            kurs1.KursAdi = "C#";    //E ticaretteki ürünlerde bir class - ürün adı fiyatı özellikleri
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ali";
            kurs3.IzlenmeOrani = 85;

           //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]  {kurs1,kurs2,kurs3}; //içinde kurs nesnesini barındıran bir array tanımladık.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : " + kurs.Egitmen);  //tüm kursları dolaştı ve onların adlarını yazdırdı.yeni kurs eklendiği zaman buraya dokunmadan yukarıda değişiklik yapılır.
              
            }
        }
    }
}

    class Kurs        //class tanımladık. daha sonra özellikler yazdık ve birden fazla veri tutmuş olduk.static void in en dışına bu classı oluşturduk.
    {
    
    public string KursAdi { get; set; }   //prop yaz 2 kez tab a bas. Kurs değişkenimiz oldu ve bu değişken içinde 3 tane özellik tutuyor.
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
    }
