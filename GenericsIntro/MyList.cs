using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{ 
    //generic class çalışacağımız özel bir tip olduğunu ifade eder.
    class MyList <T> //t yerine herhangi bir şey yazılabilir. mylist te t ile çalışıcam demek.Tip demek string vs. gibi
    {
        T [] items; //MyList i hafızada tutabilmek için yazarız. Classın altına yazma sebebi istediğim her metottan erişim sağlayabilmek

        //constructor
        public MyList() //classı new lediğinde burayı oluşturman gerekir. ctor yaz 2 tab
        {
            items = new T[0]; //  0 elemanlı class oluşturduk.Artık aşağıda diziye eleman ekleyebiliriz. 
        }
        
        public void Add(T item) //String vs. ile kısıtlamaktansa kullanıcı ne belirlerse türü o olsun diye t yazılır. item kısmına istenen yazılabilir
        {
            T[] tempArray = items; // diziyi new leyince referans değerlerinin gitmemesi için geçici bir yere aktardık. 
            items = new T[items.Length + 1]; //oluşturulan dizinin eleman sayısını 1 artır demek.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                    //tutulan değerleri görmek için for döngüsünden faydalanırız.
            }

            items[items.Length - 1] = item;

        }
    }
}
