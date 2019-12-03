using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLeftPanel : MonoBehaviour
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
            textMesh.text = "WELCOME TO THE\nCRYSTAL MAZE\n\nYou have 2 minutes in each\nzone to collect the crystal\n\nEach crystal gives 10\nadditional seconds in the\nCrystal Dome\n\nUse the trigger to pick up\nand use items\n\nHold the trackpad to teleport";
        }
        else if (levelDome.Level == 1)
        {
            textMesh.text = "Congratulations, you have\ncompleted every zone\n\nYou collected " + levelDome.crystals + " crystals,\ngiving you " + levelDome.time + " seconds\nin the dome\n\nGrab gold tokens to\nincrease your score;\navoid silver tokens that will\nreduce your score\n\nScore at least 10 points to win!";
        }
    }
}
