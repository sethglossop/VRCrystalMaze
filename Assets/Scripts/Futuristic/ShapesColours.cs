using System.Collections;
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
    public LevelTimer level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cubeTable.correct && cylinderTable.correct && sphereTable.correct && redLight.red && cyanLight.green && cyanLight.blue && yellowLight.red && yellowLight.green)
        {
            level.Win();
        }
    }
}
