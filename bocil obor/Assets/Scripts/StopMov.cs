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
    public float updown;
    public float leftright;
    public AudioSource audio;
    private void Start()
    {
        aipath.maxSpeed = 0f;
    }

    private void Update()
    {
        distx = (obor.transform.position.x - transform.position.x);
        disty = (obor.transform.position.y - transform.position.y);

        if (distx <= 8 && distx >= -8 && disty <= 8 && disty >= -8)
        {
            aipath.maxSpeed = 1.5f;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        } else
        {
            aipath.maxSpeed = 0f;
            audio.Stop();
        }

        updown = aipath.desiredVelocity.y;
        leftright = aipath.desiredVelocity.x;
        animator.SetFloat("speed", aipath.maxSpeed);
        animator.SetFloat("Vertical", updown);
        animator.SetFloat("Horizontal", leftright);
    }
}
