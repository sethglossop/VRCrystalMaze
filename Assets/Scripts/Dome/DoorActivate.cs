using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivate : MonoBehaviour
{
    public string zone;
    private int zoneref;

    void Start()
    {
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

        if (zoneref != 0)
        {
            gameObject.SetActive(false);
        }
    }
}
