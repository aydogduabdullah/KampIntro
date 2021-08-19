using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) 
        {
            
            
            Console.WriteLine("Yeni urun sepete eklendi : " + urun.Adi+ urun.StokAdedi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Yeni urun sepete eklendi : " + urunAdi);
        }
    }

}
