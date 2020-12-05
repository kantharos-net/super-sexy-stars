using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start Menu");

    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadCopyrightScene()
    {
        SceneManager.LoadScene("Copyright");
    }
    public void LoadRulesScene()
    {
        SceneManager.LoadScene("Rules");
    }

    public void QuitGame()
    {
    Application.Quit();
    }
}