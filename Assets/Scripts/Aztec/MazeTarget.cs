using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTarget : MonoBehaviour
{
    public WinLose level;

    private void OnTriggerEnter(Collider other)
    {
        if (!level.finish)
        {
            Destroy(gameObject);
            level.Win();
        }
    }
}
