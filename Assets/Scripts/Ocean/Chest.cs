using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public WinLose level;
    public GameObject spawn;
    public AudioSource destroy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
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
