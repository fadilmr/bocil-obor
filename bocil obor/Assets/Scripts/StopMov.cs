using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class StopMov : MonoBehaviour
{
    public GameObject obor;
    public AIPath aipath;
    private float distx;
    private float disty;

    private void Start()
    {
        aipath.maxSpeed = 0;
    }


    private void Update()
    {
        distx = (obor.transform.position.x - transform.position.x);
        disty = (obor.transform.position.y - transform.position.y);
        if (distx <= 4 && distx >= -4 && disty <= 4 && disty >= -4)
        {
            aipath.maxSpeed = 1f;
        } else
        {
            aipath.maxSpeed = 0;
        }


    }
}
