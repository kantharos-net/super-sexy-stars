using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initial : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        // TODO: Load text path from config file and load text from rules file
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Initial");
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
