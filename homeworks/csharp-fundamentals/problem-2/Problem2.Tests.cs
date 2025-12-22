using System;
using System.Text.RegularExpressions;

namespace CSharpHomework.Tests
{
    /// <summary>
    /// Problem 2 Test Dosyası
    /// Bu dosyayı DEĞİŞTİRMEYİN!
    /// </summary>
    public class Problem2Tests
    {
        public static int TestsPassed = 0;
        public static int TestsFailed = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║     Problem 2 - Test Sistemi         ║");
            Console.WriteLine("║     Gün ve Ay Hesaplama              ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            if (args.Length == 0)
            {
                Console.WriteLine("❌ HATA: Çözüm dosyası belirtilmedi!");
                Environment.Exit(1);
            }

            if (!DosyaAdiKontrol(args[0])) Environment.Exit(1);

            Console.WriteLine("\n📝 Metot Testleri:\n");

            TestGunAdiGetir();
            TestArtikYilMi();
            TestAyinGunSayisi();
            TestHaftaIciSonuMu();

            Sonuclar();
        }

        static bool DosyaAdiKontrol(string dosyaAdi)
        {
            Console.WriteLine("📋 Dosya Adı Kontrolü:");
            Console.WriteLine($"   Dosya: {dosyaAdi}");

            string pattern = @"^Problem2_(\d{9})\.cs$";
            var match = Regex.Match(dosyaAdi, pattern);

            if (!match.Success)
            {
                Console.WriteLine("   ❌ HATA: Format yanlış! Beklenen: Problem2_OGRENCI_NO.cs");
                return false;
            }

            Console.WriteLine($"   ✅ Format doğru! Öğrenci No: {match.Groups[1].Value}");
            return true;
        }

        static void TestGunAdiGetir()
        {
            Console.WriteLine("🔹 GunAdiGetir Testleri:");

            Assert(Problem2.GunAdiGetir(1) == "Pazartesi", "1 → Pazartesi", Problem2.GunAdiGetir(1));
            Assert(Problem2.GunAdiGetir(2) == "Salı", "2 → Salı", Problem2.GunAdiGetir(2));
            Assert(Problem2.GunAdiGetir(3) == "Çarşamba", "3 → Çarşamba", Problem2.GunAdiGetir(3));
            Assert(Problem2.GunAdiGetir(4) == "Perşembe", "4 → Perşembe", Problem2.GunAdiGetir(4));
            Assert(Problem2.GunAdiGetir(5) == "Cuma", "5 → Cuma", Problem2.GunAdiGetir(5));
            Assert(Problem2.GunAdiGetir(6) == "Cumartesi", "6 → Cumartesi", Problem2.GunAdiGetir(6));
            Assert(Problem2.GunAdiGetir(7) == "Pazar", "7 → Pazar", Problem2.GunAdiGetir(7));
            Assert(Problem2.GunAdiGetir(0) == "Geçersiz gün", "0 → Geçersiz", Problem2.GunAdiGetir(0));
            Assert(Problem2.GunAdiGetir(8) == "Geçersiz gün", "8 → Geçersiz", Problem2.GunAdiGetir(8));
        }

        static void TestArtikYilMi()
        {
            Console.WriteLine("\n🔹 ArtikYilMi Testleri:");

            Assert(Problem2.ArtikYilMi(2024) == true, "2024 → true", Problem2.ArtikYilMi(2024).ToString());
            Assert(Problem2.ArtikYilMi(2023) == false, "2023 → false", Problem2.ArtikYilMi(2023).ToString());
            Assert(Problem2.ArtikYilMi(2000) == true, "2000 → true (400'e bölünür)", Problem2.ArtikYilMi(2000).ToString());
            Assert(Problem2.ArtikYilMi(1900) == false, "1900 → false (100'e bölünür)", Problem2.ArtikYilMi(1900).ToString());
            Assert(Problem2.ArtikYilMi(2100) == false, "2100 → false", Problem2.ArtikYilMi(2100).ToString());
            Assert(Problem2.ArtikYilMi(2020) == true, "2020 → true", Problem2.ArtikYilMi(2020).ToString());
        }

        static void TestAyinGunSayisi()
        {
            Console.WriteLine("\n🔹 AyinGunSayisi Testleri:");

            Assert(Problem2.AyinGunSayisi(1, 2024) == 31, "Ocak → 31", Problem2.AyinGunSayisi(1, 2024).ToString());
            Assert(Problem2.AyinGunSayisi(2, 2024) == 29, "Şubat 2024 → 29", Problem2.AyinGunSayisi(2, 2024).ToString());
            Assert(Problem2.AyinGunSayisi(2, 2023) == 28, "Şubat 2023 → 28", Problem2.AyinGunSayisi(2, 2023).ToString());
            Assert(Problem2.AyinGunSayisi(4, 2024) == 30, "Nisan → 30", Problem2.AyinGunSayisi(4, 2024).ToString());
            Assert(Problem2.AyinGunSayisi(7, 2024) == 31, "Temmuz → 31", Problem2.AyinGunSayisi(7, 2024).ToString());
            Assert(Problem2.AyinGunSayisi(12, 2024) == 31, "Aralık → 31", Problem2.AyinGunSayisi(12, 2024).ToString());
            Assert(Problem2.AyinGunSayisi(0, 2024) == 0, "Geçersiz ay → 0", Problem2.AyinGunSayisi(0, 2024).ToString());
        }

        static void TestHaftaIciSonuMu()
        {
            Console.WriteLine("\n🔹 HaftaIciSonuMu Testleri:");

            Assert(Problem2.HaftaIciSonuMu(1) == "Hafta İçi", "Pzt → Hafta İçi", Problem2.HaftaIciSonuMu(1));
            Assert(Problem2.HaftaIciSonuMu(3) == "Hafta İçi", "Çar → Hafta İçi", Problem2.HaftaIciSonuMu(3));
            Assert(Problem2.HaftaIciSonuMu(5) == "Hafta İçi", "Cuma → Hafta İçi", Problem2.HaftaIciSonuMu(5));
            Assert(Problem2.HaftaIciSonuMu(6) == "Hafta Sonu", "Cmt → Hafta Sonu", Problem2.HaftaIciSonuMu(6));
            Assert(Problem2.HaftaIciSonuMu(7) == "Hafta Sonu", "Paz → Hafta Sonu", Problem2.HaftaIciSonuMu(7));
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
