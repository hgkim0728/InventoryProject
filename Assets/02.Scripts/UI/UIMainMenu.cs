using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    private UIManager uiManager;
    private GameManager gameManager;

    [SerializeField] private GameObject buttons;
    private Button statusButton;
    private Button inventoryButton;

    [SerializeField] private Text playerNameText;
    [SerializeField] private Text playerLevelText;
    [SerializeField] private Image playerCurExpSliderImage;
    [SerializeField] private Text playerCurExpText;
    [SerializeField] private Text playerInfoText;
    [SerializeField] private Text goldText;

    void Start()
    {
        uiManager = UIManager.Instance;
        gameManager = GameManager.GameManagerInstance;
        statusButton = buttons.transform.GetChild(0).GetComponent<Button>();
        inventoryButton = buttons.transform.GetChild(1).GetComponent<Button>();

        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        buttons.SetActive(true);
        uiManager.StatusObj.SetActive(false);
        uiManager.InventoryObj.SetActive(false);
    }

    void OpenStatus()
    {
        uiManager.StatusObj.SetActive(true);
        buttons.SetActive(false);
        uiManager.Status.SetStatus();
    }

    void OpenInventory()
    {
        uiManager.InventoryObj.SetActive(true);
        buttons.SetActive(false);
        uiManager.Inventory.SetInventory();
    }

    public void SetData(PlayerInfoSO _playerInfo)
    {
        playerNameText.text = _playerInfo.CharacterName;
        playerInfoText.text = _playerInfo.CharacterInfo;
        playerLevelText.text = _playerInfo.CurPlayerLevel.ToString();
        playerCurExpSliderImage.fillAmount = (float)_playerInfo.CurCharacterExp / _playerInfo.MaxPlayerExp;
        playerCurExpText.text = $"{_playerInfo.CurCharacterExp} / {_playerInfo.MaxPlayerExp}";
        goldText.text = _playerInfo.PlayerGold.ToString();
    }
}
