using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   //Manager isimlendirmesi içerisinde operasyon tuttuğunu gösterir.
        //naming convention- doğru isimlendirme Ekle nin e si büyük olmalı(metot olduğu için)
        //syntax

        //METOT OLUŞTURMA
        //PYTHON DA DEF İLE BURADA PUBLİC VOİD İLE YAPILIR.
        // normal parantez görürsen burada bir metodun çalıştığını anla. büyük harfli urun  tipi ifade eder.
        public void Ekle(Urun urun)  // Neyi eklemek istediğimizi belirtmemiz gerekir bu sebeple Urun urun yazarız. Büyük Urun tip Küçük urun alias.Bunu yaparsak program.cs deki eklenin içine de urun1 veya urun2 yazmak gerekir.
        {
            Console.WriteLine("Tebrikler sepete eklendi:" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)  // bu şekilde ayrı ayrı yazmaktansa class oluşturup (Urun) öyle yazarsan yaptığın değişikliği her sayfada değil 1 kere yaparsın. bir kere urun.cs den prop eklemen yeterli olur ama bu şekil olursa her sayfada yapman gerekir.

        {
            Console.WriteLine("tebrikler, sepete eklendi:" + urunAdi);   //ekle2 yi tanımladıktan sonra program.cs ye geç
        }
     }
}


//encapsulation tek tek yazmak yerine (string urunAdi, string aciklama, double fiyat, int stokAdedi) toplu şekilde yazılması(Urun urun)