using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class ItemView:MonoBehaviour
    {
        [SerializeField] private Image _panel;
        [SerializeField] private TextMeshProUGUI _nameUI;
        [SerializeField] private TextMeshProUGUI _quantityUI;

        public void SetSprite(Sprite sprite)
        {
            _panel.sprite = sprite;
        }

        public void SetName(string Name)
        {
            _nameUI.text = Name;
        }

        public void SetQuantity(int quantity)
        {
            _quantityUI.text = quantity.ToString();
        }
    }
}