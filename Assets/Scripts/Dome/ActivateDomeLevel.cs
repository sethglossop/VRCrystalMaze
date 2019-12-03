using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDomeLevel : MonoBehaviour
{
    private LevelDome levelDome;
    public int level;
    private int internalLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        levelDome = FindObjectOfType<LevelDome>();
    }

    // Update is called once per frame
    void Update()
    {
        if (levelDome.Level != level &&internalLevel != level)
        {
            gameObject.SetActive(false);
        }
    }
}
