using Infrastructure;
using Signals;
using TMPro;
using UnityEngine;

namespace View
{
    public class PackButton:MonoBehaviour
    {
        [SerializeField] private TMP_InputField _itemsCount;
        [SerializeField] private string _windowPackName;
        
        public void OnClick()
        {
            int itemsCount = 0;
            if (int.TryParse(_itemsCount.text, out int result))
            {
                itemsCount = result;
            }
            EventBus.Invoke(new ShowShopWindow(_windowPackName, itemsCount));
        }
    }
}