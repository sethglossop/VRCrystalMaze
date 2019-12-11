using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColour : MonoBehaviour
{
    private Light lamp;
    public bool red = false;
    public bool blue = false;
    public bool green = false;

    void Start()
    {
        lamp = GetComponent<Light>();
    }

    void Update()
    {
        if (red && blue && green)
        {
            lamp.color = Color.white;
        }
        else if (red && blue && !green)
        {
            lamp.color = Color.magenta;
        }
        else if (red && !blue && green)
        {
            lamp.color = Color.yellow;
        }
        else if (!red && blue && green)
        {
            lamp.color = Color.cyan;
        }
        else if (red && !blue && !green)
        {
            lamp.color = Color.red;
        }
        else if (!red && blue && !green)
        {
            lamp.color = Color.blue;
        }
        else if (!red && !blue && green)
        {
            lamp.color = Color.green;
        }
        else
        {
            lamp.color = Color.black;
        }

    }

    public void Red()
    {
        red = !red;
    }
    public void Blue()
    {
        blue = !blue;
    }
    public void Green()
    {
        green = !green;
    }
}
