using GildedRoseDomain.Models;

namespace GildedRoseDomain.Helpers
{
    public static class ItemQualityHelper
    {
        public static int SetToMaxQuality(BaseItem item, int maxQuality)
        {
            var itemQuality = item.Quality;
            
            if (itemQuality > maxQuality)
            {
                itemQuality = maxQuality;
            }

            return itemQuality;
        }
        
        public static int SetToMinQuality(BaseItem item, int minQuality)
        {
            var itemQuality = item.Quality;
            
            if (itemQuality < minQuality)
            {
                itemQuality = minQuality;
            }

            return itemQuality;
        }
    }
}