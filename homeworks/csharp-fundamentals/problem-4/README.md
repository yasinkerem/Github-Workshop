# Problem 4: Dizi ve Liste İşlemleri

## 📋 Açıklama

Foreach döngüsü ve fonksiyonlar kullanarak dizi ve liste işlemleri yapan bir program yazın.

## 🎯 Kapsanan Konular
- `foreach` döngüsü
- Fonksiyonlar (metot tanımlama ve çağırma)
- Diziler ve Listeler
- Temel koleksiyon işlemleri

---

## 📝 Yazmanız Gereken Kod

`Problem4` adında bir sınıf oluşturun ve aşağıdaki metotları yazın:

### 1. `DiziToplami` Metodu

```csharp
public static int DiziToplami(int[] dizi)
```

- **Açıklama:** Dizideki tüm elemanların toplamını döndürür
- **Parametre:** `int[] dizi` - Sayı dizisi
- **Dönüş:** `int` - Toplam
- **Kullanılacak:** `foreach` döngüsü

**Örnek:**
```
DiziToplami([1, 2, 3, 4, 5]) → 15
DiziToplami([]) → 0
DiziToplami([-1, -2, -3]) → -6
```

---

### 2. `DiziOrtalamasi` Metodu

```csharp
public static double DiziOrtalamasi(int[] dizi)
```

- **Açıklama:** Dizinin ortalamasını hesaplar
- **Parametre:** `int[] dizi` - Sayı dizisi
- **Dönüş:** `double` - Ortalama
- **Not:** Boş dizi için 0 döndürün

**Örnek:**
```
DiziOrtalamasi([10, 20, 30]) → 20.0
DiziOrtalamasi([1, 2, 3, 4, 5]) → 3.0
```

---

### 3. `EnBuyukBul` Metodu

```csharp
public static int EnBuyukBul(int[] dizi)
```

- **Açıklama:** Dizideki en büyük elemanı bulur
- **Parametre:** `int[] dizi` - Sayı dizisi
- **Dönüş:** `int` - En büyük eleman
- **Kullanılacak:** `foreach` döngüsü

**Örnek:**
```
EnBuyukBul([3, 7, 2, 9, 1]) → 9
EnBuyukBul([-5, -2, -8]) → -2
```

---

### 4. `EnKucukBul` Metodu

```csharp
public static int EnKucukBul(int[] dizi)
```

- **Açıklama:** Dizideki en küçük elemanı bulur
- **Parametre:** `int[] dizi` - Sayı dizisi
- **Dönüş:** `int` - En küçük eleman
- **Kullanılacak:** `foreach` döngüsü

**Örnek:**
```
EnKucukBul([3, 7, 2, 9, 1]) → 1
EnKucukBul([-5, -2, -8]) → -8
```

---

### 5. `CiftSayilariFiltrele` Metodu

```csharp
public static List<int> CiftSayilariFiltrele(int[] dizi)
```

- **Açıklama:** Dizideki çift sayıları bir listeye ekleyip döndürür
- **Parametre:** `int[] dizi` - Sayı dizisi
- **Dönüş:** `List<int>` - Çift sayılar listesi
- **Kullanılacak:** `foreach` döngüsü, `if` koşulu

**İpucu:** `sayi % 2 == 0` çift sayı kontrolü

**Örnek:**
```
CiftSayilariFiltrele([1, 2, 3, 4, 5, 6]) → [2, 4, 6]
CiftSayilariFiltrele([1, 3, 5]) → []
```

---

### 6. `SayiTekrarSay` Metodu

```csharp
public static int SayiTekrarSay(int[] dizi, int aranan)
```

- **Açıklama:** Dizide aranan sayının kaç kez geçtiğini sayar
- **Parametreler:**
  - `int[] dizi` - Sayı dizisi
  - `int aranan` - Aranacak sayı
- **Dönüş:** `int` - Tekrar sayısı
- **Kullanılacak:** `foreach` döngüsü

**Örnek:**
```
SayiTekrarSay([1, 2, 3, 2, 4, 2], 2) → 3
SayiTekrarSay([1, 2, 3], 5) → 0
```

---

## 📁 Çözüm Dosyası Şablonu

```csharp
using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem4
    {
        public static int DiziToplami(int[] dizi)
        {
            // foreach kullanın
        }

        public static double DiziOrtalamasi(int[] dizi)
        {
            // Kodunuzu yazın
        }

        public static int EnBuyukBul(int[] dizi)
        {
            // foreach kullanın
        }

        public static int EnKucukBul(int[] dizi)
        {
            // foreach kullanın
        }

        public static List<int> CiftSayilariFiltrele(int[] dizi)
        {
            // foreach ve if kullanın
        }

        public static int SayiTekrarSay(int[] dizi, int aranan)
        {
            // foreach kullanın
        }
    }
}
```

---

## ✅ Teslim Formatı

1. `submissions/` klasörüne gidin
2. Dosya adı: `Problem4_OGRENCI_NO.cs`
3. Örnek: `Problem4_210316011.cs`

---

## 🧪 Test Edilen Durumlar

| Test | Beklenen |
|------|----------|
| `DiziToplami([1,2,3,4,5])` | `15` |
| `DiziToplami([])` | `0` |
| `DiziOrtalamasi([10,20,30])` | `20.0` |
| `EnBuyukBul([3,7,2,9,1])` | `9` |
| `EnKucukBul([3,7,2,9,1])` | `1` |
| `CiftSayilariFiltrele([1,2,3,4,5,6])` | `[2,4,6]` |
| `SayiTekrarSay([1,2,3,2,4,2], 2)` | `3` |

---

## 💡 İpuçları

1. `foreach (int x in dizi) { ... }`
2. Boş dizi kontrolü: `if (dizi.Length == 0)`
3. `using System.Collections.Generic;` eklemeyi unutmayın
4. Liste'ye ekleme: `liste.Add(eleman);`
5. En büyük/küçük için başlangıç değeri: `dizi[0]`

---

**Puan: 25**
