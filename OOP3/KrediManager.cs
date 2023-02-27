using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface IKrediManager
    {
        //oprerasyonel yapılarda kullanılır
        //birbirini alternatifi olan ama kod içerikleri farklı olan durumlarda kullanılır
        //Hesaplama var ama değşkenlik gösterir 
        void Hesapla();
        void BiseYap();
        
    }
}
