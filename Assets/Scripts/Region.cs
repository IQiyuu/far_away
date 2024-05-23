using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    char                    _color;
    List<char>              _ressources;
    int                     _exploTime;
    bool                    _day;
    List<char>              _questReq;
    Dictionary<char, int>   _quest;

    [SerializeField] SpriteRenderer _cardColor;
    [SerializeField] SpriteRenderer _dayNightColor;

    // Start is called before the first frame update
    void Start()
    {
        _ressources = new List<char>();
        _questReq = new List<char>();
        _quest = new Dictionary<char, int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor(char c) {
        _color = c;
        switch (c) {
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
    }

    public void changeDayNight(bool d) {
        _day = d;
        _dayNightColor.color = d ? Color.yellow:Color.black;
    }

    public bool getDay() {
        return _day;
    }

    public char getColor() {
        return _color;
    }

    public void setDay(bool d) {
        _day = d;
    }

    public void setColor(char c) {
        _color = c;
    }
}
