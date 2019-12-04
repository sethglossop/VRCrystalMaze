using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDestroy : MonoBehaviour
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawn.transform.parent = null;
        level.Win();
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
