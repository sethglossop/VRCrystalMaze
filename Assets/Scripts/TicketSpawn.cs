using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketSpawn : MonoBehaviour
{
    public int goldquantity;
    public GameObject gold;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < goldquantity; i++ )
        {
            Vector3 circle = new Vector3(Random.Range(-4f, 4f), 0, Random.Range(-4f, 4f));
            GameObject ticket = Instantiate(gold, transform.position + circle, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
