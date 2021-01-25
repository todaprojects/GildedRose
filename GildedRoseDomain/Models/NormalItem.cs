using GildedRoseDomain.Helpers;

namespace GildedRoseDomain.Models
{
    public class NormalItem : BaseItem
    {
        /// <summary>
        /// Once the sell by date has passed, Quality degrades twice as fast
        /// The Quality of an item is never negative
        /// </summary>
        public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality -= SellIn >= 0 ? 1 : 2;

            Quality = ItemQualityHelper.SetToMinQuality(this, MinQuality);
        }
    }
}