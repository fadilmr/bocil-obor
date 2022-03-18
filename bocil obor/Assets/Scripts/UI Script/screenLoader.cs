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

    public void lvlSelect()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void lvl1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void lvl2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void lvl3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void lvl4()
    {
        SceneManager.LoadScene("Scene4");
    }

    public void lvl5()
    {
        SceneManager.LoadScene("Scene5");
    }
}
