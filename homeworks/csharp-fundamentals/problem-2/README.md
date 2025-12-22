# Problem 2: Haftanın Günü ve Ay Hesaplama

## 📋 Açıklama

Switch-case ve ternary operatör kullanarak gün ve ay hesaplamaları yapan bir program yazın.

## 🎯 Kapsanan Konular
- `switch-case` yapısı
- Ternary operatör (`? :`)
- Koşullu ifadeler

---

## 📝 Yazmanız Gereken Kod

`Problem2` adında bir sınıf oluşturun ve aşağıdaki metotları yazın:

### 1. `GunAdiGetir` Metodu

```csharp
public static string GunAdiGetir(int gunNumarasi)
```

- **Açıklama:** Gün numarasına göre gün adını döndürür
- **Parametre:** `int gunNumarasi` - 1-7 arası sayı
- **Dönüş:** `string` - Gün adı
- **Kullanılacak:** `switch-case`

| Numara | Gün |
|--------|-----|
| 1 | Pazartesi |
| 2 | Salı |
| 3 | Çarşamba |
| 4 | Perşembe |
| 5 | Cuma |
| 6 | Cumartesi |
| 7 | Pazar |
| Diğer | Geçersiz gün |

**Örnek:**
```
GunAdiGetir(1) → "Pazartesi"
GunAdiGetir(7) → "Pazar"
GunAdiGetir(0) → "Geçersiz gün"
```

---

### 2. `ArtikYilMi` Metodu

```csharp
public static bool ArtikYilMi(int yil)
```

- **Açıklama:** Verilen yılın artık yıl olup olmadığını kontrol eder
- **Parametre:** `int yil` - Yıl
- **Dönüş:** `bool` - Artık yıl ise true

**Artık Yıl Kuralları:**
1. Yıl 400'e tam bölünüyorsa → artık yıl ✅
2. Yıl 100'e tam bölünüyorsa → artık yıl DEĞİL ❌
3. Yıl 4'e tam bölünüyorsa → artık yıl ✅
4. Diğer durumlar → artık yıl DEĞİL ❌

**Örnek:**
```
ArtikYilMi(2024) → true   (4'e bölünür)
ArtikYilMi(2023) → false
ArtikYilMi(2000) → true   (400'e bölünür)
ArtikYilMi(1900) → false  (100'e bölünür ama 400'e bölünmez)
```

---

### 3. `AyinGunSayisi` Metodu

```csharp
public static int AyinGunSayisi(int ay, int yil)
```

- **Açıklama:** Verilen ay ve yıla göre gün sayısını hesaplar
- **Parametreler:**
  - `int ay` - Ay numarası (1-12)
  - `int yil` - Yıl
- **Dönüş:** `int` - Gün sayısı
- **Kullanılacak:** `switch-case`

| Ay | Gün Sayısı |
|----|------------|
| 1, 3, 5, 7, 8, 10, 12 | 31 |
| 4, 6, 9, 11 | 30 |
| 2 (normal yıl) | 28 |
| 2 (artık yıl) | 29 |
| Geçersiz ay | 0 |

**Örnek:**
```
AyinGunSayisi(1, 2024) → 31
AyinGunSayisi(2, 2024) → 29  (artık yıl)
AyinGunSayisi(2, 2023) → 28
AyinGunSayisi(4, 2024) → 30
```

---

### 4. `HaftaIciSonuMu` Metodu

```csharp
public static string HaftaIciSonuMu(int gunNumarasi)
```

- **Açıklama:** Günün hafta içi mi hafta sonu mu olduğunu belirler
- **Parametre:** `int gunNumarasi` - 1-7 arası
- **Dönüş:** `string` - "Hafta İçi" veya "Hafta Sonu"
- **Kullanılacak:** Ternary operatör (`? :`)

| Gün | Sonuç |
|-----|-------|
| 1-5 (Pzt-Cuma) | "Hafta İçi" |
| 6-7 (Cmt-Paz) | "Hafta Sonu" |

**Örnek:**
```
HaftaIciSonuMu(1) → "Hafta İçi"
HaftaIciSonuMu(5) → "Hafta İçi"
HaftaIciSonuMu(6) → "Hafta Sonu"
HaftaIciSonuMu(7) → "Hafta Sonu"
```

---

## 📁 Çözüm Dosyası Şablonu

```csharp
using System;

namespace CSharpHomework
{
    public class Problem2
    {
        public static string GunAdiGetir(int gunNumarasi)
        {
            // switch-case kullanın
        }

        public static bool ArtikYilMi(int yil)
        {
            // Kodunuzu buraya yazın
        }

        public static int AyinGunSayisi(int ay, int yil)
        {
            // switch-case kullanın
        }

        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            // ternary operatör kullanın
        }
    }
}
```

---

## ✅ Teslim Formatı

1. `submissions/` klasörüne gidin
2. Dosya adı: `Problem2_OGRENCI_NO.cs`
3. Örnek: `Problem2_210316011.cs`

---

## 🧪 Test Edilen Durumlar

| Test | Beklenen |
|------|----------|
| `GunAdiGetir(1)` | `"Pazartesi"` |
| `GunAdiGetir(7)` | `"Pazar"` |
| `ArtikYilMi(2024)` | `true` |
| `ArtikYilMi(1900)` | `false` |
| `AyinGunSayisi(2, 2024)` | `29` |
| `HaftaIciSonuMu(6)` | `"Hafta Sonu"` |

---

## 💡 İpuçları

1. Switch-case'de `break;` unutmayın
2. `default:` case'i ekleyin
3. Ternary: `koşul ? doğruysa : yanlışsa`
4. Artık yıl kurallarının sırasına dikkat edin!

---

**Puan: 25**
