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
    private Vector3 currentAngle;

    void Update()
    {
        LRTilt = -LRHandle.value;
        UDTilt = UDHandle.value;

        currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, (LRTilt + 0.5f) * 120, Time.deltaTime), 0, Mathf.LerpAngle(currentAngle.z, (UDTilt - 0.5f) * 120, Time.deltaTime));
        transform.eulerAngles = currentAngle;
    }
}
