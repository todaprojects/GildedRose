using System.Collections.Generic;
using FluentAssertions;
using GildedRoseDomain.Models;
using Xunit;

namespace GildedRoseTests
{
    public class SulfurasItemTests
    {
        [Theory]
        [InlineData(15, 80)]
        [InlineData(10, 80)]
        [InlineData(5, 80)]
        [InlineData(-5, 80)]
        [InlineData(-100, 80)]
        [InlineData(100, 80)]
        [InlineData(80, 80)]
        [InlineData(-1, 80)]
        [InlineData(1, 80)]
        [InlineData(0, 80)]
        public void RunTest(int sellIn, int quality)
        {
            IList<BaseItem> items = new List<BaseItem>
            {
                new SulfurasItem
                {
                    Name = "Sulfuras, Hand of Ragnaros",
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
            }
        }
    }
}