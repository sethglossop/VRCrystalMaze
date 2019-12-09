using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore : MonoBehaviour
{
    private TextMesh textMesh;
    private LevelDome levelDome;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        levelDome = FindObjectOfType<LevelDome>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Gold: " + levelDome.goldScore + "\nSilver: -" + levelDome.silverScore + "\nTotal: " + levelDome.totalScore;
    }
}
