using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private CannonMove cannonMove;
    private Transform player;
    private Vector3 aim;
    private float speed = 1.5f;
    private float destroyTime = 0;

    void Start()
    {
        cannonMove = FindObjectOfType<CannonMove>();
        player = cannonMove.player;
        aim = player.transform.position - transform.position;
    }

    void Update()
    {
        transform.Translate(aim*speed*Time.deltaTime);
        destroyTime += Time.deltaTime;
        if (destroyTime > 3)
        {
            Destroy(gameObject);
        }
    }
}
