using System;
using System.Linq;

namespace MetotlarCalisma
{
    class Program
    {
        static void Main(string[] args) //add metodunu çağırdık.
        {
            Add();
            Add();
            
            
            var result2 = Add2(20, 30);
            Console.WriteLine(result2);


            var result3 = Add3(40);  //tek parametre yazdığımızda hata vermez çünkü diğeri 30 alınacaktır.(yukarıda tek parametre hata verir)
            Console.WriteLine(result3);


            int number1 = 20;
            int number2 = 100;
            var result5 = Add5(number1, number2);
            Console.WriteLine(result5);  //130 - referans tiptir.
            Console.WriteLine(number1); //20 - değer tiptir.
             

            var result6 = Add6(ref number1, number2); // ref ekledik.
            Console.WriteLine(result6);


            int sayi1;
            int sayi2 = 52;
            var result7 = Add7(out sayi1, sayi2); //out ekledik. Out eklediğinde sayi1 e değer vermeyebilirsin fakat ref yazdığında burada değer kesinlikle olmalı.
            Console.WriteLine(result7);


            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add8(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()  //Add adında bir metot tanımladık.Static in altında tanımladığımız için static void diye yazmaya başladık.
        {
            Console.WriteLine("Added!");
        }


        //PARAMETRELİ METOTLAR
        static int Add2(int number1,int number2) //void git şunu yap kayıt yap bir yere bir şey yaz vs. Ama burada sonuç olarak istediğim bir sayı var bu yüzden hangi türden istiyorsak onu yazarız.
        {
            var result2 = number1 + number2;
            return result2;
        }

        //Default Parametreli Metotlarla Çalışmak

        static int Add3(int number1, int number2=30) //number2 ye başka değer verilmediği sürece 30 al demek.
        {
            var result3 = number1 + number2;
            return result3;
        }

        static int Add4(int number1=25, int number2 = 30) //birden fazla default değer verilebilir fakat tek bir değer verilecekse bu en sonda bulunmalı.
        {
            var result4 = number1 + number2;
            return result4;
        }

        //Ref Keyword İle Çalışmak

        static int Add5(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // değerin referans tip olmasını istersek ref yazmalıyız. Hem buraya hem yukarı
        static int Add6(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // ÖRNEK : kredi hesabında normalde değer başka ama müşteri indirim kazandığında değerin değişebileceğini düşünüyorsak buna referans değer ekleriz böylece indirim halinde metotta değer değişir.

        
        //Out Keyword İle Çalışmak
        //mantık olarak ref ile aynıdır. Fakat 
        static int Add7(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }


        //Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) //3 sayı çarpmak istersek, ismini değiştirmeden parametreleri değiştirebiliriz buna method overloading denir.
        {
            return number1 * number2*number3;
        }


        //Params Keyword İle Çalışmak

       // birden fazla parametreyi yollamak için kullanılır

        static int Add8(params int[] numbers)
        {
            return numbers.Sum(); //çalışmazsa yanan ampulden using kısmını ekle. 
        }
    }

}
