using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class MazeTilt : MonoBehaviour
{
    public LinearMapping LRHandle;
    public LinearMapping UDHandle;
    private float LRTilt;
    private float UDTilt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LRTilt = -LRHandle.value;
        UDTilt = UDHandle.value;
        transform.rotation = Quaternion.Euler(new Vector3((LRTilt + 0.5f) * 120, 0, (UDTilt - 0.5f) * 120));
    }
}
