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
    public AudioSource sound;
    public Text otherClock;
    private int hour;
    private int minute;

    // Start is called before the first frame update
    void Start()
    {
        hour = Random.Range(1, 12);
        minute = 5*Random.Range(0, 11);
        otherClock.text = hour + ":" + minute;
    }

    // Update is called once per frame
    void Update()
    {
        minuteAngle = minuteHand.localEulerAngles.z;
        hourAngle = hourHand.localEulerAngles.z;

        //        if (!correctTime && hourAngle > 265 && hourAngle < 275 & minuteAngle < 155 && minuteAngle > 145)
        if (!correctTime && hourAngle > (355 - (30 * hour)) && hourAngle < (365 - (30 * hour)) + 5 & minuteAngle < (365 - (6 * minute)) && minuteAngle > (355 - (6 * minute)))
        {
            correctTime = true;
            CorrectTime();
        }
    }
    private void CorrectTime()
    {
        sound.Play();
        Destroy(door);
        Destroy(inactiveCube);
        Destroy(inactiveCylinder);
        Destroy(inactiveSphere);
        Instantiate(activeCube, cubeSpawn);
        Instantiate(activeCylinder, cylinderSpawn);
        Instantiate(activeSphere, sphereSpawn);
    }

}
