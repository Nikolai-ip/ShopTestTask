using System.Globalization;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace View
{
    public class BuyButtonView:MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _priceUI;
        [SerializeField] private Image _discountLabel;
        [SerializeField] private TextMeshProUGUI _discountText;
        [SerializeField] private Color _strikeThroughTextColor;
        public void SetView(ShopWindowData windowData)
        {
            if (windowData.Discount > 0)
            {
                _discountLabel.enabled = true;
                _discountText.text = windowData.Discount.ToString(CultureInfo.InvariantCulture);
                string colorHex = ColorUtility.ToHtmlStringRGB(_strikeThroughTextColor);
                _priceUI.text = $"${windowData.Price * ((100 - windowData.Discount) / 100)}\n" +
                                $"<color=#{colorHex}>$<s>{windowData.Price}</s></color>";            }
            else
            {
                _discountLabel.enabled = false;
                _priceUI.text = $"${windowData.Price}";
            }
            
        }
    }
}