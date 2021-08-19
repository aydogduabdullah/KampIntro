using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //yazacagımız değikenin turunu başında yazıyourz
            //type safety : tip guvenliği
            //metinsel tanımlamalardada " çift tırnak kullanıyoruz tek tırnak burda kullanmıyourz.
            //bir satırı bitridiğinde ; koymak zorundayız.
            //kendini tekrarlamamalısın.
            //kategori etiketi değer tutucu aiastır (takma ad
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double basariOrani = 4.15;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("AZALIS BUTONU");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("ARTIS BUTONU");
            }
            else
            {
                Console.WriteLine("değismedi butonu");
            }
            
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
