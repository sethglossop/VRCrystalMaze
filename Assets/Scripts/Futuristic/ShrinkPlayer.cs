using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlayer : MonoBehaviour
{
    private bool shrinking = false;
    private bool growing = false;
    private float elapsedtime;
    private float shrinkto = 0.5f;
    private float duration = 2;
    private float shrinkrate;
    private float growrate;

    // Start is called before the first frame update
    void Start()
    {
        shrinkrate = (1 - shrinkto) / duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (shrinking)
        {
            if (elapsedtime < duration)
            {
                transform.localScale -= Vector3.up * Time.deltaTime * shrinkrate;
                elapsedtime += Time.deltaTime;
            }
            else
            {
                shrinking = false;
            }
        }

        if (growing)
        {
            if (elapsedtime < duration)
            {
                transform.localScale += Vector3.up * Time.deltaTime * shrinkrate;
                elapsedtime += Time.deltaTime;
            }
            else
            {
                growing = false;
            }
        }
    }

    public void Shrink()
    {
        elapsedtime = 0;
        shrinking = true;
    }

    public void Grow()
    {
        elapsedtime = 0;
        growing = true;
    }
}
