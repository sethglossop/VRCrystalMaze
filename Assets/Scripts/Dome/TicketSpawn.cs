using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketSpawn : MonoBehaviour
{
    public int goldquantity;
    public int silverquantity;
    public GameObject goldspawn;
    public GameObject silverspawn;
    public float maxHeight;

    void Start()
    {
        for (int i = 0; i < goldquantity; i++ )
        {
            Vector3 height = new Vector3(0,Random.Range(0, maxHeight),0);
            Instantiate(goldspawn, transform.position + height,Quaternion.identity);
        }
        for (int i = 0; i < silverquantity; i++)
        {
            Vector3 height = new Vector3(0, Random.Range(0, maxHeight), 0);
            Instantiate(silverspawn, transform.position + height, Quaternion.identity);
        }
    }
}
