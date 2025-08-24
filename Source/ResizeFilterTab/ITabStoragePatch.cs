using HarmonyLib;
using RimWorld;
using UnityEngine;

namespace ResizeFilterTab
{
    public static class ResizeHelper
    {
        public static void ApplyResize(ref Vector2 winSize, ref Vector2 size)
        {
            var settings = ResizeFilterTab.Instance.Settings;
            winSize.x = settings.StorageWidth;
            winSize.y = settings.StorageHeight;
            size.x = settings.StorageWidth;
            size.y = settings.StorageHeight;
        }
    }

    [HarmonyPatch(typeof(ITab_Storage), nameof(ITab_Storage.OnOpen))]
    public static class ITabStoragePatch
    {
        public static void Prefix(ref Vector2 ___WinSize, ref Vector2 ___size)
        {
            ResizeHelper.ApplyResize(ref ___WinSize, ref ___size);
        }
    }

    [HarmonyPatch(typeof(ITab_PenAnimals), nameof(ITab_PenAnimals.OnOpen))]
    public static class ITabPenAnimalsPatch
    {
        public static void Prefix(ref Vector2 ___WinSize, ref Vector2 ___size)
        {
            ResizeHelper.ApplyResize(ref ___WinSize, ref ___size);
        }
    }

    [HarmonyPatch(typeof(ITab_PenAutoCut), nameof(ITab_PenAutoCut.OnOpen))]
    public static class ITabPenAutoCutPatch
    {
        public static void Prefix(ref Vector2 ___WinSize, ref Vector2 ___size)
        {
            ResizeHelper.ApplyResize(ref ___WinSize, ref ___size);
        }
    }
}
