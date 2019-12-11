using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore : MonoBehaviour
{
    private TextMesh textMesh;
    private LevelDome levelDome;

    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        levelDome = FindObjectOfType<LevelDome>();
    }

    void Update()
    {
        textMesh.text = "Gold: " + levelDome.goldScore + "\nSilver: -" + levelDome.silverScore + "\nTotal: " + levelDome.totalScore;
    }
}
