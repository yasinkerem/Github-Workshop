using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 4 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// </summary>
    public class Problem4Tests
    {
        public static int TestsPassed = 0;
        public static int TestsFailed = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║     Problem 4 - Test Sistemi         ║");
            Console.WriteLine("║     Dizi ve Liste İşlemleri          ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            if (args.Length == 0)
            {
                Console.WriteLine("❌ HATA: Çözüm dosyası belirtilmedi!");
                Environment.Exit(1);
            }

            if (!DosyaAdiKontrol(args[0])) Environment.Exit(1);

            Console.WriteLine("\n📝 Metot Testleri:\n");

            TestDiziToplami();
            TestDiziOrtalamasi();
            TestEnBuyukBul();
            TestEnKucukBul();
            TestCiftSayilariFiltrele();
            TestSayiTekrarSay();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem4_(\d{9})\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem4_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestDiziToplami()
        {
            Console.WriteLine("🔹 DiziToplami Testleri:");

            int[] d1 = { 1, 2, 3, 4, 5 };
            Assert(Problem4.DiziToplami(d1) == 15, "[1,2,3,4,5] → 15", Problem4.DiziToplami(d1).ToString());

            int[] d2 = { };
            Assert(Problem4.DiziToplami(d2) == 0, "[] → 0", Problem4.DiziToplami(d2).ToString());

            int[] d3 = { -1, -2, -3 };
            Assert(Problem4.DiziToplami(d3) == -6, "[-1,-2,-3] → -6", Problem4.DiziToplami(d3).ToString());

            int[] d4 = { 100 };
            Assert(Problem4.DiziToplami(d4) == 100, "[100] → 100", Problem4.DiziToplami(d4).ToString());
        }

        static void TestDiziOrtalamasi()
        {
            Console.WriteLine("\n🔹 DiziOrtalamasi Testleri:");

            int[] d1 = { 10, 20, 30 };
            Assert(Math.Abs(Problem4.DiziOrtalamasi(d1) - 20.0) < 0.01, "[10,20,30] → 20.0", Problem4.DiziOrtalamasi(d1).ToString("F2"));

            int[] d2 = { 1, 2, 3, 4, 5 };
            Assert(Math.Abs(Problem4.DiziOrtalamasi(d2) - 3.0) < 0.01, "[1,2,3,4,5] → 3.0", Problem4.DiziOrtalamasi(d2).ToString("F2"));

            int[] d3 = { };
            Assert(Math.Abs(Problem4.DiziOrtalamasi(d3) - 0.0) < 0.01, "[] → 0.0", Problem4.DiziOrtalamasi(d3).ToString("F2"));
        }

        static void TestEnBuyukBul()
        {
            Console.WriteLine("\n🔹 EnBuyukBul Testleri:");

            int[] d1 = { 3, 7, 2, 9, 1 };
            Assert(Problem4.EnBuyukBul(d1) == 9, "[3,7,2,9,1] → 9", Problem4.EnBuyukBul(d1).ToString());

            int[] d2 = { -5, -2, -8 };
            Assert(Problem4.EnBuyukBul(d2) == -2, "[-5,-2,-8] → -2", Problem4.EnBuyukBul(d2).ToString());

            int[] d3 = { 5, 5, 5 };
            Assert(Problem4.EnBuyukBul(d3) == 5, "[5,5,5] → 5", Problem4.EnBuyukBul(d3).ToString());
        }

        static void TestEnKucukBul()
        {
            Console.WriteLine("\n🔹 EnKucukBul Testleri:");

            int[] d1 = { 3, 7, 2, 9, 1 };
            Assert(Problem4.EnKucukBul(d1) == 1, "[3,7,2,9,1] → 1", Problem4.EnKucukBul(d1).ToString());

            int[] d2 = { -5, -2, -8 };
            Assert(Problem4.EnKucukBul(d2) == -8, "[-5,-2,-8] → -8", Problem4.EnKucukBul(d2).ToString());

            int[] d3 = { 5, 5, 5 };
            Assert(Problem4.EnKucukBul(d3) == 5, "[5,5,5] → 5", Problem4.EnKucukBul(d3).ToString());
        }

        static void TestCiftSayilariFiltrele()
        {
            Console.WriteLine("\n🔹 CiftSayilariFiltrele Testleri:");

            int[] d1 = { 1, 2, 3, 4, 5, 6 };
            var s1 = Problem4.CiftSayilariFiltrele(d1);
            bool t1 = s1.Count == 3 && s1.Contains(2) && s1.Contains(4) && s1.Contains(6);
            Assert(t1, "[1,2,3,4,5,6] → [2,4,6]", $"[{string.Join(",", s1)}]");

            int[] d2 = { 1, 3, 5 };
            var s2 = Problem4.CiftSayilariFiltrele(d2);
            Assert(s2.Count == 0, "[1,3,5] → []", $"[{string.Join(",", s2)}]");

            int[] d3 = { 2, 4, 6, 8 };
            var s3 = Problem4.CiftSayilariFiltrele(d3);
            Assert(s3.Count == 4, "[2,4,6,8] → 4 eleman", s3.Count.ToString());

            int[] d4 = { };
            var s4 = Problem4.CiftSayilariFiltrele(d4);
            Assert(s4.Count == 0, "[] → []", s4.Count.ToString());
        }

        static void TestSayiTekrarSay()
        {
            Console.WriteLine("\n🔹 SayiTekrarSay Testleri:");

            int[] d1 = { 1, 2, 3, 2, 4, 2 };
            Assert(Problem4.SayiTekrarSay(d1, 2) == 3, "[1,2,3,2,4,2],2 → 3", Problem4.SayiTekrarSay(d1, 2).ToString());

            int[] d2 = { 1, 2, 3 };
            Assert(Problem4.SayiTekrarSay(d2, 5) == 0, "[1,2,3],5 → 0", Problem4.SayiTekrarSay(d2, 5).ToString());

            int[] d3 = { 5, 5, 5, 5 };
            Assert(Problem4.SayiTekrarSay(d3, 5) == 4, "[5,5,5,5],5 → 4", Problem4.SayiTekrarSay(d3, 5).ToString());

            int[] d4 = { };
            Assert(Problem4.SayiTekrarSay(d4, 1) == 0, "[],1 → 0", Problem4.SayiTekrarSay(d4, 1).ToString());
        }

        static void Sonuclar()
        {
            Console.WriteLine("\n╔══════════════════════════════════════╗");
            Console.WriteLine("║           TEST SONUÇLARI             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.WriteLine($"  ✅ Geçen: {TestsPassed}");
            Console.WriteLine($"  ❌ Kalan: {TestsFailed}");
            Console.WriteLine($"  📊 Toplam: {TestsPassed + TestsFailed}");

            double puan = (double)TestsPassed / (TestsPassed + TestsFailed) * 25;
            Console.WriteLine($"  🏆 Puan: {puan:F1} / 25");

            if (TestsFailed == 0)
                Console.WriteLine("\n🎉 TEBRİKLER! TÜM TESTLER BAŞARILI!");
            else
            {
                Console.WriteLine("\n⚠️ Bazı testler başarısız.");
                Environment.Exit(1);
            }
        }

        static void Assert(bool condition, string expected, string actual)
        {
            if (condition)
            {
                Console.WriteLine($"     ✅ GEÇTI: {expected}");
                TestsPassed++;
            }
            else
            {
                Console.WriteLine($"     ❌ KALDI: Beklenen: {expected}, Bulunan: {actual}");
                TestsFailed++;
            }
        }
    }
}
