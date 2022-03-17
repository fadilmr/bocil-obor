using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class gameManager : MonoBehaviour
{
    public bool win = false;
    public bool over = false;
    public endGameBG gameoverscreen;
    public Light2D lt;
    // Start is called before the first frame update
    public void winGame()
    {
        if (win == false)
        {
            win = true;
            Debug.Log("You Win");
        }
    }
    public void lose()
    {
        gameoverscreen.setup();
        lt.pointLightOuterRadius = 8f;
    }
}
