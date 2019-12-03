using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public float maxSpeed;
    private LevelMedieval level;
    private int maxTargets;

    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<LevelMedieval>();
        maxTargets = level.targets;
    }

    // Update is called once per frame
    void Update()
    {
        if (level.targets > 0 && level.timeLimit > 0)
        {
            transform.Rotate(0, maxSpeed * (1 - level.targets / maxTargets), 0);
        }
    }
}
