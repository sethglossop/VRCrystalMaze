using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTarget : MonoBehaviour
{
    public WinLose level;
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
        if (!level.finish)
        {
            Destroy(gameObject);
            level.Win();
        }
    }
}
