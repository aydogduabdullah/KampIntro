using System;

namespace ClassIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Abdullah";
            string tc = "465464";
            int yas = 32;
            Kurs kurs1 = new Kurs();
            kurs1.EgitmenAdi = "Abdullah";
            kurs1.IzlenmeOrani = 85;
            kurs1.KursAdi = "c#";

            Kurs kurs2 = new Kurs();
            kurs2.EgitmenAdi = "Emre";
            kurs2.IzlenmeOrani = 95;
            kurs2.KursAdi = "c++";


            Kurs kurs3 = new Kurs();
            kurs3.EgitmenAdi = "Aydoğdu";
            kurs3.IzlenmeOrani = 81;
            kurs3.KursAdi = "python";

            //onsole.WriteLine(kurs1.Kursadi + ":"+kurs1.EgitmenAdi);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };

            foreach (var kurs in kurslar) ;
            {
                Console.WriteLine(Kurs.KursAdi);
            }
        }

        class Kurs
        {
            public string Kursadi { get; set; }

            public int IzlenmeOrani { get; set; }

            public string EgitmenAdi { get; set; }

        }
    }
