using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public float rotation = 90;
    public float fallingTime = 1;
    private bool targetHit = false;
    private float elapsedTime;
    private float fallingRate;
    private LevelMedieval level;

    void Start()
    {
        level = FindObjectOfType<LevelMedieval>();
        fallingRate = rotation / fallingTime;
    }

    void Update()
    {
        if (targetHit && elapsedTime < fallingTime)
        {
            transform.Rotate(fallingRate * Time.deltaTime, 0, 0, Space.Self);
            elapsedTime += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!targetHit && other.gameObject.CompareTag("projectile")) {
            targetHit = true;
            level.targets -= 1;
            elapsedTime = 0;
        }
    }
}
