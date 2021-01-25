using System.Collections.Generic;
using FluentAssertions;
using GildedRoseDomain.Models;
using Xunit;

namespace GildedRoseTests
{
    public class BackstagePassesItemTest
    {
        [Theory]
        [InlineData(15, 20)]
        [InlineData(-10, 49)]
        [InlineData(10, 49)]
        [InlineData(-5, 49)]
        [InlineData(5, 49)]
        [InlineData(-5, 7)]
        [InlineData(0, 0)]
        [InlineData(-50, 0)]
        [InlineData(50, 0)]
        [InlineData(0, 50)]
        public void RunTest(int sellIn, int quality)
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new BackstagePassesItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            var itemSellIn = items[0].SellIn;
            var itemQuality = items[0].Quality;

            for (var i = 0; i < 31; i++)
            {
                var item = items[0];
                
                item.SellIn.Should().Be(itemSellIn);
                item.Quality.Should().Be(itemQuality);

                item.UpdateQuality();

                itemSellIn -= 1;

                if (itemSellIn >= 0)
                {
                    if (itemSellIn >= 10)
                    {
                        itemQuality += 1;
                    }
                    else if (itemSellIn >= 5)
                    {
                        itemQuality += 2;
                    }
                    else
                    {
                        itemQuality += 3;
                    }
                }
                else
                {
                    itemQuality = 0;
                }

                if (itemQuality > 50)
                {
                    itemQuality = 50;
                }
            }
        }
    }
}