using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public static GameManager GameManagerInstance
    { get { return gameManager; } }
    [SerializeField] private PlayerInfoSO playerInfo;

    private UIManager uiManager;
    private Character player;
    public Character Player
    {
        get { return player; }
    }

    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(this);
        }

        player = new Character(playerInfo);
    }

    void Start()
    {
        uiManager = UIManager.Instance;
    }

    void Update()
    {
        
    }
}
