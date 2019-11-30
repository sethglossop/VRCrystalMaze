using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball;
    private float timeelapsed = 0;
    private float maxtime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeelapsed += Time.deltaTime;
        if (timeelapsed > maxtime)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(ball, transform.position,Quaternion.identity);
        timeelapsed = 0;
    }
}
