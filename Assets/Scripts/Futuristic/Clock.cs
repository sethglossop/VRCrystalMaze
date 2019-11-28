using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform minuteHand;
    public Transform hourHand;
    private float minuteAngle;
    private float hourAngle;
    private bool correctTime;
    public GameObject door;
    public GameObject inactiveCube;
    public GameObject inactiveCylinder;
    public GameObject inactiveSphere;
    public Transform cubeSpawn;
    public Transform cylinderSpawn;
    public Transform sphereSpawn;
    public GameObject activeCube;
    public GameObject activeCylinder;
    public GameObject activeSphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        minuteAngle = minuteHand.localEulerAngles.z;
        hourAngle = hourHand.localEulerAngles.z;

        if (!correctTime && hourAngle > 265 && hourAngle < 275 & minuteAngle < 155 && minuteAngle > 145)
        {
            correctTime = true;
            CorrectTime();
        }
    }
    private void CorrectTime()
    {
        Destroy(door);
        Destroy(inactiveCube);
        Destroy(inactiveCylinder);
        Destroy(inactiveSphere);
        Instantiate(activeCube, cubeSpawn);
        Instantiate(activeCylinder, cylinderSpawn);
        Instantiate(activeSphere, sphereSpawn);
    }

}
