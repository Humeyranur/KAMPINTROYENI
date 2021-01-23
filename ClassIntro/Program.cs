using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.egitmen = "engin";
            kurs1.izlenmeoranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "Java";
            kurs2.egitmen = "Ahmet";
            kurs2.izlenmeoranı = 75;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Python";
            kurs3.egitmen = "Ali";
            kurs3.izlenmeoranı = 85;

            //Console.WriteLine(kurs1.Kursadi + " " + kurs1.egitmen);

            Kurs[] kurslar = new Kurs[]  {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi);    //tüm kursları dolaştı ve onların adlarını yazdırdı.
            }
        }
    }
}

class Kurs        //class tanımladık. daha sonra özellikler yazdık ve birden fazla veri tutmuş olduk.static void in en dışına bu classı oluşturduk.
{
    public string Kursadi { get; set; }   //prop yaz 2 kez tab a bas.
    public string egitmen { get; set; }
    public int izlenmeoranı { get; set; }
}