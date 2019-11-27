using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform minuteHand;
    public Transform hourHand;
    private float minuteAngle;
    private float hourAngle;
    private BoxCollider boxCollider;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        minuteAngle = minuteHand.localEulerAngles.z;
        hourAngle = hourHand.localEulerAngles.z;

        if (hourAngle > 265 && hourAngle < 275 & minuteAngle < 155 && minuteAngle > 145)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
