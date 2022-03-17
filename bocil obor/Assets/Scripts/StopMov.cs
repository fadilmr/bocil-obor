using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class StopMov : MonoBehaviour
{
    public GameObject obor;
    private float distx;
    private float disty;
    public AIPath aipath;
    public Animator animator;
    private void Start()
    {
        aipath.maxSpeed = 0f;
    }

    private void Update()
    {
        distx = (obor.transform.position.x - transform.position.x);
        disty = (obor.transform.position.y - transform.position.y);

        if (distx <= 5 && distx >= -5 && disty <= 5 && disty >= -5)
        {
            aipath.maxSpeed = 1f;
        } else
        {
            aipath.maxSpeed = 0f;
        }

        if (aipath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        } else if (aipath.desiredVelocity.x <= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        animator.SetFloat("speed", aipath.maxSpeed);
    }
}
