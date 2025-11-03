using System.Collections.Generic;

namespace RefactorLabKata
{
    public static class QualityConstants
    {
        public const int QualityMax = 50;
        public const int QualityMin = 0;
        public const int Treshold_1 = 10;
        public const int Treshold_2 = 5;
    }

    public static class ItemNames
    {
        public const string Cheese = "Eski Kaşar Peyniri";
        public const string Concert = "Bulutsuzluk özlemi konser bileti";
        public const string Vegetable = "Sebze meyve";
    }

    public class RefactorLab
    {
        private readonly IList<Item> listItems;

        private readonly Dictionary<string, IItemUpdater> _itemUpdaters = new()
        {
            { ItemNames.Cheese, new CheeseUpdater() },
            { ItemNames.Concert, new ConcertUpdater() },
            { ItemNames.Vegetable, new NothingUpdater() }
        };

        public RefactorLab(IList<Item> items)
        {
            listItems = items;
        }

        public void UpdateQuality()
        {
            var defaultUpdater = new DefaultItemUpdater();

            foreach (var item in listItems)
            {
                var updaterItems = _itemUpdaters.ContainsKey(item.Name)
                    ? _itemUpdaters[item.Name]
                    : defaultUpdater;

                updaterItems.Update(item);
            }
        }
    }

    public interface IItemUpdater
    {
        void Update(Item item);
    }

    
    public abstract class ItemsUpdaterDefault : IItemUpdater
    {
        public abstract void Update(Item item);

        protected void IncreaseQuality(Item item)
        {
            item.Quality = System.Math.Min(item.Quality + 1, QualityConstants.QualityMax);
        }

        protected void DecreaseQuality(Item item)
        {
            item.Quality = System.Math.Max(item.Quality - 1, QualityConstants.QualityMin);
        }

        protected void Decrease_SellIn(Item item)
        {
            item.SellIn--;
        }
    }
    

    public class DefaultItemUpdater : ItemsUpdaterDefault
    {
        public override void Update(Item item)
        {
            DecreaseQuality(item);
            Decrease_SellIn(item);

            if (item.SellIn < 0)
                DecreaseQuality(item);
        }
    }

    public class CheeseUpdater : ItemsUpdaterDefault
    {
        public override void Update(Item item)
        {
            IncreaseQuality(item);
            Decrease_SellIn(item);

            if (item.SellIn < 0)
                IncreaseQuality(item);
        }
    }

    public class NothingUpdater : ItemsUpdaterDefault
    {
        public override void Update(Item item)
        {
            //nothing
        }
    }

    public class ConcertUpdater : ItemsUpdaterDefault
    {
        public override void Update(Item item)
        {
            if (item.Quality < QualityConstants.QualityMax)
            {
                IncreaseQuality(item);

                if (item.SellIn <= QualityConstants.Treshold_1)
                    IncreaseQuality(item);

                if (item.SellIn <= QualityConstants.Treshold_2)
                    IncreaseQuality(item);
            }

                Decrease_SellIn(item);

            if (item.SellIn < 0)
                item.Quality = QualityConstants.QualityMin;
        }
    }
}
