using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int             _players;
    [SerializeField] RegionDeck       _pioche;
    List<RegionData>                _board;
    List<Sanctuary> _sanct;

    [SerializeField] GameObject _regionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _players = 1;

        _board = new List<RegionData>();

        _pioche.LoadRegions();
        //_pioche.ShuffleDeck();            
        refillBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void    refillBoard() {
        _board.Clear();
        for(int i = 0; i < _players; i++) {
            RegionData tmp = _pioche.DrawRegion();
            Debug.Log(tmp.timeExplo);
            _board.Add(tmp);
            GameObject nRegion = Instantiate(_regionPrefab);
            RegionController rTmp = nRegion.GetComponent<RegionController>();
            rTmp.regionData = tmp;
            rTmp.InitializeVisu();
        }
    }

    // List<Sanctuary> getRewards(int n) {
    //     List<Sanctuary> ret = new List<Sanctuary>();

    //     for (int i = 0; i < n; i++) {
    //         ret.Add(_sanct[0]);
    //         _sanct.RemoveAt(0);
    //     }
    //     return ret;
    // }
}
