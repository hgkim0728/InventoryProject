using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    private UIManager uiManager;
    private GameManager gameManager;

    [SerializeField] private Button backButton;
    [SerializeField] private Transform content;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private int slotCount;

    private List<UISlot> slots = new List<UISlot>();

    public void Init()
    {
        gameManager = GameManager.GameManagerInstance;
        uiManager = UIManager.Instance;
        backButton.onClick.AddListener(uiManager.MainMenu.OpenMainMenu);

        for(int i = 0; i < slotCount; i++)
        {
            GameObject slotObj = Instantiate(slotPrefab, content);
            UISlot uiSlot = slotObj.GetComponent<UISlot>();
            slots.Add(uiSlot);
            uiSlot.InitSlot();
        }

        SetInventory();
    }

    public void SetInventory()
    {
        List<ItemSO> itemList = gameManager.Player.PlayerInfo.ListInventory;

        for(int i = 0; i < slotCount; i++)
        {
            if (itemList.Count > i)
            {
                slots[i].SetItem(itemList[i]);
            }
            else
            {
                slots[i].RefreshUI();
            }
        }
    }
}