using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    private UIManager uiManager;
    private GameManager gameManager;

    [SerializeField] private Button backButton;
    [SerializeField] private Transform statPanel;
    [SerializeField] private GameObject statPrefab;
    private Stat[] stats;

    public void Init()
    {
        uiManager = UIManager.Instance;
        gameManager = GameManager.GameManagerInstance;
        stats = new Stat[gameManager.Player.PlayerInfo.StatSOs.Length];

        for(int i = 0; i < stats.Length; i++)
        {
            GameObject stat = Instantiate(statPrefab, statPanel);
            stats[i] = stat.GetComponent<Stat>();
        }

        backButton.onClick.AddListener(uiManager.MainMenu.OpenMainMenu);
        SetStatus();
    }

    public void SetStatus()
    {
        int length = stats.Length;
        StatSO[] SOs = gameManager.Player.PlayerInfo.StatSOs;

        for(int i = 0; i < length; i++)
        {
            stats[i].SetStat(SOs[i]);
        }
    }
}
