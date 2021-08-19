using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
    

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;  // değer tiplerde sayı1=sayı2dediğinde sayının değerini kopyalar ve işi orda diğer sayıyla biter
            sayi2 = 65;

            //int ,decimal,float,double,bool=değer tiptir
            
            Console.WriteLine(sayi1);// cevap 30 olur 
            
            // array,class,interface = referans tiptir
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//cevap 999 olur 


        }
    }
}
