using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 3 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// </summary>
    public class Problem3Tests
    {
        public static int TestsPassed = 0;
        public static int TestsFailed = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║     Problem 3 - Test Sistemi         ║");
            Console.WriteLine("║     Döngüler ve Matematik            ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            if (args.Length == 0)
            {
                Console.WriteLine("❌ HATA: Çözüm dosyası belirtilmedi!");
                Environment.Exit(1);
            }

            if (!DosyaAdiKontrol(args[0])) Environment.Exit(1);

            Console.WriteLine("\n📝 Metot Testleri:\n");

            TestFaktoriyel();
            TestFibonacci();
            TestBasamakSayisi();
            TestAsalMi();
            TestSayilarinToplami();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem3_(\d{9})\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem3_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestFaktoriyel()
        {
            Console.WriteLine("🔹 Faktoriyel Testleri:");

            Assert(Problem3.Faktoriyel(0) == 1, "0! → 1", Problem3.Faktoriyel(0).ToString());
            Assert(Problem3.Faktoriyel(1) == 1, "1! → 1", Problem3.Faktoriyel(1).ToString());
            Assert(Problem3.Faktoriyel(5) == 120, "5! → 120", Problem3.Faktoriyel(5).ToString());
            Assert(Problem3.Faktoriyel(10) == 3628800, "10! → 3628800", Problem3.Faktoriyel(10).ToString());
        }

        static void TestFibonacci()
        {
            Console.WriteLine("\n🔹 FibonacciSerisi Testleri:");

            var fib5 = Problem3.FibonacciSerisi(5);
            Assert(fib5.Count == 5, "5 eleman", fib5.Count.ToString());
            Assert(fib5[0] == 0, "fib[0] = 0", fib5.Count > 0 ? fib5[0].ToString() : "yok");
            Assert(fib5[1] == 1, "fib[1] = 1", fib5.Count > 1 ? fib5[1].ToString() : "yok");
            Assert(fib5[4] == 3, "fib[4] = 3", fib5.Count > 4 ? fib5[4].ToString() : "yok");

            var fib8 = Problem3.FibonacciSerisi(8);
            Assert(fib8.Count == 8, "8 eleman", fib8.Count.ToString());
            Assert(fib8[7] == 13, "fib[7] = 13", fib8.Count > 7 ? fib8[7].ToString() : "yok");

            var fib0 = Problem3.FibonacciSerisi(0);
            Assert(fib0.Count == 0, "0 eleman", fib0.Count.ToString());
        }

        static void TestBasamakSayisi()
        {
            Console.WriteLine("\n🔹 BasamakSayisi Testleri:");

            Assert(Problem3.BasamakSayisi(0) == 1, "0 → 1", Problem3.BasamakSayisi(0).ToString());
            Assert(Problem3.BasamakSayisi(5) == 1, "5 → 1", Problem3.BasamakSayisi(5).ToString());
            Assert(Problem3.BasamakSayisi(12) == 2, "12 → 2", Problem3.BasamakSayisi(12).ToString());
            Assert(Problem3.BasamakSayisi(12345) == 5, "12345 → 5", Problem3.BasamakSayisi(12345).ToString());
            Assert(Problem3.BasamakSayisi(-999) == 3, "-999 → 3", Problem3.BasamakSayisi(-999).ToString());
            Assert(Problem3.BasamakSayisi(1000000) == 7, "1000000 → 7", Problem3.BasamakSayisi(1000000).ToString());
        }

        static void TestAsalMi()
        {
            Console.WriteLine("\n🔹 AsalMi Testleri:");

            Assert(Problem3.AsalMi(0) == false, "0 → false", Problem3.AsalMi(0).ToString());
            Assert(Problem3.AsalMi(1) == false, "1 → false", Problem3.AsalMi(1).ToString());
            Assert(Problem3.AsalMi(2) == true, "2 → true", Problem3.AsalMi(2).ToString());
            Assert(Problem3.AsalMi(3) == true, "3 → true", Problem3.AsalMi(3).ToString());
            Assert(Problem3.AsalMi(4) == false, "4 → false", Problem3.AsalMi(4).ToString());
            Assert(Problem3.AsalMi(17) == true, "17 → true", Problem3.AsalMi(17).ToString());
            Assert(Problem3.AsalMi(18) == false, "18 → false", Problem3.AsalMi(18).ToString());
            Assert(Problem3.AsalMi(97) == true, "97 → true", Problem3.AsalMi(97).ToString());
            Assert(Problem3.AsalMi(100) == false, "100 → false", Problem3.AsalMi(100).ToString());
        }

        static void TestSayilarinToplami()
        {
            Console.WriteLine("\n🔹 SayilarinToplami Testleri:");

            Assert(Problem3.SayilarinToplami(1) == 1, "1 → 1", Problem3.SayilarinToplami(1).ToString());
            Assert(Problem3.SayilarinToplami(5) == 15, "5 → 15", Problem3.SayilarinToplami(5).ToString());
            Assert(Problem3.SayilarinToplami(10) == 55, "10 → 55", Problem3.SayilarinToplami(10).ToString());
            Assert(Problem3.SayilarinToplami(100) == 5050, "100 → 5050", Problem3.SayilarinToplami(100).ToString());
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
