using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemMapping", menuName = "ScriptableObjects/ItemMapping")]
public class ItemMapping : ScriptableObject
{
    public List<ItemData> Data;

    [System.Serializable]
    public class ItemData
    {
        public string Name;
        public Sprite Sprite;
        public int Quantity;
    }
}
