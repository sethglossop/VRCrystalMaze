using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedieval : MonoBehaviour
{ 
    public int targets;
    public float timeLimit;
    public GameObject chandelier;
  
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (targets > 0)
        {
            timeLimit -= Time.deltaTime;
            if (timeLimit == 0)
            {

            }
        }

        if (timeLimit == 0)
        {
            
        }
    }
}
