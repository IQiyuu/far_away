using System.Collections.Generic;

public class Region
{
    public bool         day;
    public int          timeExplo;
    public string         color;
    public List<string>   ressources;
    public List<string>   questCond;
    public List<string>   questReq;
    public int          questRew;

    public Region(bool day, int timeExplo, string color, List<string> ressources, List<string> questCond, List<string> questReq, int questRew)
    {
        this.day = day;
        this.timeExplo = timeExplo;
        this.color = color;
        this.ressources = ressources;
        this.questCond = questCond;
        this.questReq = questReq;
        this.questRew = questRew;
    }
}
