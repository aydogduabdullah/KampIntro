using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım gelistiricci yetistirme kampi";
            string kurs2 = "programlaya başlamak icin temel kursu";
            string kurs3 = "java kursu";



            //[]array- dizi

            string[] kurslar = new string[] { "yazılım gelistiricci yetistirme kampi",
                "programlaya başlamak icin temel kurs","java kursu","yebi eleman" };

            
            for (int i = 0; i < kurslar.Length ; i++) //i sayaç anlamında  0 den başla
                                           //3 dan küçük oldugu sürece calıs ve 1 1arttır.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)//Kursları tek tek dolaş.Herbir eleman icinde
                                            //inin solundaki şeyi kullan
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
 }
