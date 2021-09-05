using System;

namespace Tanımlama__Erişim_ve_Döngülerle_Dizi_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Köpek", "İnek", "Ceylan", "Zürafa" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mor";

            dizi[3] = 12;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);


            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalaması
            Console.Write("Lütfen dizinin uzunşuğunu giriniz: ");
            int diziuzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " +toplam/diziuzunlugu);
            
            Console.ReadLine();
        }
    }
}
