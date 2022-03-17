using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    private float distx;
    private float disty;
    public GameObject player;
    private void Update()
    {
        distx = (player.transform.position.x - transform.position.x);
        disty = (player.transform.position.y - transform.position.y);
        if (distx <= 1.5 && distx >= -1.5 && disty <= 1.5 && disty >= -1.5)
        {
            FindObjectOfType<gameManager>().winGame();
        }
    }
}
