using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.Experimental.Rendering.Universal;

public class enemyRun : MonoBehaviour
{
    public GameObject obor;
    public AIPath aipath;
    private float distx;
    private float disty;
    public Light2D lt;
    private Color changecolor;

    void Start()
    {
        aipath.maxSpeed = 0f;
    }

        
    // Update is called once per frame
    void Update()
    {
        distx = (obor.transform.position.x - transform.position.x);
        disty = (obor.transform.position.y - transform.position.y);
        if ((distx <= 4 && distx >= -4) && (disty <= 4 && disty >= -4))
        {
            aipath.maxSpeed = 0.7f;
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
