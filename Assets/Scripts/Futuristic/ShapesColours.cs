﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesColours : MonoBehaviour
{
    public ObjectTable cubeTable;
    public ObjectTable cylinderTable;
    public ObjectTable sphereTable;
    public LightColour redLight;
    public LightColour cyanLight;
    public LightColour yellowLight;
    public WinLose level;

    void Update()
    {
        if (cubeTable.correct && cylinderTable.correct && sphereTable.correct && redLight.red && cyanLight.green && cyanLight.blue && yellowLight.red && yellowLight.green && !level.finish)
        {
            level.Win();
        }
    }
}
