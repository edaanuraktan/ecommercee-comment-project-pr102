using System;
using System.Collections.Generic;

namespace IntroToPcEngineeringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> puanlar = new List<int>();
            List<string> yorumlar = new List<string>();

            Console.WriteLine("\n\nÜrün değerlendirme sistemine hoş geldiniz.\n");

            while (true)
            {
                Console.Write("Ürüne 1-5 arası bir puan verin: ");
                if (int.TryParse(Console.ReadLine(), out int puan) && puan >= 1 && puan <= 5)
                {
                    puanlar.Add(puan);
                }
                else
                {
                    Console.WriteLine("Geçersiz puan. Lütfen 1 ile 5 arasında bir sayı girin.");
                    continue;
                }

                Console.Write("Ürünle ilgili yorum yapmak ister misiniz? (e/h): ");
                string yorumCevap = Console.ReadLine()?.Trim().ToLower();

                if (yorumCevap == "e")
                {
                    Console.Write("Yorumunuz: ");
                    string yorum = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(yorum))
                    {
                        yorumlar.Add(yorum);
                    }
                }

                Console.Write("Değerlendirmeyi sonlandırmak ister misiniz? (e/h): ");
                string cikisCevap = Console.ReadLine()?.Trim().ToLower();
                if (cikisCevap == "e")
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n--- Ürün Puan Ortalaması ---");
            if (puanlar.Count > 0)
            {
                double ortalama = puanlar.Average();
                Console.WriteLine($"Ortalama Puan: {ortalama:F2}");
            }
            else
            {
                Console.WriteLine("Henüz puan verilmemiş.");
            }

            Console.WriteLine("\n--- Yapılan Yorumlar ---");
            if (yorumlar.Count > 0)
            {
                foreach (var yorum in yorumlar)
                {
                    Console.WriteLine("- " + yorum);
                }
            }
            else
            {
                Console.WriteLine("Henüz yorum yapılmamış.");
            }
        }
    }
}