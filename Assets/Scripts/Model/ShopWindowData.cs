using UnityEngine;

namespace Model
{
    [CreateAssetMenu(fileName = "WindowData", menuName = "ScriptableObjects/WindowData")]
    public class ShopWindowData:ScriptableObject
    {
        public string Title;
        [TextArea] public string Description;
        public ItemMapping ItemMapping;
        public Sprite ProductSprite;
        public float Price;
        public float Discount;
    }
}