using GildedRoseDomain.Interfaces;

namespace GildedRoseDomain.Models
{
    public abstract class BaseItem : Item, IGildedRose
    {
        protected const int MaxQuality = 50;
        protected const int MinQuality = 0;
        public abstract void UpdateQuality();
    }
}