using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T> //t yerine herhangi bir şey yazılabilir. mylist imde t ile çalışıcam demek.Tip demek string vs. gibi
    {
        T [] items;
        public void Add(T item) //String vs. ile kısıtlamaktansa kullanıcı ne belirlerse türü o olsun diye t yazılır.
        { }
    }
}
