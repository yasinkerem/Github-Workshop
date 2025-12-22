# Problem 3: Döngüler ile Matematiksel Hesaplamalar

## 📋 Açıklama

For, while ve do-while döngülerini kullanarak matematiksel hesaplamalar yapan bir program yazın.

## 🎯 Kapsanan Konular
- `for` döngüsü
- `while` döngüsü
- `do-while` döngüsü
- Döngü kontrol ifadeleri

---

## 📝 Yazmanız Gereken Kod

`Problem3` adında bir sınıf oluşturun ve aşağıdaki metotları yazın:

### 1. `Faktoriyel` Metodu

```csharp
public static long Faktoriyel(int n)
```

- **Açıklama:** n! (n faktöriyel) hesaplar
- **Parametre:** `int n` - Sayı (0 veya pozitif)
- **Dönüş:** `long` - Faktöriyel sonucu
- **Kullanılacak:** `for` döngüsü

**Formül:** `n! = n × (n-1) × (n-2) × ... × 2 × 1`  
**Not:** `0! = 1` ve `1! = 1`

**Örnek:**
```
Faktoriyel(5) → 120  (5×4×3×2×1)
Faktoriyel(0) → 1
Faktoriyel(10) → 3628800
```

---

### 2. `FibonacciSerisi` Metodu

```csharp
public static List<int> FibonacciSerisi(int adet)
```

- **Açıklama:** İlk n adet Fibonacci sayısını döndürür
- **Parametre:** `int adet` - Kaç sayı üretileceği
- **Dönüş:** `List<int>` - Fibonacci sayıları
- **Kullanılacak:** `while` döngüsü

**Fibonacci Serisi:** 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...  
Her sayı önceki iki sayının toplamıdır.

**Örnek:**
```
FibonacciSerisi(5) → [0, 1, 1, 2, 3]
FibonacciSerisi(8) → [0, 1, 1, 2, 3, 5, 8, 13]
```

---

### 3. `BasamakSayisi` Metodu

```csharp
public static int BasamakSayisi(int sayi)
```

- **Açıklama:** Sayının kaç basamaklı olduğunu hesaplar
- **Parametre:** `int sayi` - Herhangi bir tamsayı
- **Dönüş:** `int` - Basamak sayısı
- **Kullanılacak:** `do-while` döngüsü
- **Not:** Negatif sayılar için mutlak değer alınmalı

**Örnek:**
```
BasamakSayisi(12345) → 5
BasamakSayisi(0) → 1
BasamakSayisi(-999) → 3
```

---

### 4. `AsalMi` Metodu

```csharp
public static bool AsalMi(int sayi)
```

- **Açıklama:** Sayının asal olup olmadığını kontrol eder
- **Parametre:** `int sayi` - Kontrol edilecek sayı
- **Dönüş:** `bool` - Asal ise true
- **Kullanılacak:** `for` döngüsü

**Asal Sayı:** 1 ve kendisi dışında tam böleni olmayan sayı.  
**Not:** 0 ve 1 asal değildir. 2 en küçük asaldır.

**İpucu:** Sayının √n'e kadar olan bölenlerini kontrol edin.

**Örnek:**
```
AsalMi(2) → true
AsalMi(17) → true
AsalMi(18) → false
AsalMi(1) → false
```

---

### 5. `SayilarinToplami` Metodu

```csharp
public static int SayilarinToplami(int n)
```

- **Açıklama:** 1'den n'e kadar sayıların toplamını hesaplar
- **Parametre:** `int n` - Üst sınır
- **Dönüş:** `int` - Toplam
- **Kullanılacak:** `for` döngüsü

**Formül:** 1 + 2 + 3 + ... + n

**Örnek:**
```
SayilarinToplami(5) → 15  (1+2+3+4+5)
SayilarinToplami(10) → 55
SayilarinToplami(100) → 5050
```

---

## 📁 Çözüm Dosyası Şablonu

```csharp
using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            // for döngüsü kullanın
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            // while döngüsü kullanın
        }

        public static int BasamakSayisi(int sayi)
        {
            // do-while döngüsü kullanın
        }

        public static bool AsalMi(int sayi)
        {
            // for döngüsü kullanın
        }

        public static int SayilarinToplami(int n)
        {
            // for döngüsü kullanın
        }
    }
}
```

---

## ✅ Teslim Formatı

1. `submissions/` klasörüne gidin
2. Dosya adı: `Problem3_OGRENCI_NO.cs`
3. Örnek: `Problem3_210316011.cs`

---

## 🧪 Test Edilen Durumlar

| Test | Beklenen |
|------|----------|
| `Faktoriyel(5)` | `120` |
| `Faktoriyel(0)` | `1` |
| `FibonacciSerisi(5)` | `[0,1,1,2,3]` |
| `BasamakSayisi(12345)` | `5` |
| `BasamakSayisi(0)` | `1` |
| `AsalMi(17)` | `true` |
| `AsalMi(18)` | `false` |
| `SayilarinToplami(100)` | `5050` |

---

## 💡 İpuçları

1. Faktöriyel için: `sonuc *= i`
2. Fibonacci için: geçici değişken kullanın
3. Basamak için: `sayi = sayi / 10`
4. Asal için: `Math.Sqrt(sayi)` kullanın
5. Sonsuz döngüye dikkat edin!

---

**Puan: 25**
