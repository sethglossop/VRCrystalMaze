using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball;
    private float timeelapsed = 0;
    private float maxtime = 5;
    public AudioSource cannon;

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
        cannon.Play();
        Instantiate(ball, transform.position,Quaternion.identity);
        timeelapsed = 0;
    }
}
