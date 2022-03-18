using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenLoader : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
    }

    public void startgame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}