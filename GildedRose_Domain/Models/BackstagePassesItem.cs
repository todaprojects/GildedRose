namespace GildedRose_Domain.Models
{
    public class BackstagePassesItem : BaseItem
    {
        /// <summary>
        /// "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches
        /// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
        /// Quality drops to 0 after the concert
        /// </summary>
        public override void UpdateQuality()
        {
            SellIn -= 1;

            if (SellIn >= 0)
            {
                if (SellIn >= 5)
                {
                    Quality += SellIn >= 10 ? 1 : 2;
                }
                else
                {
                    Quality += 3;
                }
            }
            else
            {
                Quality = MinQuality;
            }

            if (Quality > MaxQuality)
            {
                Quality = MaxQuality;
            }
        }
    }
}