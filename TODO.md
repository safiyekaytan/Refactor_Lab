# ?? TODO List - RefactorLab

## ?? Ana Hedef
`GildedRose.cs` dosyas?ndaki `UpdateQuality()` metodunu Clean Code prensiplerine uygun olarak refactor etmek.

---

## ? Yap?lacaklar Listesi

### 1?? Kodu Anlama ve Analiz (Zorunlu)
- [ ] Mevcut `UpdateQuality()` metodunu incele ve nas?l çal??t???n? anla
- [ ] Her bir ürün tipinin kurallar?n? belirle
- [ ] ?ç içe if-else yap?lar?n? ka??da döküp görselle?tir
- [ ] Kod ak???n? flowchart veya pseudocode olarak ç?kar
- [ ] Mevcut testleri çal??t?r ve ne test ettiklerini anla

### 2?? Magic Number'lar? Temizleme (Yüksek Öncelik)
- [ ] `50` (maksimum quality) de?erini constant yap
- [ ] `0` (minimum quality) de?erini constant yap
- [ ] `11`, `6` (backstage pass e?ik de?erleri) için constant tan?mla
- [ ] Di?er magic number'lar? belirle ve isimlendirmeleri dü?ün

### 3?? String Literal'leri Düzenleme (Yüksek Öncelik)
- [ ] "Aged Brie", "Sulfuras, Hand of Ragnaros", "Backstage passes..." string'lerini constant/enum yap
- [ ] Ürün isimlerini merkezi bir yerden yönetmeyi dü?ün

### 4?? Metot Ayr??t?rma (Extract Method) (Yüksek Öncelik)
- [ ] ?ç içe if yap?lar?n? anlaml? metodlara böl
- [ ] Her ürün tipi için ayr? update metotlar? olu?turmay? de?erlendir
- [ ] Quality art?rma/azaltma i?lemlerini ayr? metodlara al
- [ ] SellIn güncelleme mant???n? ayr? metoda al

### 5?? Kod Tekrar?n? Giderme (DRY Prensibi) (Orta Öncelik)
- [ ] Quality art?rma i?lemlerindeki tekrarlar? belirle
- [ ] Quality azaltma i?lemlerindeki tekrarlar? belirle
- [ ] Quality limit kontrollerini tek bir yerde topla
- [ ] Ürün ismi kontrollerini optimize et

### 6?? Polymorphism veya Strategy Pattern (Yüksek Öncelik - ?leri Seviye)
- [ ] Her ürün tipi için ayr? s?n?f/strateji olu?turmay? dü?ün
- [ ] `IItemUpdateStrategy` veya benzeri bir interface tan?mla
- [ ] Her ürün tipi için strategy implementasyonu yap
  - [ ] `NormalItemUpdateStrategy`
  - [ ] `AgedBrieUpdateStrategy`
  - [ ] `SulfurasUpdateStrategy`
  - [ ] `BackstagePassUpdateStrategy`
- [ ] Factory pattern ile do?ru strategy'yi seç

### 7?? SOLID Prensipleri Uygulama (Yüksek Öncelik)
- [ ] **Single Responsibility**: Her s?n?f/metot tek bir i? yaps?n
- [ ] **Open/Closed**: Yeni ürün tipi eklemek için mevcut kodu de?i?tirmeden geni?letebilme
- [ ] **Liskov Substitution**: Alt s?n?flar üst s?n?flar?n yerine kullan?labilsin
- [ ] **Interface Segregation**: Gereksiz ba??ml?l?klardan kaç?n
- [ ] **Dependency Inversion**: Somut s?n?flara de?il, soyutlamalara ba??ml? ol

### 8?? ?simlendirme ?yile?tirmeleri (Orta Öncelik)
- [ ] De?i?ken isimlerini daha aç?klay?c? yap
- [ ] Metot isimlerini i? mant???n? aç?klayacak ?ekilde düzenle
- [ ] Boolean dönen metodlar için `Is...`, `Has...`, `Can...` gibi prefix'ler kullan

### 9?? Kod Organizasyonu (Orta Öncelik)
- [ ] ?lgili s?n?flar? ayr? dosyalara ta??
- [ ] Gerekirse yeni klasörler olu?tur (örn: Strategies, Constants, Models)
- [ ] Using statement'lar? düzenle
- [ ] Namespace yap?s?n? gözden geçir

### ?? Test Etme (Zorunlu - Her Ad?mda)
- [ ] Her refactoring ad?m?ndan sonra testleri çal??t?r
- [ ] Tüm testlerin geçti?inden emin ol
- [ ] Gerekirse yeni edge case testleri ekle
- [ ] Code coverage'? kontrol et

### 1??1?? Dokümantasyon (Opsiyonel ama Tavsiye Edilen)
- [ ] Karma??k i? mant??? için aç?klay?c? yorumlar ekle
- [ ] XML documentation comment'lar? ekle
- [ ] README'ye yakla??m?n? ve tasar?m kararlar?n? aç?kla

### 1??2?? Bonus Görevler (Opsiyonel - ?leri Seviye)
- [ ] Null kontrolü ekle
- [ ] Exception handling ekle
- [ ] Logging mekanizmas? ekle
- [ ] Yeni ürün tipi ekleme senaryosunu dene (örn: "Conjured" items)
- [ ] Performance optimization dü?ün
- [ ] Immutability prensibini de?erlendir

---

## ?? Önerilen Çal??ma S?ras?

1. **?lk A?ama**: Kodu anlama (1. madde)
2. **?kinci A?ama**: Basit refactoring'ler (2-3-4. maddeler)
3. **Üçüncü A?ama**: Kod organizasyonu (5-8. maddeler)
4. **Dördüncü A?ama**: ?leri seviye refactoring (6-7. maddeler)
5. **Son A?ama**: Polish ve dokümantasyon (9-11. maddeler)

---

## ?? ?lerleme Takibi

**Tamamlanan**: 0 / X
**Kalan**: X

---

## ?? Hat?rlatmalar

- ? Her de?i?iklikten sonra `dotnet test` çal??t?r
- ? Küçük ad?mlarla ilerle
- ? Meaningful commit mesajlar? kullan
- ? Testler her zaman ye?il kalmal?!
- ? Kod okumak yazmaktan daha çok yap?l?r - okunabilirli?e odaklan

---

**?yi çal??malar!** ??
