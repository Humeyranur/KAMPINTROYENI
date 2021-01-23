using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention- doğru isimlendirme Ekle nin e si büyük olmalı(metot olduğu için)
        //syntax
        public void Ekle(Urun urun)  // normal parantez bir metodun çalıştığını ifade eder. büyük harfli urun  tipi ifade eder.
        {
            Console.WriteLine("sepete eklendi:" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)  // bu şekilde ayrı ayrı yazmaktansa class oluşturup (Urun) öyle yazarsan yaptığın değişikliği her sayfada değil 1 kere yaparsın.

        {
            Console.WriteLine("tebrikler, sepete eklendi:" + urunAdi);
        }
     }
}
