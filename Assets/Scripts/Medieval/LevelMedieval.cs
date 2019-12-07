using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedieval : MonoBehaviour
{ 
    public float targets;
    private WinLose levelTimer;
  
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
        levelTimer = FindObjectOfType<WinLose>();
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
