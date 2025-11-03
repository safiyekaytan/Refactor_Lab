# RefactorLab

## ?? Proje Hakk?nda

**RefactorLab**, yaz?l?m geli?tirici adaylar?n?n **Clean Code** prensiplerine uygun kod yazma ve **refactoring** yeteneklerini de?erlendirmek için haz?rlanm?? bir e?itim projesidir.

Bu laboratuvar ortam?nda, gerçek dünya senaryolar?n? simüle eden legacy kod üzerinde çal??arak refactoring becerilerinizi geli?tireceksiniz.

## ?? Görev Tan?m?

Mevcut `RefactorLab.cs` dosyas?ndaki `UpdateQuality()` metodu i?levsel olarak çal??maktad?r ancak kodun okunabilirli?i ve sürdürülebilirli?i dü?üktür. Sizden beklenen, bu kodu **Clean Code** prensiplerine uygun ?ekilde yeniden düzenlemektir.

## ? Build ve Test Komutlar?

### Projeyi Build Etme
```bash
dotnet build RefactorLab.sln -c Debug
```

### Tüm Testleri Çal??t?rma
```bash
dotnet test
```

### Console Uygulamas?n? Çal??t?rma
Örnek: 10 gün simülasyonu
```bash
RefactorLab/bin/Debug/net8.0/RefactorLab 10
```

?? **UYARI**: Refactoring s?ras?nda tüm testlerin ba?ar?l? çal??maya devam etmesi gerekmektedir!

## ?? Proje Yap?s?

```
RefactorLab/
??? RefactorLab/              # Ana proje
?   ??? RefactorLab.cs        # Refactor edilecek ana dosya
?   ??? Item.cs              # Item s?n?f? (de?i?tirilemez)
?   ??? Program.cs           # Console uygulamas?
??? RefactorLabTests/         # Test projesi
?   ??? RefactorLabTest.cs    # Unit testler
??? README.md                # Bu dosya
??? TODO.md                  # Yap?lacaklar listesi
??? RefactorLab.sln          # Solution dosyas?
```

## ?? De?erlendirme Süreci

1. Kodu anlama ve i? kurallar?n? kavrama
2. Clean Code prensiplerine uygunluk
3. SOLID prensiplerine uygunluk
4. Tasar?m desenleri kullan?m?
5. Testlerin geçmesi
6. Kod organizasyonu ve okunabilirlik
7. Genel yakla??m ve çözüm kalitesi

---

**Ba?ar?lar!** ??