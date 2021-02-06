using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();   //Class oluştur-instance
            dortIslem.Topla(5, 6);  //Metodu çağır
            dortIslem.Topla(8, 4);
            
        }
    }
}
