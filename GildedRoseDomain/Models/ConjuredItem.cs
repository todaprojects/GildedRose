namespace GildedRoseDomain.Models
{
    public class ConjuredItem : BaseItem
    {
        /// <summary>
        /// "Conjured" items degrade in Quality twice as fast as normal items
        /// </summary>
        public override void UpdateQuality()
        {
            SellIn -= 1;

            Quality -= SellIn >= 0 ? 2 : 4;

            if (Quality < MinQuality)
            {
                Quality = MinQuality;
            }
        }
    }
}