using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int             _players;
    List<Region>    _pioche;
    List<Region>    _board;
    List<Sanctuary> _sanct;

    [SerializeField] GameObject _regionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _pioche = new List<Region>();
        _board = new List<Region>();
        _players = 1;
        Region tmp2 = new Region();
        tmp2.setColor('G');
        tmp2.setDay(true);
        _pioche.Add(tmp2);
        refillBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void    refillBoard() {
        _board.Clear();
        for(int i = 0; i < _players; i++) {
            Debug.Log("OUI");
            _board.Add(_pioche[0]);
            _pioche.RemoveAt(0);
            GameObject nRegion = Instantiate(_regionPrefab);
            Region tmp = nRegion.GetComponent<Region>();
            tmp.changeDayNight(_board[0].getDay());
            tmp.changeColor(_board[0].getColor());
        }
    }

    List<Sanctuary> getRewards(int n) {
        List<Sanctuary> ret = new List<Sanctuary>();

        for (int i = 0; i < n; i++) {
            ret.Add(_sanct[0]);
            _sanct.RemoveAt(0);
        }
        return ret;
    }
}
