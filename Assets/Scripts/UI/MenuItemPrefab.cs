using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemPrefab : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemDescription;
    public Image itemSprite;

    public void Create(string name, string description, Sprite icon)
    {
        itemName.text = name;
        itemDescription.text = description;
        itemSprite.sprite = icon;
    }
}