using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    private UIManager uiManager;

    [SerializeField] private Button backButton;

    void Start()
    {
        uiManager = UIManager.Instance;
    }

    public void Init()
    {
        backButton.onClick.AddListener(uiManager.MainMenu.OpenMainMenu);
    }

    void Update()
    {
        
    }
}
