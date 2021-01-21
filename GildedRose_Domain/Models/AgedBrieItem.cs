namespace GildedRose_Domain.Models
{
    public class AgedBrieItem : BaseItem
    {
        /// <summary>
        /// "Aged Brie" actually increases in Quality the older it gets
        /// The Quality of an item is never more than 50
        /// </summary>
        public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality += SellIn >= 0 ? 1 : 2;

            if (Quality > MaxQuality)
            {
                Quality = MaxQuality;
            }
        }
    }
}