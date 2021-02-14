using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //yazdığım MyList i kullanabilmek için;
            MyList<string> isimler = new MyList<string>(); //string listesi oluşturmuş olduk istediğimiz türde oluşturabiliriz.Arka planda t string oldu.
            isimler.Add("engin"); //string ile oluşturduğum için string bir değer vermem gerekir. (engin)
        }
    }
}
