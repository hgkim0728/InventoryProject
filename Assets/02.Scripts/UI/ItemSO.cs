using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Shield,
    Critical
}

[CreateAssetMenu(fileName = "new ItemData", menuName = "ItemData")]
public class ItemSO : ScriptableObject
{
    [SerializeField] private Sprite itemSprite;
    public Sprite ItemSprite { get { return itemSprite; } }
    [SerializeField] private ItemType type;
    public ItemType Type {  get { return type; } }
    [SerializeField] private int value;
    public int Value {  get { return value; } }
    private bool isEquip = false;
    public bool IsEauip
    {
        get { return isEquip; }
        set { isEquip = value; }
    }
}
