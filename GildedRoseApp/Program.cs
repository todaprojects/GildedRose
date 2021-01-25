using System;
using System.Collections.Generic;
using GildedRoseDomain.Models;

namespace GildedRoseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<BaseItem> items = new List<BaseItem>
            {
                new NormalItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrieItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new NormalItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new SulfurasItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePassesItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new BackstagePassesItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new BackstagePassesItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
                new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                    item.UpdateQuality();
                }

                Console.WriteLine("");
            }
        }
    }
}