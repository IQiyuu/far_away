using UnityEngine;
using UnityEngine.UI;

public class RegionController : MonoBehaviour
{
    public RegionData regionData;

    [SerializeField] SpriteRenderer _dayNightColor;
    [SerializeField] SpriteRenderer _cardColor;

    [SerializeField] Text           _exploTime;

    public void InitializeVisu() {
        switch (regionData.color[0]) {
            case 'G':
                _cardColor.color = Color.green;
                break ;
            case 'B':
                _cardColor.color = Color.blue;
                break ;
            case 'R':
                _cardColor.color = Color.red;
                break ;
            default:
                _cardColor.color = Color.yellow;
                break ;
        }
        _dayNightColor.color = regionData.day ? Color.yellow:Color.black;
        _exploTime.text = regionData.timeExplo.ToString();
    }
}