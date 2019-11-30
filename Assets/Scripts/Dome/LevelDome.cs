using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDome : MonoBehaviour
{
    public int goldScore = 0;
    public int silverScore = 0;
    public int totalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalScore != goldScore + silverScore)
        {
            totalScore = goldScore + silverScore;
            Debug.Log("Gold: " + goldScore + "; Silver: " + silverScore + " Total: " + totalScore);

        }
    }
}
