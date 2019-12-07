using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public LevelTimer level;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level.finish)
        {
            spawn.transform.parent = null;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        level.Win();
        Destroy(other.gameObject);
    }
}
