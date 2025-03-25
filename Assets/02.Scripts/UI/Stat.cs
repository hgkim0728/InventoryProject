using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    [SerializeField] private Text statNameText;
    [SerializeField] private Text statValueText;
    [SerializeField] private Image statImage;

    public void SetStat(StatSO _data)
    {
        statImage.sprite = _data.StatImage;
        statNameText.text = _data.StatName;
        statValueText.text = _data.StatValue.ToString();
    }
}
