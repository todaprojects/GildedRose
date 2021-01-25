namespace GildedRoseDomain.Models
{
    public class SulfurasItem : BaseItem
    {
        /// <summary>
        /// "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        /// </summary>
        public override void UpdateQuality()
        {
        }
    }
}