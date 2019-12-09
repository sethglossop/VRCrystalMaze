using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    private TextMesh textMesh;
    public Transform spawn;
    public GameObject winCrystal;
    public bool finish = false;
    public string zone;
    public float seconds;
    private float timer;
    private int countdown = 5;
    public AudioSource tick;
    public AudioSource win;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds < 0)
        {
            Lose();
        }

        if (!finish)
        {
            seconds -= Time.deltaTime;
            timer = Mathf.Ceil(seconds);
            textMesh.text = "Find the crystal!\n" + timer + " seconds to go\nTouch the door to give up";
            if (timer == countdown)
            {
                tick.Play();
                countdown--;
            }
        }
    }

    public void Win()
    {
        finish = true;
        win.Play();
        textMesh.text = "You win! Touch the crystal to exit";
        if (zone == "Aztec")
        {
            Crystals.Aztec = 1;
        }
        else if (zone == "Medieval")
        {
            Crystals.Medieval = 1;
        }
        else if (zone == "Futuristic")
        {
            Crystals.Futuristic = 1;
        }
        else if (zone == "Ocean")
        {
            Crystals.Ocean = 1;
        }
        Instantiate(winCrystal, spawn);
    }

    private void Lose()
    {
        tick.Stop();
        finish = true;
        textMesh.text = "You lose!\nTouch the door to exit";
    }
}
