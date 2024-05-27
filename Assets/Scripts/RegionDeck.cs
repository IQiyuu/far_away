using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RegionDeck : MonoBehaviour
{
    public string regionJsonFileName = "Regions.json"; // Assurez-vous que le nom du fichier correspond
    private List<RegionData> deck;

    void Start()
    {
        LoadRegions();
    }

    public void LoadRegions()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "Regions.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            RegionCollection regionCollection = JsonUtility.FromJson<RegionCollection>(json);
            deck = regionCollection.cards;
            Debug.Log("Regions loaded: " + deck.Count);
        }
        else
        {
            Debug.LogError("Cannot find Regions file at " + path);
        }
    }

    public RegionData DrawRegion()
    {
        if (deck != null && deck.Count > 0)
        {
            RegionData drawnRegion = deck[0];
            deck.RemoveAt(0);
            return drawnRegion;
        }
        else
        {
            Debug.LogWarning("The deck is empty or not loaded.");
            return null;
        }
    }

    public void ShuffleDeck()
    {
        if (deck != null)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                RegionData temp = deck[i];
                int randomIndex = Random.Range(i, deck.Count);
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }
        else
        {
            Debug.LogWarning("The deck is not loaded.");
        }
    }
}
