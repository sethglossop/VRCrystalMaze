﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTable : MonoBehaviour
{
    public string shape;
    public bool correct = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
