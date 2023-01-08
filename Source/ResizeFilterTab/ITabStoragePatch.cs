using HarmonyLib;
using RimWorld;
using UnityEngine;

namespace ResizeFilterTab
{
    [HarmonyPatch(typeof(ITab_Storage), nameof(ITab_Storage.OnOpen))]
    public static class ITabPatch
    {
        public static void Prefix(ref Vector2 ___WinSize, ref Vector2 ___size)
        {
            var settings = ResizeFilterTab.Instance.Settings;
            ___WinSize.x = settings.StorageWidth;
            ___WinSize.y = settings.StorageHeight;
            ___size.x = settings.StorageWidth;
            ___size.y = settings.StorageHeight;
        }
    }
}
