using System;
using System.Collections.Generic;

namespace RefactorLabKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MERHABA!");

        IList<Item> items = new List<Item>
        {
            new Item {Name = "+3 Fotokopi", SellIn = 10, Quality = 20},
            new Item {Name = "Eski Kaşar Peyniri", SellIn = 2, Quality = 0},
            new Item {Name = "Gemlik zeytini", SellIn = 5, Quality = 7},
            new Item {Name = "Sebze meyve", SellIn = 0, Quality = 80},
            new Item {Name = "Sebze meyve", SellIn = -1, Quality = 80},
            new Item
            {
                Name = "Bulutsuzluk özlemi konser bileti",
                SellIn = 15,
                Quality = 20
            },
            new Item
            {
                Name = "Bulutsuzluk özlemi konser bileti",
                SellIn = 10,
                Quality = 49
            },
            new Item
            {
                Name = "Bulutsuzluk özlemi konser bileti",
                SellIn = 5,
                Quality = 49
            }, 
            new Item {Name = "Çatapat", SellIn = 3, Quality = 6}
        };

        var app = new RefactorLab(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}