using UnityEngine;

public class Character : MonoBehaviour
{
    private PlayerInfoSO playerInfo;
    public PlayerInfoSO PlayerInfo { get { return playerInfo; } }

    public Character(PlayerInfoSO _playerInfo)
    {
        playerInfo = _playerInfo;
        _playerInfo.MaxPlayerExp = _playerInfo.Exps[_playerInfo.CurPlayerLevel - 1];
    }

    public void AddItem(ItemSO _data)
    {
        playerInfo.ListInventory.Add(_data);
    }

    public void SetGold(int _value)
    {
        playerInfo.PlayerGold += _value;
    }

    public void AddExp(int _exp)
    {
        playerInfo.CurCharacterExp += _exp;

        if(playerInfo.MaxPlayerExp < playerInfo.CurCharacterExp)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        if (playerInfo.CurPlayerLevel == playerInfo.Exps.Length - 1) return;

        playerInfo.CurPlayerLevel++;

        if (playerInfo.CurPlayerLevel != playerInfo.Exps.Length - 1)
        {
            playerInfo.CurCharacterExp = playerInfo.CurCharacterExp - playerInfo.MaxPlayerExp;
            playerInfo.MaxPlayerExp = playerInfo.Exps[playerInfo.CurPlayerLevel - 1];
        }
        else
        {
            playerInfo.CurCharacterExp = playerInfo.MaxPlayerExp;
        }
    }
}
