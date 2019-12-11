using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDomeLevel : MonoBehaviour
{
    private LevelDome levelDome;
    public int level;
    private int internalLevel = 0;

    void Start()
    {
        levelDome = FindObjectOfType<LevelDome>();
    }

    void Update()
    {
        if (levelDome.Level != level &&internalLevel != level)
        {
            gameObject.SetActive(false);
        }
    }
}
