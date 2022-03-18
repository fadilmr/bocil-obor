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
    public AudioSource audio;
    public Animator animator;
    void Start()
    {
        aipath.maxSpeed = 0f;
    }

        
    // Update is called once per frame
    void Update()
    {
        distx = (obor.transform.position.x - transform.position.x);
        disty = (obor.transform.position.y - transform.position.y);
        if ((distx <= 8 && distx >= -8) && (disty <= 8 && disty >= -8))
        {
            aipath.maxSpeed = 1f;
            changecolor = new Color32(224, 129, 117, 255);
            lt.color = changecolor;
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        else
        {
            aipath.maxSpeed = 0;
            changecolor = new Color32(243, 217, 177, 255);
            lt.color = changecolor;
            audio.Stop();
        }
        animator.SetFloat("speed", aipath.maxSpeed);
    }
}
