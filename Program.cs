using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** While ****");

           //While içerisindeki koşul sağlandığı sürece çalışmaya devam eder.

           // 1 den başlayıp girilen sayıya (sayı dahil) kadar olan sayıların ortalaması..
           Console.Write("Lütfen bir sayı giriniz: ");
           int sayi = int.Parse(Console.ReadLine());
           int sayac = 1;
           int toplam = 0;
           while (sayac<=sayi)
           {
                toplam += sayac;
                sayac ++;
           }

           Console.WriteLine("Sayıların Ortalaması: "+(toplam/sayi));

           //a dan z ye kadar olan harflerin yazdırılması.
           char character = 'a';
           while(character<='z')
           {
                Console.Write(character);
                character ++;
           }

           Console.WriteLine("\n**** Foreach ****");
           string[] arabalar = {"Mercedes","Audi","BMW","Nissan"}; 

           foreach (var araba in arabalar) // Dizinin içindeki elemanları teker teker gezerek
                                           // araba değişkenine atama yaptı.
           {
                Console.WriteLine(araba); 
           }

        }
    }
}

