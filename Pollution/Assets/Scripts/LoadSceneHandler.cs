using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneHandler : MonoBehaviour
{
    public void loadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void quitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
