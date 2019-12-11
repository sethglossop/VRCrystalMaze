using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public WinLose level;
    public GameObject spawn;
    public AudioSource destroy;

    private void OnTriggerEnter(Collider other)
    {
        destroy.Play();
        spawn.transform.parent = null;
        Destroy(gameObject);
        Destroy(other.gameObject);
        if (!level.finish)
        {
            level.Win();
        }
    }
}
