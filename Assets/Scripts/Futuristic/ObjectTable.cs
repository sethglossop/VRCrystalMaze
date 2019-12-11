using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTable : MonoBehaviour
{
    public string shape;
    public bool correct = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == shape)
        {
            correct = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == shape)
        {
            correct = false;
        }
    }
}
