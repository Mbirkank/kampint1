﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var loggerServices in loggerService)
            {
                loggerServices.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
            }
        }
    }
}