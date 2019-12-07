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
            textMesh.text = "Find the crystal!\nTouch the door to give up";
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
}
