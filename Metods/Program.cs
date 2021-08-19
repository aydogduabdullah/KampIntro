using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elmasi";

            string[] meyveler = new string[] {"elma","karpız" };





            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 29;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpız";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Beyaz cıktı diyen kimdi";


            Urun[] urunler = new Urun[] {urun1,urun2 };
            // tiğ güvenli çalısacagm turu bılmem gerek o yuzden ılk bastakı Urun 
            //veri tipini kasteder
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("------------Metodlar----------");
            //instance örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("ayva","sarıarmut",12,2);
            sepetManager.Ekle2("karpuz", "sarıkaprz", 122,2);
            sepetManager.Ekle2("elma", "sarıarmut", 15,2);


        }
    }
}


// Dont repeat urself.- Clean Code - Best Practice