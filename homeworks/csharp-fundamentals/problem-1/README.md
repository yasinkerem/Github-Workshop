# Problem 1: Öğrenci Not Hesaplama Sistemi

## 📋 Açıklama

Bir öğrencinin vize ve final notlarına göre harf notunu ve geçme durumunu hesaplayan bir program yazın.

## 🎯 Kapsanan Konular
- `if-else` koşulları
- Mantıksal operatörler (`&&`, `||`, `!`)
- Karşılaştırma operatörleri (`>`, `<`, `>=`, `<=`, `==`)

---

## 📝 Yazmanız Gereken Kod

`Problem1` adında bir sınıf oluşturun ve aşağıdaki metotları yazın:

### 1. `HesaplaOrtalama` Metodu

```csharp
public static double HesaplaOrtalama(int vize, int final)
```

- **Açıklama:** Vize ve final notlarına göre ortalamayı hesaplar
- **Formül:** `ortalama = vize * 0.4 + final * 0.6`
- **Parametreler:** 
  - `int vize` - Vize notu (0-100)
  - `int final` - Final notu (0-100)
- **Dönüş:** `double` - Hesaplanan ortalama

**Örnek:**
```
HesaplaOrtalama(70, 80) → 76.0  (70*0.4 + 80*0.6 = 28 + 48)
HesaplaOrtalama(100, 100) → 100.0
```

---

### 2. `BelirleHarfNotu` Metodu

```csharp
public static string BelirleHarfNotu(double ortalama, int final)
```

- **Açıklama:** Ortalama ve final notuna göre harf notunu belirler
- **Parametreler:**
  - `double ortalama` - Hesaplanan ortalama
  - `int final` - Final notu
- **Dönüş:** `string` - Harf notu

**Önemli Kural:** Final notu 50'nin altındaysa, ortalama ne olursa olsun **"FF"** döner!

| Ortalama | Harf Notu |
|----------|-----------|
| 90-100 | AA |
| 85-89 | BA |
| 80-84 | BB |
| 75-79 | CB |
| 70-74 | CC |
| 65-69 | DC |
| 60-64 | DD |
| 50-59 | FD |
| 0-49 | FF |

**Örnek:**
```
BelirleHarfNotu(95, 90) → "AA"
BelirleHarfNotu(72, 70) → "CC"
BelirleHarfNotu(80, 45) → "FF"  (Final < 50)
```

---

### 3. `BelirleGecmeDurumu` Metodu

```csharp
public static string BelirleGecmeDurumu(string harfNotu)
```

- **Açıklama:** Harf notuna göre geçme durumunu belirler
- **Parametre:** `string harfNotu` - Harf notu
- **Dönüş:** `string` - Geçme durumu

| Harf Notları | Durum |
|--------------|-------|
| AA, BA, BB, CB, CC | "Geçti" |
| DC, DD | "Şartlı Geçti" |
| FD, FF | "Kaldı" |

**Örnek:**
```
BelirleGecmeDurumu("AA") → "Geçti"
BelirleGecmeDurumu("DC") → "Şartlı Geçti"
BelirleGecmeDurumu("FF") → "Kaldı"
```

---

## 📁 Çözüm Dosyası Şablonu

```csharp
using System;

namespace CSharpHomework
{
    public class Problem1
    {
        public static double HesaplaOrtalama(int vize, int final)
        {
            // Kodunuzu buraya yazın
        }

        public static string BelirleHarfNotu(double ortalama, int final)
        {
            // Kodunuzu buraya yazın
        }

        public static string BelirleGecmeDurumu(string harfNotu)
        {
            // Kodunuzu buraya yazın
        }
    }
}
```

---

## ✅ Teslim Formatı

1. `submissions/` klasörüne gidin
2. Dosya adı: `Problem1_OGRENCI_NO.cs`
3. Örnek: `Problem1_210316011.cs`

---

## 🧪 Test Edilen Durumlar

| Test | Beklenen Sonuç |
|------|----------------|
| `HesaplaOrtalama(70, 80)` | `76.0` |
| `HesaplaOrtalama(100, 100)` | `100.0` |
| `BelirleHarfNotu(95, 90)` | `"AA"` |
| `BelirleHarfNotu(72, 70)` | `"CC"` |
| `BelirleHarfNotu(80, 45)` | `"FF"` |
| `BelirleGecmeDurumu("AA")` | `"Geçti"` |
| `BelirleGecmeDurumu("DC")` | `"Şartlı Geçti"` |
| `BelirleGecmeDurumu("FF")` | `"Kaldı"` |

---

## 💡 İpuçları

1. Önce final < 50 kontrolünü yapın
2. if-else if-else yapısını kullanın
3. Mantıksal operatörlerle aralık kontrolü: `ortalama >= 90 && ortalama <= 100`
4. `||` operatörü ile birden fazla koşulu birleştirin

---

**Puan: 25**
