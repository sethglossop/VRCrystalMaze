using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalColour : MonoBehaviour
{
    private Renderer original;
    public Material win;
    public Material lose;
    public string zone;
    private int zoneref;

    // Start is called before the first frame update
    void Start()
    {
        original = GetComponent<Renderer>();

        if (zone == "Aztec")
        {
            zoneref = Crystals.Aztec;
        }
        else if (zone == "Medieval")
        {
            zoneref = Crystals.Medieval;
        }
        else if (zone == "Futuristic")
        {
            zoneref = Crystals.Futuristic;
        }
        else if (zone == "Ocean")
        {
            zoneref = Crystals.Ocean;
        }

        if (zoneref == 1)
        {
            original.material = win;
        }
        else if (zoneref == 2)
        {
            original.material = lose;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
