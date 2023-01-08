using HarmonyLib;
using UnityEngine;
using Verse;

namespace ResizeFilterTab
{
    public class ResizeFilterTab : Mod
    {
        public static ResizeFilterTab Instance => LoadedModManager.GetMod<ResizeFilterTab>();
        public readonly Settings Settings;

        public ResizeFilterTab(ModContentPack content) : base(content)
        {
            Settings = GetSettings<Settings>();
            var harmony = new Harmony("Nonnonstop.ResizeCharacterInfo");
            harmony.PatchAll();
        }

        public override string SettingsCategory()
        {
            return "Resize Filter Tab";
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoSettingsWindowContents(inRect);
            base.DoSettingsWindowContents(inRect);
        }
    }
}
