using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using View;

namespace Container
{
    public class ResourceMappingContainer: MonoBehaviour, IResourceMappingContainer
    {
        private List<ItemView> _itemViews = new List<ItemView>();
        [SerializeField] private int _itemCount;
        
        public void Init()
        {
            CreateItems();
        }
        
        public void SetView(ItemMapping itemMapping)
        {
            DisableItems();
            for (int i = 0; i < itemMapping.ItemsCount; i++)
            {
                _itemViews[i].gameObject.SetActive(true);
                _itemViews[i].SetSprite(itemMapping.Data[i].Sprite);
                _itemViews[i].SetName(itemMapping.Data[i].Name);
                _itemViews[i].SetQuantity(itemMapping.Data[i].Quantity);
            }
        }

        private void DisableItems()
        {
            foreach (var itemView in _itemViews)
            {
                itemView.gameObject.SetActive(false);
            }
        }


        private void CreateItems()
        {
            var itemPrefab = Resources.Load<ItemView>(AssetPath.ItemPrefab);
            for (int i = 0; i < _itemCount; i++)
            {
                var newItem = Instantiate(itemPrefab, transform);
                _itemViews.Add(newItem);
            }
            
        }

    }
}