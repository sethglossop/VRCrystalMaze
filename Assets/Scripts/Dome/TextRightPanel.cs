using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRightPanel : MonoBehaviour
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
        if (levelDome.Level == 0)
        {
            textMesh.text = "TURN AROUND AND\nTOUCH A DOOR\nTO ENTER";
        }
        else if (levelDome.Level == 1)
        {
            textMesh.text = "ENTER THE DOME AND\nTOUCH THE CRYSTAL\nTO BEGIN";
        }
    }
}
