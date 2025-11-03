# ?? RefactorLab - Kurulum ve Kullan?m K?lavuzu

## ?? Gereksinimler

- **.NET 8 SDK** veya üzeri
- **Visual Studio 2022** veya **Visual Studio Code** (opsiyonel)
- **Git** (opsiyonel - versiyon kontrolü için)

## ?? Kurulum

### 1. Projeyi ?ndirme/Klonlama

Bu projeyi ald?ktan sonra, proje klasörüne gidin:

```bash
cd RefactorLab
```

### 2. Ba??ml?l?klar? Yükleme

```bash
dotnet restore RefactorLab.sln
```

### 3. Projeyi Build Etme

```bash
dotnet build RefactorLab.sln -c Debug
```

### 4. Testleri Çal??t?rma

```bash
dotnet test
```

**Beklenen Ç?kt?**: 12 testin tamam? ba?ar?l? olmal?d?r.

```
Test summary: total: 12, failed: 0, succeeded: 12, skipped: 0
Build succeeded
```

## ?? Proje Yap?s?

```
RefactorLab/
??? RefactorLab/                          # Ana uygulama projesi
?   ??? RefactorLab.cs                    # ?? Refactor edilecek ana dosya
?   ??? Item.cs                          # Item model s?n?f? (DOKUNMAYIN!)
?   ??? Program.cs                       # Console uygulamas?
?   ??? RefactorLab.csproj               # Proje dosyas?
?
??? RefactorLabTests/                     # Test projesi
?   ??? RefactorLabTest.cs               # Unit testler
?   ??? RefactorLabTests.csproj          # Test proje dosyas?
?
??? RefactorLab.sln                     # Solution dosyas?
??? README.md                            # Ana proje aç?klamas?
??? TODO.md                              # Yap?lacaklar listesi 
??? SETUP.md                             # Bu dosya
```

## ?? Ba?lang?ç Ad?mlar?

### Ad?m 1: Projeyi Anlay?n
1. `README.md` dosyas?n? okuyun
2. ?? kurallar?n? inceleyin
3. Mevcut `RefactorLab.cs` kodunu okuyun

### Ad?m 2: Testleri ?nceleyin
```bash
dotnet test --logger "console;verbosity=detailed"
```

### Ad?m 3: TODO Listesini Kontrol Edin
`TODO.md` dosyas?n? aç?n ve yap?lacaklar? inceleyin.

### Ad?m 4: Refactoring'e Ba?lay?n
- Her de?i?iklikten sonra testleri çal??t?r?n
- Küçük ad?mlarla ilerleyin
- Git kullan?yorsan?z anlaml? commit'ler yap?n

## ?? Test Komutlar?

### Tüm Testleri Çal??t?rma
```bash
dotnet test
```

### Detayl? Test Ç?kt?s?
```bash
dotnet test --logger "console;verbosity=detailed"
```

### Sadece Belirli Bir Test
```bash
dotnet test --filter "FullyQualifiedName~RefactorLabTests.RefactorLabTest.NormalItem_BeforeSellDate_QualityDecreasesByOne"
```

### Test Coverage (Opsiyonel)
```bash
dotnet test /p:CollectCoverage=true
```

## ?? Console Uygulamas?n? Çal??t?rma

Console uygulamas?, belirli say?da gün için simülasyon çal??t?r?r:

```bash
# 10 günlük simülasyon
dotnet run --project RefactorLab 10

# veya build edildikten sonra:
RefactorLab/bin/Debug/net8.0/RefactorLab.exe 10
```

## ?? Visual Studio'da Çal??ma

1. `RefactorLab.sln` dosyas?n? Visual Studio ile aç?n
2. Solution Explorer'da projeleri görüntüleyin
3. Test Explorer'? aç?n: `Test > Test Explorer`
4. `RefactorLab.cs` dosyas?n? aç?n ve refactoring'e ba?lay?n

## ?? Visual Studio Code'da Çal??ma

1. RefactorLab klasörünü VS Code ile aç?n
2. C# extension'?n? yükleyin (ms-dotnettools.csharp)
3. Terminal aç?n: `Ctrl + ` ` (backtick)
4. Testleri çal??t?r?n: `dotnet test`

## ?? Önemli Kurallar

### ? YAPMAYIN:
- `Item.cs` dosyas?n? de?i?tirmeyin
- Mevcut testleri silmeyin veya de?i?tirmeyin
- ?? kurallar?n? de?i?tirmeyin

### ? YAPIN:
- Yeni s?n?flar ve dosyalar ekleyin
- Testlerin her zaman geçti?inden emin olun
- Clean Code prensiplerine uyun
- Git commit'lerinizi düzenli yap?n

## ?? Sorun Giderme

### Build Hatalar?
```bash
# Temiz build
dotnet clean
dotnet restore
dotnet build
```

### Test Hatalar?
```bash
# Cache temizleme
dotnet clean
dotnet test --no-build
```

### NuGet Paketleri
```bash
# Paketleri yeniden yükleme
dotnet restore --force
```

## ?? Yararl? Komutlar

```bash
# Tüm ç?kt?lar? temizle
dotnet clean

# Release mode build
dotnet build -c Release

# Watch mode (kod de?i?tikçe test çal??t?r)
dotnet watch test

# Proje bilgilerini görüntüle
dotnet --info
```

## ?? E?itim Kaynaklar?

- [Clean Code Principles](https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
- [Refactoring by Martin Fowler](https://refactoring.com/)
- [SOLID Principles](https://en.wikipedia.org/wiki/SOLID)
- [Design Patterns](https://refactoring.guru/design-patterns)

## ?? ?puçlar?

1. **Testleri s?k çal??t?r?n** - Her de?i?iklikten sonra
2. **Küçük ad?mlar** - Bir seferde bir ?ey de?i?tirin
3. **Commit s?k yap?n** - Her ba?ar?l? ad?mda
4. **Kod okuyun** - Yazmadan önce anlay?n
5. **Soru sorun** - Anlamad???n?z her ?ey için

---

**Haz?rs?n?z! Refactoring'e ba?layabilirsiniz!** ??

Sorular?n?z için: ?leti?im bilgileri...
