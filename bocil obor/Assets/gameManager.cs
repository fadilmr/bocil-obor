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
    public winBG winscreen;
    // Start is called before the first frame update
    public void winGame()
    {
        winscreen.win();
        Time.timeScale = 0f;
    }
    public void lose()
    {
        gameoverscreen.setup();
        lt.pointLightOuterRadius = 10f;
        Time.timeScale = 0f;
    }
}
