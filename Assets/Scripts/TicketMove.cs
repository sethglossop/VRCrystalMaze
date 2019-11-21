using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketMove : MonoBehaviour
{
    private Rigidbody rb;
    private int fanforce = 500;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1)
        {
            rb.AddForce(Random.Range(-1f,1f)*fanforce, (1 - transform.position.y)*fanforce, Random.Range(-1f, 1f)*fanforce);
        }

        
    }
}
