using System.Collections.Generic;
using FluentAssertions;
using GildedRoseDomain.Models;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredItemTest
    {
        [Theory]
        [InlineData(3, 6)]
        [InlineData(-20, 6)]
        [InlineData(20, 6)]
        [InlineData(-9, 3)]
        [InlineData(9, 3)]
        [InlineData(-5, 7)]
        [InlineData(5, 7)]
        [InlineData(0, 0)]
        [InlineData(-50, 0)]
        [InlineData(0, 50)]
        public void RunTest(int sellIn, int quality)
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new ConjuredItem
                {
                    Name = "Conjured Mana Cake",
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
                    itemQuality -= 2;
                }
                else
                {
                    itemQuality -= 4;
                }

                if (itemQuality < 0)
                {
                    itemQuality = 0;
                }
            }
        }
    }
}