using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedieval : MonoBehaviour
{ 
    public int targets;
    private LevelTimer levelTimer;
  
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
        levelTimer = FindObjectOfType<LevelTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targets == 0)
        {
            levelTimer.Win();
        }
    }
}
