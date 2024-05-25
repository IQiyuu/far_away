using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanctuary : MonoBehaviour
{
    char                    _color;
    List<char>              _ressources;

    Dictionary<List<char>,int>   _quest;
    bool                    _night;

    // Start is called before the first frame update
    void Start()
    {
        _ressources = new List<char>();
        _quest      = new Dictionary<List<char>, int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
