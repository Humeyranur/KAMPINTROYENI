using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();//İhtiyacKrediManager yazsanda bu şekilde olsada çalışır. Interfaceler de interfaceyi implemente eden classın referans numarasını tutar.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            

            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService()); //ihtiyaç kredisine başvurulduğunu düşünelim.
            
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmeYap(krediler); 
        }
    }
}
