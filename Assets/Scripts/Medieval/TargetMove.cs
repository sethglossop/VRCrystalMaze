using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public float maxSpeed;
    private LevelMedieval level;
    public float maxTargets;
    private float currentSpeed;
    public WinLose winLose;

    void Start()
    {
        level = FindObjectOfType<LevelMedieval>();
        maxTargets = level.targets;
    }

    void Update()
    {
        if (!winLose.finish)
        {
            currentSpeed = 1 - (level.targets / maxTargets);
            transform.Rotate(0, maxSpeed * currentSpeed, 0);
        }
    }
}
