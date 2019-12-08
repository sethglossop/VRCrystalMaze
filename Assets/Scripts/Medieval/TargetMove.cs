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

    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<LevelMedieval>();
        maxTargets = level.targets;
    }

    // Update is called once per frame
    void Update()
    {
        if (!winLose.finish)
        {
            currentSpeed = 1 - (level.targets / maxTargets);
            transform.Rotate(0, maxSpeed * currentSpeed, 0);
        }
    }
}
