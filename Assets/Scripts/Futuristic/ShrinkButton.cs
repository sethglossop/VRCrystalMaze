using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ShrinkButton : MonoBehaviour
{
    private ShrinkPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<ShrinkPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shrink()
    {
        player.Shrink();
    }

    public void Grow()
    {
        player.Grow();
    }
}
