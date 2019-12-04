using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    private TextMesh textMesh;
    private float timer;
    public float seconds;
    public Transform spawn;
    public GameObject winCrystal;
    public GameObject loseCrystal;
    public bool finish = false;
    public string zone;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!finish)
        {
            if (seconds > 0)
            {
                seconds -= Time.deltaTime;
                timer = Mathf.Ceil(seconds);
                textMesh.text = "Seconds: " + timer;
            }
            else
            {
                Lose();
            }
        }
    }

    public void Win()
    {
        finish = true;
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

    public void Lose()
    {
        finish = true;
        textMesh.text = "You lose! Touch the crystal to exit";
        if (zone == "Aztec")
        {
            Crystals.Aztec = 2;
        }
        else if (zone == "Medieval")
        {
            Crystals.Medieval = 2;
        }
        else if (zone == "Futuristic")
        {
            Crystals.Futuristic = 2;
        }
        else if (zone == "Ocean")
        {
            Crystals.Ocean = 2;
        }
        Instantiate(loseCrystal, spawn);
    }
}
