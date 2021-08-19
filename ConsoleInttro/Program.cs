using System;

namespace ConsoleInttro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Abdullah";

            int yas = 16;

            Kurs kurs1=new Kurs() ;
            kurs1.KursAdi = "c++";
            kurs1.Egitmen = "Abdullah Emre";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "MAHMUT";
            kurs2.IzlenmeOrani = 23;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "Rıfkı";
            kurs3.IzlenmeOrani = 50;
             


            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach ( var  kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        } 
    }
    class Kurs
    {
        
        public string KursAdi { get; set; }
        
        public string Egitmen { get; set; }
        
        public int IzlenmeOrani { get; set; }

    }
}
