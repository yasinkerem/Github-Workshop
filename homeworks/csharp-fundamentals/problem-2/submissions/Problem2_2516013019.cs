using System;

namespace CSharpHomework
{
    public class Problem2
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 1-7 arasında bir gün numarası giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gün Adı: " + GunAdiGetir(gun));
            Console.WriteLine("Hafta Durumu: " + HaftaIciSonuMu(gun));

            Console.WriteLine("-----------------------------");

            Console.Write("Lütfen bir yıl giriniz: ");
            int yil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artık Yıl mı: " + ArtikYilMi(yil));

            Console.WriteLine("-----------------------------");

            Console.Write("Lütfen 1-12 arasında bir ay numarası giriniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O aydaki gün sayısı: " + AyinGunSayisi(ay, yil));

            Console.ReadLine();
        }

        public static string GunAdiGetir(int gunNumarasi)
        {
            switch (gunNumarasi)
            {
                case 1: return "Pazartesi";
                case 2: return "Salı";
                case 3: return "Çarşamba";
                case 4: return "Perşembe";
                case 5: return "Cuma";
                case 6: return "Cumartesi";
                case 7: return "Pazar";
                default: return "Geçersiz gün";
            }
        }

        public static bool ArtikYilMi(int yil)
        {
            if (yil % 400 == 0) return true;
            if (yil % 100 == 0) return false;
            if (yil % 4 == 0) return true;
            return false;
        }

        public static int AyinGunSayisi(int ay, int yil)
        {
            switch (ay)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (ArtikYilMi(yil)) return 29;
                    return 28;
                default:
                    return 0;
            }
        }

        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            return (gunNumarasi >= 1 && gunNumarasi <= 5) ? "Hafta İçi" : "Hafta Sonu";
        }
    }
}
