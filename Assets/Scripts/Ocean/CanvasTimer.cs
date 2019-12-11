using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTimer : MonoBehaviour
{
    private float timer = 0;
    public float stuntime;

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
