using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new PlayerInfoSO", menuName = "PlayerInfo")]
public class PlayerInfoSO : ScriptableObject
{
    // 캐릭터 이름
    [SerializeField] private string characterName;
    public string CharacterName { get { return characterName; } }
    // 캐릭터 정보
    [SerializeField, Multiline] private string characterInfo;
    public string CharacterInfo { get { return characterInfo; } }
    // 현재 캐릭터 레벨
    [SerializeField] private int curPlayerLevel;
    public int CurPlayerLevel
    {
        get { return curPlayerLevel; }
        set { curPlayerLevel = value; }
    }
    // 다음 레벨이 되는데 필요한 경험치 총량 배열
    [SerializeField] private int[] exps;
    public int[] Exps { get  { return exps; } }
    // 다음 레벨이 되는데 필요한 경험치 총량
    private int maxPlayerExp;
    public int MaxPlayerExp
    {
        get { return maxPlayerExp; }
        set { maxPlayerExp = value; }
    }
    // 현재 모인 경험치
    [SerializeField] private int curCharacterExp;
    public int CurCharacterExp
    {
        get { return curCharacterExp; }
        set { curCharacterExp = value; }
    }
    // 스탯 배열
    [SerializeField] private StatSO[] stats;
    public StatSO[] StatSOs { get { return stats; } }
    // 플레이어 소지 골드
    [SerializeField] private int playerGold;
    public int PlayerGold
    { 
        get { return playerGold; }
        set { playerGold = value; }
    }
    // 소지 아이템 리스트
    [SerializeField] private List<ItemSO> listInventory;
    public List<ItemSO> ListInventory
    { 
        get { return listInventory; }
        set {  listInventory = value; }
    }
}