using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }
    [SerializeField] private GameObject uiMainMenuObj;
    public GameObject MainMenuObj
    { 
        get { return uiMainMenuObj; }
        set { uiMainMenuObj = value; }
    }
    [SerializeField] private GameObject uiStatusObj;
    public GameObject StatusObj
    {
        get { return uiStatusObj; }
        set { uiStatusObj = value; }
    }
    [SerializeField] private GameObject uiInventoryObj;
    public GameObject InventoryObj
    {
        get { return uiInventoryObj; }
        set { uiInventoryObj = value; }
    }

    private UIMainMenu uiMainMenu;
    public UIMainMenu MainMenu { get  { return uiMainMenu; } }
    private UIStatus uiStatus;
    public UIStatus Status { get { return uiStatus; } }
    private UIInventory uiInventory;
    public UIInventory Inventory { get { return uiInventory; } }

    private void Awake()
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

    void Start()
    {
        gameManager = GameManager.GameManagerInstance;
        uiMainMenu.SetData(gameManager.Player.PlayerInfo);
        uiStatus.Init();
        uiInventory.Init();
        uiMainMenu.OpenMainMenu();
    }

    void Update()
    {
        
    }
}
