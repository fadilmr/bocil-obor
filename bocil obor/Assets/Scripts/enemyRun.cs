using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.Experimental.Rendering.Universal;

public class enemyRun : MonoBehaviour
{
    public GameObject obor;
    public AIPath aipath;
    private float dist;
    public Light2D lt;
    private Color changecolor;

    void Start()
    {
        aipath.maxSpeed = 0f;
    }

        
    // Update is called once per frame
    void Update()
    {
        dist = (obor.transform.position.x - transform.position.x);
        if (dist <= 6 && dist >= -6)
        {
            aipath.maxSpeed = 0.5f;
            changecolor = new Color32(224, 129, 117, 255);
            lt.color = changecolor;

        }
        else
        {
            aipath.maxSpeed = 0;
            changecolor = new Color32(243, 217, 177, 255);
            lt.color = changecolor;
        }
    }
}
