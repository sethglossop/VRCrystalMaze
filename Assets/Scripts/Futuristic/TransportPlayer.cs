using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportPlayer : MonoBehaviour
{
    public void Transport(Transform location)
    {
        transform.position = location.position - Vector3.left*0.7f;
    }
}
