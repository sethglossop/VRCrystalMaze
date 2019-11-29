using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedieval : MonoBehaviour
{ 
    public int targets;
    public float timeLimit;
  
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if (targets == 0)
        {
            Win();
        }

        if (timeLimit == 0)
        {
            Lose();
        }
    }

    void Win()
    {

    }

    void Lose()
    {

    }
}
