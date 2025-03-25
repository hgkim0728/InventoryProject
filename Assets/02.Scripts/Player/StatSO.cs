using UnityEngine;

[CreateAssetMenu(fileName = "new StatSO", menuName = "StatSO")]
public class StatSO : ScriptableObject
{
    [SerializeField] private Sprite statImage;
    public Sprite StatImage { get { return statImage; } }
    [SerializeField] private string statName;
    public string StatName { get { return statName; } }
    [SerializeField] private int statValue;
    public int StatValue
    {
        get { return statValue; }
        set { statValue = value; }
    }
}
