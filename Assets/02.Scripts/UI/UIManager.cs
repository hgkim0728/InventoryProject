using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }
    [SerializeField] GameObject uiMainMenuObj;
    [SerializeField] GameObject uiStatusObj;
    [SerializeField] GameObject uiInventoryObj;

    private UIMainMenu uiMainMenu;
    public UIMainMenu MainMenu
    {
        get { return uiMainMenu; }
        set { uiMainMenu = value; }
    }
    private UIStatus uiStatus;
    public UIStatus Status
    {
        get { return uiStatus; }
        set { uiStatus = value; }
    }
    private UIInventory uiInventory;
    public UIInventory Inventory
    {
        get { return uiInventory; }
        set { uiInventory = value; }
    }

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        uiMainMenu = uiMainMenuObj.GetComponent<UIMainMenu>();
        uiStatus = uiStatusObj.GetComponent<UIStatus>();
        uiInventory = uiInventoryObj.GetComponent<UIInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
