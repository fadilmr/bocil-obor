using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class StopMov : MonoBehaviour
{
    public GameObject obor;
    public AIPath aipath;
    private float dist;

    private void Start()
    {
        aipath.maxSpeed = 0;
    }


    private void Update()
    {
        dist = (obor.transform.position.x - transform.position.x);
        if (dist <= 3 && dist >= -3)
        {
            aipath.maxSpeed = 0.7f;
        } else
        {
            aipath.maxSpeed = 0;
        }


    }
}
