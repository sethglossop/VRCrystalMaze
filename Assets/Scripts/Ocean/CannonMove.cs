using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    public Transform player;
    private Quaternion aim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aim = Quaternion.LookRotation(player.position - transform.position, Vector3.up);
        transform.rotation = aim;
    }
}
