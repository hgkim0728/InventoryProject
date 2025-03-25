using UnityEngine;

public class Character : MonoBehaviour
{
    private PlayerInfoSO playerInfo;
    public PlayerInfoSO PlayerInfo { get { return playerInfo; } }

    public Character(PlayerInfoSO _playerInfo)
    {
        playerInfo = _playerInfo;
        _playerInfo.MaxPlayerExp = _playerInfo.Exps[_playerInfo.CurPlayerLevel - 2];
    }
}
