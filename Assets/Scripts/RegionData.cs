using System.Collections.Generic;

[System.Serializable]
public class RegionData
{
    public bool         day;
    public int          timeExplo;
    public string         color;
    public List<string>   ressources;
    public List<string>   questCond;
    public List<string>   questReq;
    public int          questRew;
}

[System.Serializable]
public class RegionCollection
{
    public List<RegionData> cards;
}
