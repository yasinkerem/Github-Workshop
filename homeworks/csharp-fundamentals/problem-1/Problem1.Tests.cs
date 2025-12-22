using System;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 1 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// 
    /// Öğrenci çözümlerini kontrol eder:
    /// 1. Dosya adı formatı (Problem1_OGRENCI_NO.cs)
    /// 2. Metot testleri
    /// </summary>
    public class Problem1Tests
    {
        public static int TestsPassed = 0;
        public static int TestsFailed = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║     Problem 1 - Test Sistemi         ║");
            Console.WriteLine("║     Öğrenci Not Hesaplama            ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            if (args.Length == 0)
            {
                Console.WriteLine("❌ HATA: Çözüm dosyası belirtilmedi!");
                Console.WriteLine("Kullanım: dotnet run <dosya_adi>");
                Environment.Exit(1);
            }

            string dosyaAdi = args[0];

            // Dosya Adı Kontrolü
            if (!DosyaAdiKontrol(dosyaAdi))
            {
                Environment.Exit(1);
            }

            Console.WriteLine("\n📝 Metot Testleri:\n");

            // Testler
            TestHesaplaOrtalama();
            TestBelirleHarfNotu();
            TestBelirleGecmeDurumu();

            // Sonuçlar
            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem1_(\d{9})\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Dosya adı formatı yanlış!");
                Console.WriteLine("   📌 Beklenen: Problem1_OGRENCI_NO.cs");
                Console.WriteLine("   📌 Örnek: Problem1_210316011.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestHesaplaOrtalama()
        {
            Console.WriteLine("🔹 HesaplaOrtalama Testleri:");

            // Test 1
            double r1 = Problem1.HesaplaOrtalama(70, 80);
            Assert(Math.Abs(r1 - 76.0) < 0.01, "vize=70, final=80 → 76.0", r1.ToString("F2"));

            // Test 2
            double r2 = Problem1.HesaplaOrtalama(100, 100);
            Assert(Math.Abs(r2 - 100.0) < 0.01, "vize=100, final=100 → 100.0", r2.ToString("F2"));

            // Test 3
            double r3 = Problem1.HesaplaOrtalama(50, 50);
            Assert(Math.Abs(r3 - 50.0) < 0.01, "vize=50, final=50 → 50.0", r3.ToString("F2"));

            // Test 4
            double r4 = Problem1.HesaplaOrtalama(0, 0);
            Assert(Math.Abs(r4 - 0.0) < 0.01, "vize=0, final=0 → 0.0", r4.ToString("F2"));
        }

        static void TestBelirleHarfNotu()
        {
            Console.WriteLine("\n🔹 BelirleHarfNotu Testleri:");

            Assert(Problem1.BelirleHarfNotu(95, 90) == "AA", "95, f=90 → AA", Problem1.BelirleHarfNotu(95, 90));
            Assert(Problem1.BelirleHarfNotu(87, 85) == "BA", "87, f=85 → BA", Problem1.BelirleHarfNotu(87, 85));
            Assert(Problem1.BelirleHarfNotu(82, 80) == "BB", "82, f=80 → BB", Problem1.BelirleHarfNotu(82, 80));
            Assert(Problem1.BelirleHarfNotu(77, 75) == "CB", "77, f=75 → CB", Problem1.BelirleHarfNotu(77, 75));
            Assert(Problem1.BelirleHarfNotu(72, 70) == "CC", "72, f=70 → CC", Problem1.BelirleHarfNotu(72, 70));
            Assert(Problem1.BelirleHarfNotu(67, 65) == "DC", "67, f=65 → DC", Problem1.BelirleHarfNotu(67, 65));
            Assert(Problem1.BelirleHarfNotu(62, 60) == "DD", "62, f=60 → DD", Problem1.BelirleHarfNotu(62, 60));
            Assert(Problem1.BelirleHarfNotu(55, 55) == "FD", "55, f=55 → FD", Problem1.BelirleHarfNotu(55, 55));
            Assert(Problem1.BelirleHarfNotu(40, 50) == "FF", "40, f=50 → FF", Problem1.BelirleHarfNotu(40, 50));

            // Final < 50 kuralı
            Assert(Problem1.BelirleHarfNotu(80, 49) == "FF", "80, f=49 → FF (final<50)", Problem1.BelirleHarfNotu(80, 49));
            Assert(Problem1.BelirleHarfNotu(95, 30) == "FF", "95, f=30 → FF (final<50)", Problem1.BelirleHarfNotu(95, 30));
        }

        static void TestBelirleGecmeDurumu()
        {
            Console.WriteLine("\n🔹 BelirleGecmeDurumu Testleri:");

            Assert(Problem1.BelirleGecmeDurumu("AA") == "Geçti", "AA → Geçti", Problem1.BelirleGecmeDurumu("AA"));
            Assert(Problem1.BelirleGecmeDurumu("BA") == "Geçti", "BA → Geçti", Problem1.BelirleGecmeDurumu("BA"));
            Assert(Problem1.BelirleGecmeDurumu("BB") == "Geçti", "BB → Geçti", Problem1.BelirleGecmeDurumu("BB"));
            Assert(Problem1.BelirleGecmeDurumu("CB") == "Geçti", "CB → Geçti", Problem1.BelirleGecmeDurumu("CB"));
            Assert(Problem1.BelirleGecmeDurumu("CC") == "Geçti", "CC → Geçti", Problem1.BelirleGecmeDurumu("CC"));
            Assert(Problem1.BelirleGecmeDurumu("DC") == "Şartlı Geçti", "DC → Şartlı Geçti", Problem1.BelirleGecmeDurumu("DC"));
            Assert(Problem1.BelirleGecmeDurumu("DD") == "Şartlı Geçti", "DD → Şartlı Geçti", Problem1.BelirleGecmeDurumu("DD"));
            Assert(Problem1.BelirleGecmeDurumu("FD") == "Kaldı", "FD → Kaldı", Problem1.BelirleGecmeDurumu("FD"));
            Assert(Problem1.BelirleGecmeDurumu("FF") == "Kaldı", "FF → Kaldı", Problem1.BelirleGecmeDurumu("FF"));
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
            {
                Console.WriteLine("\n🎉 TEBRİKLER! TÜM TESTLER BAŞARILI!");
            }
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
