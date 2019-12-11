using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    private LevelDome levelDome;
    private TextMesh textMesh;
    private float timer;
    public float seconds;
    private int countdown = 5;
    private bool finish = false;
    public GameObject spawn;
    public AudioSource tick;

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        levelDome = FindObjectOfType<LevelDome>();
        seconds = levelDome.time;
    }

    void Update()
    {
        if (seconds > 0 && !finish)
        {
            seconds -= Time.deltaTime;
            timer = Mathf.Floor(seconds);
            textMesh.text = "Seconds: " + timer;
            if (timer == countdown && countdown >= 0)
            {
                tick.Play();
                countdown--;
            }
        }
        else
        {
            Finish();
        }
    }

    private void Finish()
    {
        levelDome.time = 0;
        finish = true;
        if (levelDome.totalScore >= levelDome.toWin)
        {
            textMesh.text = "You win!";
        }
        else
        {
            textMesh.text = "Time up, you lose!";
        }
    }
}
