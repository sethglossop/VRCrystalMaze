using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    public Transform player;
    private Quaternion aim;

    void Update()
    {
        aim = Quaternion.LookRotation(player.position - transform.position, Vector3.up);
        transform.rotation = aim;
    }
}
