using UnityEngine;
using Verse;

namespace ResizeFilterTab
{
    public class Settings : ModSettings
    {
        public float StorageHeight = 480f;
        private string _storageHeightBuf;
        public float StorageWidth = 300f;
        private string _storageWidthBuf;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref StorageHeight, "StorageHeight", 480f);
            Scribe_Values.Look(ref StorageWidth, "StorageWidth", 300f);
            base.ExposeData();
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            var listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("ResizeFilterTab.StorageTab".Translate());
            listingStandard.TextFieldNumericLabeled(
                "ResizeFilterTab.Height".Translate(),
                ref StorageHeight, ref _storageHeightBuf, 0f, 7680f);
            listingStandard.TextFieldNumericLabeled(
                "ResizeFilterTab.Width".Translate(),
                ref StorageWidth, ref _storageWidthBuf, 0f, 7680f);
            listingStandard.End();
        }
    }
}
