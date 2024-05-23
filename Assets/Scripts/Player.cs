using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int _score;
    List<Region> _regions;
    List<Sanctuary> _sanctuaries;

    // Start is called before the first frame update
    void Start()
    {
        _regions = new List<Region>();
        _sanctuaries = new List<Sanctuary>();
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void    addRegion(Region nRegion) {
        _regions.Add(nRegion);
    }

    void    addSanctuary(Sanctuary nSanctuary) {
        _sanctuaries.Add(nSanctuary);
    }
}
