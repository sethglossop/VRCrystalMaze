using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    private LevelDome levelDome;
    private TextMesh textMesh;
    private float timer;
    public float seconds;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        levelDome = FindObjectOfType<LevelDome>();
        seconds = levelDome.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > 0)
        {
            seconds -= Time.deltaTime;
            timer = Mathf.Floor(seconds);
            textMesh.text = "Seconds: " + timer;
        }
        else
        {
            Finish();
        }
    }

    private void Finish()
    {
        levelDome.time = 0;
        if(levelDome.totalScore >= levelDome.toWin)
        {
            textMesh.text = "Time up, you win!";
        }
        else
        {
            textMesh.text = "Time up, you lose!";
        }
    }
}
