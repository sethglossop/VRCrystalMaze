using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDome : MonoBehaviour
{
    public int Level = 0;
    public int goldScore = 0;
    public int silverScore = 0;
    public int totalScore = 0;
    public int crystals;
    public float time;
    public int toWin;
    
    void Start()
    {
        if (Crystals.Aztec == 0 || Crystals.Medieval == 0 || Crystals.Futuristic == 0 || Crystals.Ocean == 0)
        {
            Level = 0;
        }
        else
        {
            Level = 1;
        }
        crystals = (Crystals.Aztec % 2) + (Crystals.Medieval % 2) + (Crystals.Futuristic % 2) + (Crystals.Medieval % 2);
        time = 20 + (crystals*10);
    }

    void Update()
    {
        totalScore = goldScore - silverScore;
    }
}
