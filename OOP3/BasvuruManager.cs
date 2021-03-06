﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)//hepsini tutan değer IKrediManager
        {
            //başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
              loggerService.Log();
            }
            

        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
