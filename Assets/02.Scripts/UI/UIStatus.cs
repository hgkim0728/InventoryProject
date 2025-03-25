using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    private UIManager uiManager;
    private GameManager gameManager;

    [SerializeField] private Button backButton;
    [SerializeField] private Transform statPanel;
    [SerializeField] private GameObject statPrefab;

    void Start()
    {
        uiManager = UIManager.Instance;
        gameManager = GameManager.GameManagerInstance;
    }

    public void Init()
    {
        backButton.onClick.AddListener(uiManager.MainMenu.OpenMainMenu);
        StatSO[] stats = gameManager.Player.PlayerInfo.Stats;
        int length = stats.Length;

        for(int i = 0; i < length; i++)
        {
            GameObject stat = Instantiate(statPrefab, statPanel);
            stat.GetComponent<Stat>().SetStat(stats[i]);
        }
    }

    void Update()
    {
        
    }
}
