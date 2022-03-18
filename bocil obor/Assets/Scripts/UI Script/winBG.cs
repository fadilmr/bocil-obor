using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winBG : MonoBehaviour
{
    public GameObject bg;
    
    public void win()
    {
        bg.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene("LevelTesting");
    }
}
