using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Image slotImage;
    [SerializeField] private Button itemButton;
    private Outline outLine;
    private ItemSO itemData;

    public void InitSlot()
    {
        gameManager = GameManager.GameManagerInstance;
        outLine = GetComponent<Outline>();
        itemButton.onClick.AddListener(EquipItem);
        RefreshUI();
    }

    public void SetItem(ItemSO _data)
    {
        itemData = _data;
        slotImage.enabled = true;
        slotImage.sprite = _data.ItemSprite;
        outLine.enabled = _data.IsEauip;
    }

    public void RefreshUI()
    {
        itemData = null;
        outLine.enabled = false;
        slotImage.sprite = null;
        slotImage.enabled = false;
    }

    void EquipItem()
    {
        if (itemData == null) return;

        itemData.IsEauip = !itemData.IsEauip;
        
        if(itemData.IsEauip)
        {
            Equip();
        }
        else
        {
            UnEquip();
        }

        outLine.enabled = itemData.IsEauip;
    }

    void Equip()
    {
        switch(itemData.Type)
        {
            case ItemType.Weapon:
                gameManager.Player.PlayerInfo.StatSOs[0].StatValue += itemData.Value;
                break;

            case ItemType.Shield:
                gameManager.Player.PlayerInfo.StatSOs[1].StatValue += itemData.Value;
                break;

            case ItemType.Armor:
                gameManager.Player.PlayerInfo.StatSOs[2].StatValue += itemData.Value;
                break;

            case ItemType.Critical:
                gameManager.Player.PlayerInfo.StatSOs[3].StatValue += itemData.Value;
                break;
        }
    }

    void UnEquip()
    {
        switch (itemData.Type)
        {
            case ItemType.Weapon:
                gameManager.Player.PlayerInfo.StatSOs[0].StatValue -= itemData.Value;
                break;

            case ItemType.Shield:
                gameManager.Player.PlayerInfo.StatSOs[1].StatValue -= itemData.Value;
                break;

            case ItemType.Armor:
                gameManager.Player.PlayerInfo.StatSOs[2].StatValue -= itemData.Value;
                break;

            case ItemType.Critical:
                gameManager.Player.PlayerInfo.StatSOs[3].StatValue -= itemData.Value;
                break;
        }
    }
}