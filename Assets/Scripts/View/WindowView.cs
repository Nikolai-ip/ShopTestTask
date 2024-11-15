using Container;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class WindowView:MonoBehaviour, IWindowView
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _titleUI;
        [SerializeField] private TextMeshProUGUI _descriptionUI;
        [SerializeField] private BuyButtonView _buyButton;
        private IResourceMappingContainer _resourceMappingContainer;

        public void Init(IResourceMappingContainer resourceMappingContainer)
        {
            _resourceMappingContainer = resourceMappingContainer;
            gameObject.SetActive(false);
        }
        public void SetView(ShopWindowData windowData)
        {
            gameObject.SetActive(true);
            _titleUI.text = windowData.Title;
            _descriptionUI.text = windowData.Description;
            _image.sprite = windowData.ProductSprite;
            _buyButton.SetView(windowData);
            _resourceMappingContainer.SetView(windowData.ItemMapping);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}