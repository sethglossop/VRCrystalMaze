using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    private TextMesh textMesh;
    private float timer;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        timer = Mathf.Floor(seconds);
        textMesh.text = "Seconds: " + timer;
    }
}
