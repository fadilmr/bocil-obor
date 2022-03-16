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

    void Start()
    {
        aipath.maxSpeed = 0f;
    }

        
    // Update is called once per frame
    void Update()
    {
        dist = (obor.transform.position.x - transform.position.x);
        if (dist <= 5 && dist >= -5)
        {
            aipath.maxSpeed = 0.5f;
        }
        else
        {
            aipath.maxSpeed = 0;
        }
    }
}
