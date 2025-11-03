using System.Collections.Generic;
using RefactorLabKata;
using NUnit.Framework;

namespace RefactorLabTests;

public class RefactorLabTest
{
    [Test]
    public void NormalItem_BeforeSellDate_QualityDecreasesByOne()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 10 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(9));
        Assert.That(items[0].SellIn, Is.EqualTo(4));
    }

    [Test]
    public void NormalItem_AfterSellDate_QualityDecreasesByTwo()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 0, Quality = 10 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(8));
        Assert.That(items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
    public void EskiKasarPeyniri_BeforeSellDate_QualityIncreasesByOne()
    {
        var items = new List<Item> { new Item { Name = "Eski Kaşar Peyniri", SellIn = 5, Quality = 10 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(11));
        Assert.That(items[0].SellIn, Is.EqualTo(4));
    }

    [Test]
    public void EskiKasarPeyniri_AfterSellDate_QualityIncreasesByTwo()
    {
        var items = new List<Item> { new Item { Name = "Eski Kaşar Peyniri", SellIn = 0, Quality = 10 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(12));
    }

    [Test]
    public void SebzeMeyve_QualityAndSellInNeverChange()
    {
        var items = new List<Item> { new Item { Name = "Sebze meyve", SellIn = 5, Quality = 80 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(80));
        Assert.That(items[0].SellIn, Is.EqualTo(5));
    }

    [Test]
    public void Bilet_MoreThan10Days_QualityIncreasesByOne()
    {
        var items = new List<Item> { new Item { Name = "Bulutsuzluk özlemi konser bileti", SellIn = 15, Quality = 20 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(21));
    }

    [Test]
    public void Bilet_10DaysOrLess_QualityIncreasesByTwo()
    {
        var items = new List<Item> { new Item { Name = "Bulutsuzluk özlemi konser bileti", SellIn = 10, Quality = 20 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(22));
    }

    [Test]
    public void Bilet_5DaysOrLess_QualityIncreasesByThree()
    {
        var items = new List<Item> { new Item { Name = "Bulutsuzluk özlemi konser bileti", SellIn = 5, Quality = 20 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(23));
    }

    [Test]
    public void Bilet_AfterConcert_QualityDropsToZero()
    {
        var items = new List<Item> { new Item { Name = "Bulutsuzluk özlemi konser bileti", SellIn = 0, Quality = 20 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void Quality_NeverNegative()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 0 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void Quality_NeverMoreThan50_ExceptSebzeMeyve()
    {
        var items = new List<Item> { new Item { Name = "Eski Kaşar Peyniri", SellIn = 5, Quality = 50 } };
        var app = new RefactorLab(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(50));
        Assert.That(items[0].Name, Is.EqualTo("fixme"));
    }
}