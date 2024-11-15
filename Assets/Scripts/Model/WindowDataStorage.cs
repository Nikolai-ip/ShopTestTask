using System.Collections.Generic;
using System.Linq;
using Infrastructure;
using UnityEngine;

namespace Model
{
    public class WindowDataStorage: IWindowDataStorage
    {
        private Dictionary<string, ShopWindowData> _loadedWindows;

        public WindowDataStorage()
        {
            var windowData = Resources.LoadAll<ShopWindowData>(AssetPath.ShowWindowDataFolder);
            _loadedWindows = windowData.ToDictionary(data => data.name);
        }

        public bool TryGetData(string windowName, int itemsCount, out ShopWindowData shopWindowData)
        {
            shopWindowData = null;
            if (_loadedWindows.TryGetValue(windowName, out var window))
            {
                shopWindowData = window;
                if (itemsCount < shopWindowData.ItemMapping.Data.Count)
                {
                    shopWindowData.ItemMapping.ItemsCount = itemsCount;
                }
                else
                {
                    shopWindowData.ItemMapping.ItemsCount = shopWindowData.ItemMapping.Data.Count;
                }
                return true;
            }
            return false;
        }


    }
}