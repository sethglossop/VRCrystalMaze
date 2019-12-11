using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedieval : MonoBehaviour
{ 
    public float targets;
    private WinLose winLose;

    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
        winLose = FindObjectOfType<WinLose>();
    }

    void Update()
    {
        if (targets == 0 && !winLose.finish)
        {
            winLose.Win();
        }
    }
}
