﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTimer : MonoBehaviour
{
    private float timer = 0;
    public float stuntime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > stuntime)
        {
            timer = 0;
            gameObject.SetActive(false);
        }
    }
}
